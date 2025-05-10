using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hairday.Controllers;
using System.Threading.Tasks;
using System.Linq;

public class ClienteController : Controller
{
    private readonly AppDbContext _context;

    public ClienteController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Cliente
    public async Task<IActionResult> Index()
    {
        return View(await _context.Clientes.ToListAsync());
    }

    // GET: Cliente/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
            return NotFound();

        var cliente = await _context.Clientes
            .FirstOrDefaultAsync(m => m.id_cliente == id);

        if (cliente == null)
            return NotFound();

        return View(cliente);
    }

    // GET: Cliente/Create
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("id_cliente,nome,email,senha,cidade,telefone")] Cliente cliente)
    {
        // Verifica se o email já existe no banco
        if (await _context.Clientes.AnyAsync(c => c.email == cliente.email))
        {
            TempData["Erro"] = "Email já cadastrado!";
            return View(cliente);
        }

        if (ModelState.IsValid)
        {
            _context.Add(cliente);
            await _context.SaveChangesAsync();

            TempData["Mensagem"] = "Cadastro realizado com sucesso!";
            return RedirectToAction(nameof(Index)); // ou Create se preferir manter na mesma tela
        }

        return View(cliente);
    }

    // GET: Cliente/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
            return NotFound();

        var cliente = await _context.Clientes.FindAsync(id);
        if (cliente == null)
            return NotFound();

        return View(cliente);
    }

    // POST: Cliente/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("id_cliente,nome,email,senha,cidade,telefone")] Cliente cliente)
    {
        if (id != cliente.id_cliente)
            return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(cliente);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(cliente.id_cliente))
                    return NotFound();
                else
                    throw;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(cliente);
    }

    // GET: Cliente/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
            return NotFound();

        var cliente = await _context.Clientes
            .FirstOrDefaultAsync(m => m.id_cliente == id);
        if (cliente == null)
            return NotFound();

        return View(cliente);
    }

    // POST: Cliente/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        _context.Clientes.Remove(cliente);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ClienteExists(int id)
    {
        return _context.Clientes.Any(e => e.id_cliente == id);
    }
}
