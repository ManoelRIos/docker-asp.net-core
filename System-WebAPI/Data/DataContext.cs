using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System_WebAPI.Models;

namespace System_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options) { }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>()
            .HasData(new List<Produto>(){
                new Produto(1, "Batata", 1, "Kg"),
                new Produto(2, "Alface", 1, "Kg"),
                new Produto(3, "Cenoura", 1, "Kg"),
                new Produto(4, "Tomate", 1, "Kg"),
                new Produto(5, "Pepino", 1, "Kg"),
                new Produto(6, "Feijão", 1, "Kg"),
                new Produto(7, "ProdutoA", 1, "Und"),
                new Produto(8, "ProdutoB", 1, "Und"),
                new Produto(9, "ProdutoC", 1, "Und"),
                new Produto(10, "ProdutoD", 1, "Und"),
                new Produto(11, "Agua c/gás", 1, "Litros"),                
                new Produto(12, "Agua Mineral", 1, "Litros"),                
                new Produto(13, "Agua s/gás", 1, "Litros"),                
                new Produto(14, "Agua Desmineralizada", 1, "Litros")                
            });
        }
        
    }
}