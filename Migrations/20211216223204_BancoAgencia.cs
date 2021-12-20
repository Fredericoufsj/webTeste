using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webTeste.Migrations
{
    public partial class BancoAgencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "contatos",
                columns: table => new
                {
                    Id_Contato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contatos", x => x.Id_Contato);
                });

            migrationBuilder.CreateTable(
                name: "voos",
                columns: table => new
                {
                    Id_Voo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Partida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_Retorno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_cliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voos", x => x.Id_Voo);
                    table.ForeignKey(
                        name: "FK_voos_clientes_Id_cliente",
                        column: x => x.Id_cliente,
                        principalTable: "clientes",
                        principalColumn: "Id_cliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_voos_Id_cliente",
                table: "voos",
                column: "Id_cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contatos");

            migrationBuilder.DropTable(
                name: "voos");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
