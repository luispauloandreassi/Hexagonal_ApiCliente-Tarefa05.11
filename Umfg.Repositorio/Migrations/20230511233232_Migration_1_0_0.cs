using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Umfg.Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class Migration_1_0_0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false),
                    DOCUMENTO = table.Column<string>(type: "longtext", nullable: false),
                    NOME = table.Column<string>(type: "longtext", nullable: false),
                    ENDERECO = table.Column<string>(type: "longtext", nullable: false),
                    CELULAR = table.Column<string>(type: "longtext", nullable: false),
                    EMAIL = table.Column<string>(type: "longtext", nullable: false),
                    OBSERVACAO = table.Column<string>(type: "longtext", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
