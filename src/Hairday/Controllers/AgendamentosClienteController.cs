using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hairday.Controllers
{
    public class AgendamentosClienteController : Controller
    {
        private readonly AppDbContext _context;

        public AgendamentosClienteController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> MeusAgendamentos()
        {
            // Recupera o ID do cliente da sessão
            var idCliente = HttpContext.Session.GetInt32("id");
            if (idCliente == null)
                return RedirectToAction("Login", "Account");

            var agendamentos = await _context.Agendamentos
                .Include(a => a.barbeiro)
                    .ThenInclude(b => b.barbearia)
                .Include(a => a.agendamento_servicos)
                    .ThenInclude(asv => asv.servico)
                .Where(a => a.id_cliente == idCliente)
                .ToListAsync();

            return View(agendamentos);
        }
    }
}
