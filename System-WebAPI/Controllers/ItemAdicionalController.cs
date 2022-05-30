using Microsoft.AspNetCore.Mvc;
using System_WebAPI.Data;

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

        public void Post()
        {

        }
    }
}