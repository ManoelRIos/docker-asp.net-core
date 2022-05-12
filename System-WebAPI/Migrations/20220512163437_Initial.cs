using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace System_WebAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    qtd = table.Column<int>(type: "INTEGER", nullable: false),
                    undMed = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 1, "Batata", 1, "Kg" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 2, "Alface", 1, "Kg" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 3, "Cenoura", 1, "Kg" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 4, "Tomate", 1, "Kg" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 5, "Pepino", 1, "Kg" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 6, "Feijão", 1, "Kg" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 7, "ProdutoA", 1, "Und" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 8, "ProdutoB", 1, "Und" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 9, "ProdutoC", 1, "Und" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 10, "ProdutoD", 1, "Und" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 11, "Agua c/gás", 1, "Litros" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 12, "Agua Mineral", 1, "Litros" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 13, "Agua s/gás", 1, "Litros" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "id", "name", "qtd", "undMed" },
                values: new object[] { 14, "Agua Desmineralizada", 1, "Litros" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
