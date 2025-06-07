using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hairday.Models;
using Hairday.ViewModels;

//12345678901

namespace Hairday.Controllers
{
    public class HorarioDisponivelController : Controller
    {
        private readonly AppDbContext _context;

        public HorarioDisponivelController(AppDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Create(string cpf)
        {
            var viewModel = new HorarioDisponivelViewModel
            {
                CPF_barbeiro = cpf
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HorarioDisponivelViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Verificações adicionais de formulário vazio
            if (model.DiasSelecionados == null || !model.DiasSelecionados.Any())
            {
                ModelState.AddModelError("", "Selecione pelo menos um dia da semana.");
                return View(model);
            }

            if (model.HorariosSelecionados == null || !model.HorariosSelecionados.Any())
            {
                ModelState.AddModelError("", "Selecione pelo menos um horário disponível.");
                return View(model);
            }

            var barbeiroExiste = await _context.Barbeiros.AnyAsync(b => b.CPF_barbeiro == model.CPF_barbeiro);
            if (!barbeiroExiste)
            {
                ModelState.AddModelError("Erro", "Barbeiro nao foi encontrado!");
                return View(model);
            }

            DateTime hoje = DateTime.Today;
            DateTime fim = hoje.AddDays(30);

            var horariosParaSalvar = new List<Horario_Disponivel>();

            for (DateTime data = hoje; data <= fim; data = data.AddDays(1))
            {
                if (model.DiasSelecionados.Contains(data.DayOfWeek))
                {
                    foreach (var horaStr in model.HorariosSelecionados)
                    {
                        if (TimeSpan.TryParse(horaStr, out TimeSpan hora))
                        {
                            horariosParaSalvar.Add(new Horario_Disponivel
                            {
                                CPF_barbeiro = model.CPF_barbeiro,
                                data = data,
                                hora = hora,
                                ocupado = false
                            });
                        }
                    }
                }
            }

            _context.Horario_Disponivel.AddRange(horariosParaSalvar);
            await _context.SaveChangesAsync();

            return RedirectToAction("Create", "Servico", new { cpf = model.CPF_barbeiro });
        }

    }
}
