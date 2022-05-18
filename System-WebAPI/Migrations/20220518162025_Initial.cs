using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace System_WebAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemCardapio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Desc = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<float>(type: "REAL", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCardapio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Qtd = table.Column<int>(type: "INTEGER", nullable: false),
                    UndMed = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 1, "Burgers", "Belíssima batata artesanal", "Batata Frita c/ cheddar", 30f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 2, "Burgers", "Belíssima batata artesanal", "Batata Frita", 25f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 3, "Burgers", "Belíssima batata artesanal", "Batata Frita c/ Bacon", 33f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 4, "Burgers", "Hamburguer 200g, artesanal", "Chicken Bacon", 50f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 5, "Burgers", "Hamburguer 200g, artesanal", "Tideco", 10f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 6, "Burgers", "Hamburguer 200g c/ queijo, artesanal", "Queijones", 14f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 7, "Pizzas", "Pizza show de bola", "ItemCardapioA", 10f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 8, "Pizzas", "Pizza de bacon", "ItemCardapioB", 20f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 9, "Pizzas", "Pizza de calabresa", "ItemCardapioC", 20f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 10, "Pizzas", "frango", "ItemCardapioD", 20f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 11, "Bebidas", "", "Agua c/gás", 3f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 12, "Bebidas", "", "Agua Mineral", 5f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 13, "Bebidas", "", "Agua s/gás", 2f });

            migrationBuilder.InsertData(
                table: "ItemCardapio",
                columns: new[] { "Id", "Category", "Desc", "Name", "Price" },
                values: new object[] { 14, "Bebidas", "", "Agua Desmineralizada", 6f });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 1, "Batata", 10, "Kg" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 2, "Alface", 9, "Kg" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 3, "Cenoura", 8, "Kg" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 4, "Tomate", 17, "Kg" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 5, "Pepino", 10, "Kg" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 6, "Feijão", 11, "Kg" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 7, "ProdutoA", 11, "Und" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 8, "ProdutoB", 13, "Und" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 9, "ProdutoC", 11, "Und" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 10, "ProdutoD", 41, "Und" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 11, "Agua c/gás", 61, "Litros" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 12, "Agua Mineral", 16, "Litros" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 13, "Agua s/gás", 13, "Litros" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Name", "Qtd", "UndMed" },
                values: new object[] { 14, "Agua Desmineralizada", 14, "Litros" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemCardapio");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
