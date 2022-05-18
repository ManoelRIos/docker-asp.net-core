using System_WebAPI.Models;

namespace System_WebAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Produto
        Task<Produto[]> GetAllProdutoAsync();
        Task<Produto> GetProdutoAsyncById(int produtoId);      

        //ItemCardapio
        Task<ItemCardapio[]> GetAllItemCardapioAsync();
        Task<ItemCardapio[]> GetAllItemCardapioByCat(string itemCardapioCat);
        Task<ItemCardapio> GetItemCardapioById(int itemCardapioId);
    }
}