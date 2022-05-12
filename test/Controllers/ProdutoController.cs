using Microsoft.AspNetCore.Mvc;

namespace Livraria_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Manoel");
        }
    }
}