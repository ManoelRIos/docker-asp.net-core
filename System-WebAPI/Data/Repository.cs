using Microsoft.EntityFrameworkCore;
using System_WebAPI.Models;

namespace System_WebAPI.Data
{
  public class Repository : IRepository
  {
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public void Add<T>(T entity) where T : class
    {
      _context.Add(entity);
    }
    public void Delete<T>(T entity) where T : class
    {
      _context.Remove(entity);
    }
    public void Update<T>(T entity) where T : class
    {
       _context.Update(entity);
    }
    public async Task<bool> SaveChangesAsync()
    {
      return (await _context.SaveChangesAsync()) > 0;
    }

    //Produto
    public async Task<Produto[]> GetAllProdutoAsync()
    {
        IQueryable<Produto> query = _context.Produto;

        query = query.AsNoTracking().OrderBy(c => c.Id);

        return await query.ToArrayAsync();
    }
    public async Task<Produto> GetProdutoAsyncById(int produtoId)
    {
        IQueryable<Produto> query = _context.Produto;

        query = query.AsNoTracking().OrderBy(produto => produto.Id).Where(produto => produto.Id == produtoId);
        return await query.FirstOrDefaultAsync();
    }


    //ItemCardapio
    public async Task<ItemCardapio[]> GetAllItemCardapioAsync()
    {
      IQueryable<ItemCardapio> query = _context.ItemCardapio;

      query = query.AsNoTracking().OrderBy(c => c.Id);
      return await query.ToArrayAsync();
    }

    public async Task<ItemCardapio[]> GetAllItemCardapioByCat(string itemCardapioCat)
    {
      IQueryable<ItemCardapio> query = _context.ItemCardapio;
      query = query.AsNoTracking().OrderBy(c => c.Id).Where(c => c.Category == itemCardapioCat);
      return await query.ToArrayAsync();
    }

    public async Task<ItemCardapio> GetItemCardapioById(int itemCardapioId)
    {
      IQueryable<ItemCardapio> query = _context.ItemCardapio;
      query = query.AsNoTracking().Where(c => c.Id == itemCardapioId);
      return await query.FirstOrDefaultAsync();
    }

    //ItemAdicional
    public async Task<ItemAdicional[]> GetAllItemAdicionalAsync()
    {
      IQueryable<ItemAdicional> query = _context.ItemAdicional;
      query = query.AsNoTracking().OrderBy(c => c.Id);
      return await query.ToArrayAsync();
    }

    public async Task<ItemAdicional> GetItemAdicionalById(int itemAdicionalId)
    {
      IQueryable<ItemAdicional> query = _context.ItemAdicional;
      query = query.AsNoTracking().Where(c => c.Id == itemAdicionalId);
      return await query.FirstOrDefaultAsync();
    }

    //ItemPedido
    public async Task<ItemPedido[]> GetAllItemPedidoAsync()
    {
      IQueryable<ItemPedido> query = _context.ItemPedido;
      query = query.AsNoTracking().OrderBy(c => c.Id);
      return await query.ToArrayAsync();
    }

    public async Task<ItemPedido> GetItemPedidoById(int itemAdicionalId)
    {
      IQueryable<ItemPedido> query = _context.ItemPedido;
      query = query.AsNoTracking().Where(c => c.Id == itemAdicionalId);
      return await query.FirstOrDefaultAsync();
    }
  }
}