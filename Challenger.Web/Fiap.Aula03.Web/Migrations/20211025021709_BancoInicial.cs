using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiap.Aula03.Web.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Pc_preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Corredor = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Qt_quantidade = table.Column<int>(type: "int", nullable: false),
                    Dt_validade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Produto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Produto");
        }
    }
}
