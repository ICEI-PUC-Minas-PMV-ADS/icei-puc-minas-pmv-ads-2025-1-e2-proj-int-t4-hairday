using System.Diagnostics;
using Hairday.Controllers;
using Hairday.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HairDay.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> BuscarBarbearia()
        {
            var barbearias = await _context.Barbearias.ToListAsync();

            if (barbearias == null || !barbearias.Any())
            {
                ViewBag.Mensagem = "Nenhuma barbearia encontrada.";
                return View();
            }

            return View(barbearias);
        }


        public async Task<IActionResult> BuscarBarbeariaPorNome(string nome)
        {
            var barbearias = await _context.Barbearias
                .Where(b => b.nome.Contains(nome))
                .ToListAsync();

            if (!barbearias.Any())
            {
                ViewBag.Mensagem = "Nenhuma barbearia encontrada com esse nome.";
                return View(new List<Barbearia>());
            }

            return View(barbearias);
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> FiltrarPorCabelo()
        {
            var barbeariasComCabelo = await _context.Barbearias
                .Include(b => b.servicos)
                .Where(b => b.servicos.Any(s => s.nome_servico.Contains("Cabelo")))
                .ToListAsync();

            return View(barbeariasComCabelo);
        }

        public async Task<IActionResult> FiltrarPorBarba() 
        {
            var barbeariasCombarba = await _context.Barbearias
                .Include(b => b.servicos)
                .Where(b => b.servicos.Any(s => s.nome_servico.Contains("Barba")))
                .ToListAsync();

            return View(barbeariasCombarba);

        }

        public async Task<IActionResult> FiltrarPorSobrancelha() 
        {
            var barbeariasComSobrancelha = await _context.Barbearias
                .Include(b => b.servicos)
                .Where(b => b.servicos.Any(s => s.nome_servico.Contains("Sobrancelha")))
                .ToListAsync();

            return View(barbeariasComSobrancelha);

        }

        public async Task<IActionResult> FiltrarPorSpa() 
        {
            var barbeariasComSpa = await _context.Barbearias
                .Include(b => b.servicos)
                .Where(b => b.servicos.Any(s => s.nome_servico.Contains("SPA")))
                .ToListAsync();

            return View(barbeariasComSpa);
        }
        
        public async Task<IActionResult> FiltrarPorMassagem() 
        {
            var barbeariasComMassagem = await _context.Barbearias
                .Include(b => b.servicos)
                .Where(b => b.servicos.Any(s => s.nome_servico.Contains("Massagem")))
                .ToListAsync();

            return View(barbeariasComMassagem);

        }

    }
}
