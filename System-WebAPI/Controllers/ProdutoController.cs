using Microsoft.AspNetCore.Mvc;
using System_WebAPI.Data;
using System_WebAPI.Models;

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
        [HttpGet("{produtoId}")]
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
        [HttpPost]
        public async Task<IActionResult> Post(Produto model)            
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
        [HttpPut("{produtoId}")]
        public async Task<IActionResult> Put(int produtoId, Produto model)            
        {            
            try
            {
                var produto = await _repo.GetProdutoAsyncById(produtoId);
                if (produto == null) return NotFound();

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
        [HttpDelete("{produtoId}")]
        public async Task<IActionResult> Delete(int produtoId)            
        {            
            try
            {
                var produto = await _repo.GetProdutoAsyncById(produtoId);
                if (produto == null) return NotFound();

                _repo.Delete(produto);
                if(await _repo.SaveChangesAsync())
                {
                    return Ok("Deletado com sucesso");                
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