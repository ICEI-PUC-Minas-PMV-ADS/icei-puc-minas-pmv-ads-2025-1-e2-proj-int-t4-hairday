using Hairday.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Hairday.Controllers
{
    public class ExibirAgendamentosBarbeariaController : Controller
    {
        private readonly AppDbContext _context;

        public ExibirAgendamentosBarbeariaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var datas = Enumerable.Range(0, 10)
                .Select(d => DateTime.Today.AddDays(d))
                .ToList();

            ViewBag.Datas = datas;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> BuscarAgendamentos(string dataSelecionada)
        {
            if (!DateTime.TryParse(dataSelecionada, out var data))
            {
                return BadRequest("Data inválida.");
            }


            var CNPJ_barbearia = HttpContext.Session.GetString("CNPJ_barbearia");

            var agendamentos = await _context.Agendamentos
                .Include(a => a.cliente)
                .Include(a => a.barbeiro)
                .Include(a => a.agendamento_servicos)
                    .ThenInclude(ags => ags.servico)
                .Where(a => a.data == data && a.barbeiro.CNPJ_barbearia == CNPJ_barbearia)
                .ToListAsync();

            return PartialView("Views/ExibirAgendamentosBarbearia/_HorariosReservados.cshtml", agendamentos);
        }
    }
}