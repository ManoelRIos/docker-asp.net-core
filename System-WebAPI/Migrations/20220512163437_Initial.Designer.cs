﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System_WebAPI.Data;

#nullable disable

namespace System_WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220512163437_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("System_WebAPI.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("qtd")
                        .HasColumnType("INTEGER");

                    b.Property<string>("undMed")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            id = 1,
                            name = "Batata",
                            qtd = 1,
                            undMed = "Kg"
                        },
                        new
                        {
                            id = 2,
                            name = "Alface",
                            qtd = 1,
                            undMed = "Kg"
                        },
                        new
                        {
                            id = 3,
                            name = "Cenoura",
                            qtd = 1,
                            undMed = "Kg"
                        },
                        new
                        {
                            id = 4,
                            name = "Tomate",
                            qtd = 1,
                            undMed = "Kg"
                        },
                        new
                        {
                            id = 5,
                            name = "Pepino",
                            qtd = 1,
                            undMed = "Kg"
                        },
                        new
                        {
                            id = 6,
                            name = "Feijão",
                            qtd = 1,
                            undMed = "Kg"
                        },
                        new
                        {
                            id = 7,
                            name = "ProdutoA",
                            qtd = 1,
                            undMed = "Und"
                        },
                        new
                        {
                            id = 8,
                            name = "ProdutoB",
                            qtd = 1,
                            undMed = "Und"
                        },
                        new
                        {
                            id = 9,
                            name = "ProdutoC",
                            qtd = 1,
                            undMed = "Und"
                        },
                        new
                        {
                            id = 10,
                            name = "ProdutoD",
                            qtd = 1,
                            undMed = "Und"
                        },
                        new
                        {
                            id = 11,
                            name = "Agua c/gás",
                            qtd = 1,
                            undMed = "Litros"
                        },
                        new
                        {
                            id = 12,
                            name = "Agua Mineral",
                            qtd = 1,
                            undMed = "Litros"
                        },
                        new
                        {
                            id = 13,
                            name = "Agua s/gás",
                            qtd = 1,
                            undMed = "Litros"
                        },
                        new
                        {
                            id = 14,
                            name = "Agua Desmineralizada",
                            qtd = 1,
                            undMed = "Litros"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
