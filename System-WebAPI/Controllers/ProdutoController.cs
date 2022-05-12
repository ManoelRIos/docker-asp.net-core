using Microsoft.AspNetCore.Mvc;

namespace System_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProdutoController : ControllerBase
    {
        
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