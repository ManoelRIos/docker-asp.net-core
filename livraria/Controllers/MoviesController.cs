using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using livraria.Models;



namespace livraria.Controllers
{
  public class MoviesController : Controller
  {
    private readonly AppDbContext _context;


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

    [HttpGet]
    public async Task<IActionResult> Index()
    {
      return View(await _context.Movie.ToListAsync());
    }
  }



}
