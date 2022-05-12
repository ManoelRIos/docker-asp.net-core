using Microsoft.AspNetCore.Mvc;
using System_WebAPI.Data;

namespace System_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProdutoController : ControllerBase
    {
        public ProdutoController(IRepository repo)
        {
                        
        }
        [HttpGet]
        public IActionResult get()            
        {
            
            try
            {
                return Ok("produto");                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            
        }

    }
}