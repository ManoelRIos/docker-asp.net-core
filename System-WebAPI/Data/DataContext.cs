using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System_WebAPI.Models;

namespace System_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options) { }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }

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

            builder.Entity<ItemPedido>()
            .HasData(new List<ItemPedido>(){
                new ItemPedido(1, "Batata Frita c/ cheddar", "Belíssima batata artesanal", 30.00,"Burgers"),
                new ItemPedido(2, "Batata Frita", "Belíssima batata artesanal", 25.00,"Burgers"),
                new ItemPedido(3, "Batata Frita c/ Bacon", "Belíssima batata artesanal", 33,"Burgers"),
                new ItemPedido(4, "Chicken Bacon", "Hamburguer 200g, artesanal", 50,"Burgers"),
                new ItemPedido(5, "Tideco", "Hamburguer 200g, artesanal", 10,"Burgers"),
                new ItemPedido(6, "Queijones", "Hamburguer 200g c/ queijo, artesanal", 14,"Burgers"),
                new ItemPedido(7, "ItemPedidoA", "Pizza show de bola", 10, "Pizzas"),
                new ItemPedido(8, "ItemPedidoB", "Pizza de bacon", 20, "Pizzas"),
                new ItemPedido(9, "ItemPedidoC", "Pizza de calabresa", 20, "Pizzas"),
                new ItemPedido(10, "ItemPedidoD", "frango", 20, "Pizzas"),
                new ItemPedido(11, "Agua c/gás", "", 3, "Bebidas"),                
                new ItemPedido(12, "Agua Mineral", "", 5, "Bebidas"),                
                new ItemPedido(13, "Agua s/gás", "", 2, "Bebidas"),                
                new ItemPedido(14, "Agua Desmineralizada", "", 6, "Bebidas")                
            });
        }
        
    }
}