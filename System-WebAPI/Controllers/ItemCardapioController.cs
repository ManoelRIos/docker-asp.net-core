using Microsoft.AspNetCore.Mvc;
using System_WebAPI.Data;
using System_WebAPI.Models;

namespace System_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ItemCardapioController : ControllerBase
    {
        private readonly IRepository _repo;
        public ItemCardapioController(IRepository repo)
        {
            _repo = repo;
                        
        }
        [HttpGet]
        public async Task<IActionResult> Get()            
        {            
            try
            {
                var result = await _repo.GetAllItemCardapioAsync();
                return Ok(result);                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }    
        }

        [HttpGet("categoria/{itemCardapioCat}")]
         public async Task<IActionResult> GetByCat(string itemCardapioCat)            
        {            
            try
            {
                var result = await _repo.GetAllItemCardapioByCat(itemCardapioCat);
                return Ok(result);                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }    
        }
        [HttpGet("{itemCardapioId}")]
        public async Task<IActionResult> GetById(int itemCardapioId)
        {
            try
            {
                var result = await _repo.GetItemCardapioById(itemCardapioId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                
                return BadRequest($"Erro: {ex.Message}");
            }
        }
        
    }
}