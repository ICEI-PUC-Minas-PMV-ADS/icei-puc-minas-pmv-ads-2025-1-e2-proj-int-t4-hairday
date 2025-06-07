using Hairday.Models;
using Hairday.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hairday.Controllers
{
    public class ServicoController : Controller
    {
        private readonly AppDbContext _context;

        public ServicoController(AppDbContext context)
        {
            _context = context;
        }

        // GET
        public async Task<IActionResult> Create(string cpf)
        {
            var barbeiro = await _context.Barbeiros.FirstOrDefaultAsync(b => b.CPF_barbeiro == cpf);
            if (barbeiro == null)
                return NotFound();

            var viewModel = new ServicoFormViewModel
            {
                CPF_barbeiro = cpf,
                CNPJ_barbearia = barbeiro.CNPJ_barbearia,
                ServicosDisponiveis = new List<ServicoSelecionadoViewModel>
                {
                    new ServicoSelecionadoViewModel { NomeServico = "Cabelo" },
                    new ServicoSelecionadoViewModel { NomeServico = "Barba" },
                    new ServicoSelecionadoViewModel { NomeServico = "Sobrancelha" },
                    new ServicoSelecionadoViewModel { NomeServico = "SPA" },
                    new ServicoSelecionadoViewModel { NomeServico = "Massagem" }
                }
            };

            return View(viewModel);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServicoFormViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var servicosSelecionados = model.ServicosDisponiveis
                            .Where(s => s.Selecionado && s.Preco.HasValue)
                            .ToList();

            if (!servicosSelecionados.Any())
            {
                ModelState.AddModelError("", "Selecione pelo menos um serviço e defina um preço.");
                return View(model);
            }

            // Mapeia para entidades do banco
            var servicosParaSalvar = servicosSelecionados.Select(s => new Servico
            {
                nome_servico = s.NomeServico,
                preco = s.Preco.Value,
                CPF_barbeiro = model.CPF_barbeiro,
                CNPJ_barbearia = model.CNPJ_barbearia
            }).ToList();

            _context.Servicos.AddRange(servicosParaSalvar);
            await _context.SaveChangesAsync();

            return RedirectToAction("Login", "Account");
        }

        public async Task<IActionResult> Index()
        {
            var servicos = await _context.Servicos
                .Include(s => s.barbeiro)
                .ToListAsync();

            return View(servicos);
        }

    }
}
