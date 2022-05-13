using Microsoft.AspNetCore.Mvc;
using System_WebAPI.Data;

namespace System_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProdutoController : ControllerBase
    {
        private readonly IRepository _repo;
        public ProdutoController(IRepository repo)
        {
            _repo = repo;
                        
        }
        [HttpGet]
        public async Task<IActionResult> Get()            
        {            
            try
            {
                var result = await _repo.GetAllProdutoAsync();
                return Ok(result);                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }    
        }
            [HttpGet("{ProdutoId}")]
        public async Task<IActionResult> GetProdutoAsyncById(int produtoId)            
        {            
            try
            {
                var result = await _repo.GetProdutoAsyncById(produtoId);
                return Ok(result);                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }    
        }

    }
}