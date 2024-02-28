using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Naviera.API.Migrations
{
    /// <inheritdoc />
    public partial class MigracionTicket3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ContenidoId",
                table: "Tickets",
                column: "ContenidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Contenidos_ContenidoId",
                table: "Tickets",
                column: "ContenidoId",
                principalTable: "Contenidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Contenidos_ContenidoId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ContenidoId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ContenidoId",
                table: "Tickets");

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
    }
}
