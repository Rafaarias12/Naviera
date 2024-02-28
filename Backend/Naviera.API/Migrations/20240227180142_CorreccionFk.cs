using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Naviera.API.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionFk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contenedores_Contenedores_ContenedorId",
                table: "Contenedores");

            migrationBuilder.DropIndex(
                name: "IX_Contenedores_ContenedorId",
                table: "Contenedores");

            migrationBuilder.DropColumn(
                name: "IdBarco",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "IdContenedor",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "IdTipoContenido",
                table: "Contenidos");

            migrationBuilder.DropColumn(
                name: "IdTipoUnidad",
                table: "Contenidos");

            migrationBuilder.DropColumn(
                name: "ContenedorId",
                table: "Contenedores");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Contactos");

            migrationBuilder.RenameColumn(
                name: "IdArea",
                table: "Contenedores",
                newName: "ContenidoId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contenedores_Contenidos_ContenidoId",
                table: "Contenedores");

            migrationBuilder.DropIndex(
                name: "IX_Contenedores_ContenidoId",
                table: "Contenedores");

            migrationBuilder.RenameColumn(
                name: "ContenidoId",
                table: "Contenedores",
                newName: "IdArea");

            migrationBuilder.AddColumn<int>(
                name: "IdBarco",
                table: "Viajes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdContenedor",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoContenido",
                table: "Contenidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoUnidad",
                table: "Contenidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContenedorId",
                table: "Contenedores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Contactos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contenedores_ContenedorId",
                table: "Contenedores",
                column: "ContenedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contenedores_Contenedores_ContenedorId",
                table: "Contenedores",
                column: "ContenedorId",
                principalTable: "Contenedores",
                principalColumn: "Id");
        }
    }
}
