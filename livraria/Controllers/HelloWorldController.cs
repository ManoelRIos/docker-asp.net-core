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

  }
}
