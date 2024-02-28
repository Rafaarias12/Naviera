using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Naviera.API.Migrations
{
    /// <inheritdoc />
    public partial class ConfiguracionContenedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contenedores_Contenidos_ContenidoId",
                table: "Contenedores");

            migrationBuilder.DropIndex(
                name: "IX_Contenedores_ContenidoId",
                table: "Contenedores");

            migrationBuilder.DropColumn(
                name: "ContenidoId",
                table: "Contenedores");

            migrationBuilder.AddColumn<int>(
                name: "ContenedorId",
                table: "Contenidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contenidos_ContenedorId",
                table: "Contenidos",
                column: "ContenedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contenidos_Contenedores_ContenedorId",
                table: "Contenidos",
                column: "ContenedorId",
                principalTable: "Contenedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contenidos_Contenedores_ContenedorId",
                table: "Contenidos");

            migrationBuilder.DropIndex(
                name: "IX_Contenidos_ContenedorId",
                table: "Contenidos");

            migrationBuilder.DropColumn(
                name: "ContenedorId",
                table: "Contenidos");

            migrationBuilder.AddColumn<int>(
                name: "ContenidoId",
                table: "Contenedores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contenedores_ContenidoId",
                table: "Contenedores",
                column: "ContenidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contenedores_Contenidos_ContenidoId",
                table: "Contenedores",
                column: "ContenidoId",
                principalTable: "Contenidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
