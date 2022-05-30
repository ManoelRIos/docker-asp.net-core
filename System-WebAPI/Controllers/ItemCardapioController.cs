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
        
        [HttpPost]
        public async Task<IActionResult> Post(ItemCardapio model)
        {
            try
            {
                _repo.Add(model);
                if(await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                 return BadRequest($"Erro: {ex.Message}");
            }
            return BadRequest();

        }
        
        [HttpPut("{itemCardapioId}")]
        public async Task<IActionResult> Put(int itemCardapioId, ItemCardapio model)
        {
            try
            {
                var itemCardapio = await _repo.GetItemCardapioById(itemCardapioId);
                if(itemCardapio == null) return NotFound();
                _repo.Update(model);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            return BadRequest();

        }

        [HttpDelete("{itemCardapioId}")]
        public async Task<IActionResult> Delete(int itemCardapioId)
        {
            try
            {
                var itemCardapio = await _repo.GetItemCardapioById(itemCardapioId);
                if(itemCardapio == null) return NotFound();
                _repo.Delete(itemCardapio);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok("Deletado com sucesso");
                }
                return BadRequest();

            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");                
            }

        }    
    }
}