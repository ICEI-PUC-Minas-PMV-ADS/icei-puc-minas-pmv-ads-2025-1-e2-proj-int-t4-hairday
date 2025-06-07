using Hairday.Models;
using Hairday.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hairday.Controllers
{
    public class AgendamentoBarbeiroController : Controller
    {
        private readonly AppDbContext _context;

        public AgendamentoBarbeiroController(AppDbContext context)
        {
            _context = context;
        }

        private List<DateTime> ObterProximos10Dias()
        {
            return Enumerable.Range(0, 10)
                .Select(i => DateTime.Today.AddDays(i))
                .ToList();
        }

        [HttpGet]
        public async Task<IActionResult> Index(DateTime? dataSelecionada, int? horarioId, int? idAgendamentoRemarcar)
        {
            string? barbeiroCPF = HttpContext.Session.GetString("CPF_Barbeiro");

            if (string.IsNullOrEmpty(barbeiroCPF))
            {
                return RedirectToAction("Login", "Account");
            }


            var proximasDatas = ObterProximos10Dias();

            if (!dataSelecionada.HasValue)
                dataSelecionada = proximasDatas.First();

            // Trocar h.data.Date por comparação via Year, Month, Day para compatibilidade com MySQL
            var horariosDisponiveis = await _context.Horario_Disponivel
                .Where(h =>
                    h.CPF_barbeiro == barbeiroCPF &&
                    h.data.Year == dataSelecionada.Value.Year &&
                    h.data.Month == dataSelecionada.Value.Month &&
                    h.data.Day == dataSelecionada.Value.Day)
                .OrderBy(h => h.hora) // ordena por hora para melhor visualização
                .ToListAsync();

            var viewModel = new AgendamentoBarbeiroViewModel
            {
                ProximasDatas = proximasDatas,
                DataSelecionada = dataSelecionada,
                HorariosDisponiveis = horariosDisponiveis,
                MostrarHorarios = true
            };

            // Modo Remarcação
            if (idAgendamentoRemarcar.HasValue)
            {
                var agendamento = await _context.Agendamentos
                    .Include(a => a.horarios_disponiveis)
                    .FirstOrDefaultAsync(a => a.id_agendamento == idAgendamentoRemarcar);

                if (agendamento != null)
                {
                    viewModel.EmModoRemarcacao = true;
                    viewModel.IdAgendamentoRemarcando = idAgendamentoRemarcar;

                    // Ajusta a data selecionada para a do agendamento atual
                    viewModel.DataSelecionada = agendamento.data.Date;

                    // Pega ids dos horários já vinculados ao agendamento para não exibi-los na lista
                    var idsHorariosAntigos = agendamento.horarios_disponiveis.Select(h => h.id_horario).ToList();

                    var dataAgendamento = agendamento.data.Date;

                    var horariosRemarcacao = await _context.Horario_Disponivel
                        .Where(h =>
                            h.CPF_barbeiro == barbeiroCPF &&
                            h.data.Year == dataAgendamento.Year &&
                            h.data.Month == dataAgendamento.Month &&
                            h.data.Day == dataAgendamento.Day &&
                            !h.ocupado &&
                            !idsHorariosAntigos.Contains(h.id_horario))
                        .OrderBy(h => h.hora)
                        .ToListAsync();

                    // Para depuração no console (remova depois)
                    foreach (var h in horariosRemarcacao)
                    {
                        Console.WriteLine($"Horario disponível para remarcação: ID={h.id_horario} Hora={h.hora} Data={h.data} Ocupado={h.ocupado}");
                    }

                    viewModel.HorariosDisponiveis = horariosRemarcacao;
                }
            }

            // Detalhes do agendamento selecionado (exibir dados do cliente, serviços, etc)
            if (horarioId.HasValue)
            {
                var horarioSelecionado = await _context.Horario_Disponivel
                    .Include(h => h.agendamento)
                        .ThenInclude(a => a.cliente)
                    .Include(h => h.agendamento)
                        .ThenInclude(a => a.agendamento_servicos)
                            .ThenInclude(asv => asv.servico)
                    .FirstOrDefaultAsync(h => h.id_horario == horarioId);

                if (horarioSelecionado?.agendamento != null)
                {
                    var agendamento = horarioSelecionado.agendamento;

                    viewModel.HorarioSelecionadoId = horarioId;
                    viewModel.AgendamentoSelecionado = agendamento;
                    viewModel.ClienteDoAgendamento = agendamento.cliente;
                    viewModel.Servicos = agendamento.agendamento_servicos
                        .Select(asv => asv.servico.nome_servico)
                        .ToList();
                    viewModel.MostrarDetalhes = true;
                }
            }

            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Cancelar(int idAgendamento)
        {
            try
            {
                // Verifica se o agendamento existe
                var agendamento = await _context.Agendamentos
                    .FirstOrDefaultAsync(a => a.id_agendamento == idAgendamento);

                if (idAgendamento <= 0)
                {
                    TempData["Erro"] = "ID do agendamento inválido.";
                    return RedirectToAction("Index");
                }


                await _context.Database.ExecuteSqlInterpolatedAsync(
    $"UPDATE horario_disponivel SET ocupado = 0, id_agendamento = NULL WHERE id_agendamento = {idAgendamento}");


                // Remove o agendamento
                _context.Agendamentos.Remove(agendamento);
                await _context.SaveChangesAsync();

                TempData["Mensagem"] = "Agendamento cancelado com sucesso.";
            }
            catch (Exception ex)
            {
                TempData["Erro"] = "Erro ao cancelar o agendamento. Tente novamente.";
            }

            return RedirectToAction("Index");
        }









        [HttpGet]
        public IActionResult Remarcar(int idAgendamento)
        {
            return RedirectToAction("Index", new { idAgendamentoRemarcar = idAgendamento });
        }


        [HttpPost]
        public async Task<IActionResult> ConfirmarRemarcacao(int idAgendamento, int novoHorarioId)
        {
            // Busca o agendamento
            var agendamento = await _context.Agendamentos
                .Include(a => a.horarios_disponiveis)
                .FirstOrDefaultAsync(a => a.id_agendamento == idAgendamento);

            if (agendamento == null)
            {
                TempData["Erro"] = "Agendamento não encontrado.";
                return RedirectToAction("Index");
            }

            // Busca o novo horário
            var novoHorario = await _context.Horario_Disponivel.FindAsync(novoHorarioId);

            if (novoHorario == null)
            {
                TempData["Erro"] = "Horário selecionado não encontrado.";
                return RedirectToAction("Index");
            }

            if (novoHorario.ocupado)
            {
                TempData["Erro"] = "O horário selecionado já está ocupado.";
                return RedirectToAction("Index");
            }

            if (!agendamento.horarios_disponiveis.Any())
            {
                TempData["Erro"] = "O agendamento atual não possui horário vinculado.";
                return RedirectToAction("Index");
            }

            try
            {
                // Libera os horários antigos
                foreach (var horario in agendamento.horarios_disponiveis)
                {
                    horario.ocupado = false;
                    horario.id_agendamento = null;
                }

                // Atualiza data e hora do agendamento
                agendamento.data = novoHorario.data;
                agendamento.hora = novoHorario.hora;

                // Vincula novo horário
                novoHorario.ocupado = true;
                novoHorario.id_agendamento = agendamento.id_agendamento;

                // Atualiza associação com o novo horário
                agendamento.horarios_disponiveis.Clear();
                agendamento.horarios_disponiveis.Add(novoHorario);

                await _context.SaveChangesAsync();

                TempData["Mensagem"] = "Agendamento remarcado com sucesso.";

                return RedirectToAction("Index", new
                {
                    dataSelecionada = novoHorario.data.ToString("yyyy-MM-dd"),
                    horarioId = novoHorario.id_horario
                });
            }
            catch (Exception ex)
            {
                TempData["Erro"] = "Erro ao remarcar: " + ex.Message;
                return RedirectToAction("Index");
            }
        }


    }
}