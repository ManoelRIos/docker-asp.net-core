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
        }
        
    }
}