using Microsoft.AspNetCore.Mvc;
using Hairday.Models;
using System;
using System.Linq;
using Hairday.Controllers;

public class AgendarHorarioController : Controller
{
    private readonly AppDbContext _context;

    public AgendarHorarioController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Selecionar()
    {
        ViewBag.ProximosDias = Enumerable.Range(0, 10)
            .Select(i => DateTime.Today.AddDays(i))
            .ToList();

        return View();
    }

    [HttpGet]
    public IActionResult HorariosDisponiveis(string data)
    {
        if (!DateTime.TryParse(data, out DateTime dataSelecionada))
        {
            return BadRequest("Data inválida");
        }

        string cpfBarbeiro = "12345678901";

        var horariosDisponiveis = _context.Horario_Disponivel
            .Where(h => h.CPF_barbeiro == cpfBarbeiro && h.data == dataSelecionada && h.ocupado == false)
            .Select(h => h.hora)
            .ToList();

        return PartialView("_HorariosDisponiveis", horariosDisponiveis);
    }
}

