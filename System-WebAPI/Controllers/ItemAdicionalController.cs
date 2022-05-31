using Microsoft.AspNetCore.Mvc;
using System_WebAPI.Data;
using System_WebAPI.Models;

namespace System_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemAdicionalController : ControllerBase
    {
        private readonly IRepository _repo;

        public ItemAdicionalController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllItemAdicionalAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            
        }

        [HttpGet("{itemAdicionalId}")]
        public async Task<ActionResult> GetById(int itemAdcionalId)

        {
            try
            {
                var result = await _repo.GetItemAdicionalById(itemAdcionalId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(ItemAdicional model)
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
        public async Task<ActionResult> Put(int itemAdicionalId, ItemAdicional model)
        {
            try
            {
                var itemAdicional = await _repo.GetItemAdicionalById(itemAdicionalId);
                if(itemAdicional == null) return NotFound();
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

        [HttpDelete("{itemAdicionalId")]
        public async Task<IActionResult> Delete(int itemAdicionalId)
        {
            try
            {
                var itemAdicional = await _repo.GetItemAdicionalById(itemAdicionalId);
                if(itemAdicional == null) return NotFound();
                _repo.Delete(itemAdicional);
            }
            catch (Exception ex)
            {
                 return BadRequest($"Erro: {ex.Message}");
            }
            return BadRequest();
        }
    }
}