using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System_WebAPI.Models;

namespace System_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options) { }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<ItemCardapio> ItemPedido { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>()
            .HasData(new List<Produto>(){
                new Produto(1, "Batata", 10, "Kg"),
                new Produto(2, "Alface", 9, "Kg"),
                new Produto(3, "Cenoura", 8, "Kg"),
                new Produto(4, "Tomate", 17, "Kg"),
                new Produto(5, "Pepino", 10, "Kg"),
                new Produto(6, "Feijão", 11, "Kg"),
                new Produto(7, "ProdutoA", 11, "Und"),
                new Produto(8, "ProdutoB", 13, "Und"),
                new Produto(9, "ProdutoC", 11, "Und"),
                new Produto(10, "ProdutoD", 41, "Und"),
                new Produto(11, "Agua c/gás", 61, "Litros"),                
                new Produto(12, "Agua Mineral", 16, "Litros"),                
                new Produto(13, "Agua s/gás", 13, "Litros"),                
                new Produto(14, "Agua Desmineralizada", 14, "Litros")                
            });

            builder.Entity<ItemCardapio>()
            .HasData(new List<ItemCardapio>(){
                new ItemCardapio(1, "Batata Frita c/ cheddar", "Belíssima batata artesanal", 30,"Burgers"),
                new ItemCardapio(2, "Batata Frita", "Belíssima batata artesanal", 25,"Burgers"),
                new ItemCardapio(3, "Batata Frita c/ Bacon", "Belíssima batata artesanal", 33,"Burgers"),
                new ItemCardapio(4, "Chicken Bacon", "Hamburguer 200g, artesanal", 50,"Burgers"),
                new ItemCardapio(5, "Tideco", "Hamburguer 200g, artesanal", 10,"Burgers"),
                new ItemCardapio(6, "Queijones", "Hamburguer 200g c/ queijo, artesanal", 14,"Burgers"),
                new ItemCardapio(7, "ItemCardapioA", "Pizza show de bola", 10, "Pizzas"),
                new ItemCardapio(8, "ItemCardapioB", "Pizza de bacon", 20, "Pizzas"),
                new ItemCardapio(9, "ItemCardapioC", "Pizza de calabresa", 20, "Pizzas"),
                new ItemCardapio(10, "ItemCardapioD", "frango", 20, "Pizzas"),
                new ItemCardapio(11, "Agua c/gás", "", 3, "Bebidas"),                
                new ItemCardapio(12, "Agua Mineral", "", 5, "Bebidas"),                
                new ItemCardapio(13, "Agua s/gás", "", 2, "Bebidas"),                
                new ItemCardapio(14, "Agua Desmineralizada", "", 6, "Bebidas")                
            });
        }
        
    }
}