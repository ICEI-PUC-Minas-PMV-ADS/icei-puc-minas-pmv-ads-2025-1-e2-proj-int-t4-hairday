using Microsoft.AspNetCore.Mvc;
using Hairday.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;


//cpfBarbeiro = "12345678901"
//id_servico == 1
//int idCliente = 1;


namespace Hairday.Controllers
{
    public class AgendarHorarioController : Controller
    {
        private readonly AppDbContext _context;

        public AgendarHorarioController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Selecionar()
        {
            var datas = Enumerable.Range(0, 10)
                .Select(i => DateTime.Today.AddDays(i))
                .ToList();

            ViewBag.Datas = datas;

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> HorariosPorData(DateTime data)
        {
            var cpfBarbeiro = "12345678901";

            var horarios = await _context.Horario_Disponivel
                .Where(h => h.CPF_barbeiro == cpfBarbeiro && h.data == data && !h.ocupado)
                .OrderBy(h => h.hora)
                .ToListAsync();

            return PartialView("_HorariosDisponiveis", horarios);
        }

        [HttpGet]
        public async Task<IActionResult> DadosResumo(DateTime data, string hora)
        {
            var cpfBarbeiro = "12345678901";

            var barbeiro = await _context.Barbeiros
                .FirstOrDefaultAsync(b => b.CPF_barbeiro == cpfBarbeiro);

            var horario = TimeSpan.ParseExact(hora, @"hh\:mm", CultureInfo.InvariantCulture);

            var servico = await _context.Servicos
                .FirstOrDefaultAsync(s => s.id_servico == 1);

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

       

    }
}
