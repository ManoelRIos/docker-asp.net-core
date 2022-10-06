using Microsoft.AspNetCore.Mvc;
using System_WebAPI.Data;
using System_WebAPI.Models;

namespace System_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemPedidoController : ControllerBase
    {
        private readonly IRepository _repo;
        public ItemPedidoController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllItemPedidoAsync();
                return Ok(result);
                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }
        [HttpGet("{itemPedidoId}")]
        public async Task<IActionResult> GetItemPediddoById(int itemPedidoId)
        {
            try
            {
                var result = await _repo.GetItemPedidoById(itemPedidoId);    
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post(ItemPedido model)
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

        
    }
}