using Hairday.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hairday.Controllers
{
    public class BarbeariaController : Controller
    {
        public readonly AppDbContext _context;

        public BarbeariaController(AppDbContext context) 
        {
            _context = context;
        }

        public ActionResult Index() 
        {
            return View();
        }


        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Barbearia barbearia) 
        {
            if (barbearia == null) 
            {
                return NotFound();
            }

             bool jaExistEmail = _context.Barbearias
               .Any(b => b.email == barbearia.email);

            if (jaExistEmail) 
            {
                return NotFound();
            }

            _context.Barbearias.Add(barbearia);
            _context.SaveChanges();

            return RedirectToAction("Login", "Account" );
        }

    }
}
