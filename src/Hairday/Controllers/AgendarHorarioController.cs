using Microsoft.AspNetCore.Mvc;
using Hairday.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Hairday.Controllers
{
    public class AgendarHorarioController : Controller
    {
        private readonly AppDbContext _context;

        public AgendarHorarioController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Selecionar(int id_servico, string cpfBarbeiro)
        {
            // Verifica se o usuário está logado e é cliente
            var tipoUsuario = HttpContext.Session.GetString("tipo");
            if (tipoUsuario != "cliente")
            {
                return RedirectToAction("Login", "Account");
            }

            TempData["id_servico"] = id_servico;
            TempData["cpfBarbeiro"] = cpfBarbeiro;
            TempData.Keep();

            var datas = Enumerable.Range(0, 10)
                .Select(i => DateTime.Today.AddDays(i))
                .ToList();

            ViewBag.Datas = datas;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> HorariosPorData(DateTime data)
        {
            // Apenas clientes logados
            if (HttpContext.Session.GetString("tipo") != "cliente")
                return Unauthorized();

            var cpfBarbeiro = TempData["cpfBarbeiro"]?.ToString();
            TempData.Keep();

            var horarios = await _context.Horario_Disponivel
                .Where(h => h.CPF_barbeiro == cpfBarbeiro && h.data == data && !h.ocupado)
                .OrderBy(h => h.hora)
                .ToListAsync();

            return PartialView("_HorariosDisponiveis", horarios);
        }

        [HttpGet]
        public async Task<IActionResult> DadosResumo(DateTime data, string hora)
        {
            if (HttpContext.Session.GetString("tipo") != "cliente")
                return Unauthorized();

            var cpfBarbeiro = TempData["cpfBarbeiro"]?.ToString();
            var idServico = Convert.ToInt32(TempData["id_servico"]);
            TempData.Keep();

            var barbeiro = await _context.Barbeiros
                .FirstOrDefaultAsync(b => b.CPF_barbeiro == cpfBarbeiro);

            var servico = await _context.Servicos
                .FirstOrDefaultAsync(s => s.id_servico == idServico);

            var horario = TimeSpan.ParseExact(hora, @"hh\:mm", CultureInfo.InvariantCulture);

            if (barbeiro == null || servico == null)
            {
                return NotFound();
            }

            var resultado = new
            {
                nomeBarbeiro = barbeiro.nome,
                nomeServico = servico.nome_servico,
                preco = servico.preco,
                data = data.ToString("dd/MM/yyyy"),
                hora = horario.ToString(@"hh\:mm")
            };

            return Json(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> AgendarHorario(DateTime dataSelecionada, string horaSelecionada)
        {
            if (HttpContext.Session.GetString("tipo") != "cliente")
                return Unauthorized();

            var cpfBarbeiro = TempData["cpfBarbeiro"]?.ToString();
            var idServico = Convert.ToInt32(TempData["id_servico"]);

            // Recupera o ID do cliente da sessão
            var idCliente = HttpContext.Session.GetInt32("id");
            if (idCliente == null)
                return RedirectToAction("Login", "Account");

            TempData.Keep();

            var barbeiro = await _context.Barbeiros
                .FirstOrDefaultAsync(b => b.CPF_barbeiro == cpfBarbeiro);

            if (barbeiro == null)
                return NotFound("Barbeiro não encontrado.");

            var horario = TimeSpan.ParseExact(horaSelecionada, @"hh\:mm", CultureInfo.InvariantCulture);

            var agendamento = new Agendamento
            {
                id_cliente = idCliente.Value,
                CPF_barbeiro = cpfBarbeiro,
                CNPJ_barbearia = barbeiro.CNPJ_barbearia,
                data = dataSelecionada,
                hora = horario
            };

            _context.Agendamentos.Add(agendamento);
            await _context.SaveChangesAsync();

            var agendamentoServico = new Agendamento_Servico
            {
                id_agendamento = agendamento.id_agendamento,
                id_servico = idServico
            };
            _context.Add(agendamentoServico);

            var horarioDb = await _context.Horario_Disponivel
                .FirstOrDefaultAsync(h =>
                    h.CPF_barbeiro == cpfBarbeiro &&
                    h.data == dataSelecionada &&
                    h.hora == horario);

            if (horarioDb != null)
            {
                horarioDb.ocupado = true;
                _context.Update(horarioDb);
            }

            await _context.SaveChangesAsync();

            TempData["Mensagem"] = "Agendamento realizado com sucesso!";
            return RedirectToAction("MeusAgendamentos", "AgendamentosCliente");

        }
    }
}
