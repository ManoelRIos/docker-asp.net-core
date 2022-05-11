using livraria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace livraria.Controllers
{
  public class MoviesController : Controller 
  {
    private readonly AppDbContext _context;


     [HttpGet]
    public  IActionResult Index()
    {
      return View(_context.Movie.ToList());
    }

    [HttpPost]
    public async Task<IActionResult> Create(Movie movie)
    {
      if(ModelState.IsValid)
      {
        try
        {
          _context.Movie.Add(movie);
          await _context.SaveChangesAsync();
          return RedirectToAction("Index");
        }
        catch(Exception ex)
        {
          ModelState.AddModelError(string.Empty, $"Algo deu errado {ex.Message}");          
        }
      }
      ModelState.AddModelError(string.Empty, $"Algo deu errado, modelo inválido");
      return View(movie);
    }

    [HttpGet]
    public async Task<IActionResult> Details(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

      if (movie == null)
      {

        return NotFound();
      }
      return View(movie);

    }

   
  }



}
