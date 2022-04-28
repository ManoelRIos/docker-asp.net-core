using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using livraria.Models;



namespace livraria.Controllers
{
  public class HelloWorldController : Controller
  {
    private readonly AppDbContext _context;

    public IActionResult Welcome(string name, int numTimes = 1)
    {
      ViewData["Message"] = "Hello " + name;
      ViewData["NumTimes"] = numTimes;
      return View();
    }

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
