using livraria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace livraria.Controllers
{
  public class LivrariaController :Controller
  {
    private readonly AppDbContext _context;

    public LivrariaController(AppDbContext context)
    {
      _context = context;
    }

    //Listagem dos livros
    [HttpGet]
    public IActionResult Index()
    {
      var books = _context.Livros.ToList();
      return View(books);
      
    }

    //Cria os livros
    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Livro livro)

    {
      if (ModelState.IsValid)
      {
        try
        {
          _context.Livros.Add(livro);
          await _context.SaveChangesAsync();
          return RedirectToAction("Index");
        }
        catch(Exception ex)
        {
          ModelState.AddModelError(string.Empty, $"Algo deu errado {ex.Message}");
        }
      }
      ModelState.AddModelError(string.Empty, $"Algo deu errado, modelo inválido");
      return View(livro);
    }

    //Mostrar detalhe de livro específico
    [HttpGet]
    public async Task<IActionResult> Details(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var movie = await _context.Livros.FirstOrDefaultAsync(b => b.Id == id);

      if (movie == null)
      {
        return NotFound();
      }
      return View(movie);
    }

    //Editar Livro
    public async Task<IActionResult> Edit(int? id)
    {
      if(id == null)
      {
        return NotFound();
      }

      var movie = await _context.Livros.FirstOrDefaultAsync(b => b.Id == id);
      if(movie == null)
      {
        return NotFound();
      }
      return View();
    }


  }

}