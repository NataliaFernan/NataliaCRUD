using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NataliaCRUD.Data.Migrations
{
    public partial class chocolates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chocolates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Marca = table.Column<string>(nullable: false),
                    Sabor = table.Column<string>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    LinkImagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chocolates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chocolates");
        }
    }
}
