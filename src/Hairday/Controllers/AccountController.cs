using Microsoft.AspNetCore.Mvc;
using Hairday.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Hairday.Controllers;

public class AccountController : Controller
{
    private readonly AppDbContext _context;

    public AccountController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string senha)
    {
        // Autenticar como Cliente
        var cliente = _context.Clientes.SingleOrDefault(c => c.email == email && c.senha == senha);
        if (cliente != null)
        {
            HttpContext.Session.SetString("tipo", "cliente");
            HttpContext.Session.SetInt32("id", cliente.id_cliente);
            HttpContext.Session.SetString("nome", cliente.nome);         
            return RedirectToAction("Index", "Home");
        }

        // Autenticar como Barbeiro
        // Autenticar como Barbeiro
        var barbeiro = _context.Barbeiros.SingleOrDefault(b => b.email == email && b.senha == senha);
        if (barbeiro != null)
        {
            HttpContext.Session.SetString("tipo", "barbeiro");
            HttpContext.Session.SetString("nome", barbeiro.nome);
            HttpContext.Session.SetString("CPF_Barbeiro", barbeiro.CPF_barbeiro);
            HttpContext.Session.SetString("TipoUsuario", "barbeiro");

            return RedirectToAction("Index", "AgendamentoBarbeiro"); // ✅ redirecionamento
        }


        // Autenticar como Dono da Barbearia
        var dono = _context.Barbearias.SingleOrDefault(d => d.email == email && d.senha == senha);
        if (dono != null)
        {
            HttpContext.Session.SetString("tipo", "dono");
            HttpContext.Session.SetString("nome", dono.nome); 
            HttpContext.Session.SetString("documento", dono.CNPJ_barbearia);
            return RedirectToAction("Painel", "Barbearia");
        }

        // Falha na autenticação
        ModelState.AddModelError(string.Empty, "Email ou senha inválidos.");
        return View();
    }
}
