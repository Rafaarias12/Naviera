using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Naviera.API.Migrations
{
    /// <inheritdoc />
    public partial class ErrorIdEF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contactos_Empresa_EmpresaIdEmpresa",
                table: "Contactos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Empresa_EmpresaIdEmpresa",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "EmpresaIdEmpresa",
                table: "Tickets",
                newName: "EmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_EmpresaIdEmpresa",
                table: "Tickets",
                newName: "IX_Tickets_EmpresaId");

            migrationBuilder.RenameColumn(
                name: "EmpresaIdEmpresa",
                table: "Contactos",
                newName: "EmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_Contactos_EmpresaIdEmpresa",
                table: "Contactos",
                newName: "IX_Contactos_EmpresaId");

            migrationBuilder.AddColumn<int>(
                name: "ContenedorId",
                table: "Areas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Contactos_Empresa_EmpresaId",
                table: "Contactos",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Empresa_EmpresaId",
                table: "Tickets",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contactos_Empresa_EmpresaId",
                table: "Contactos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Empresa_EmpresaId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ContenedorId",
                table: "Areas");

            migrationBuilder.RenameColumn(
                name: "EmpresaId",
                table: "Tickets",
                newName: "EmpresaIdEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_EmpresaId",
                table: "Tickets",
                newName: "IX_Tickets_EmpresaIdEmpresa");

            migrationBuilder.RenameColumn(
                name: "EmpresaId",
                table: "Contactos",
                newName: "EmpresaIdEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_Contactos_EmpresaId",
                table: "Contactos",
                newName: "IX_Contactos_EmpresaIdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_Contactos_Empresa_EmpresaIdEmpresa",
                table: "Contactos",
                column: "EmpresaIdEmpresa",
                principalTable: "Empresa",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Empresa_EmpresaIdEmpresa",
                table: "Tickets",
                column: "EmpresaIdEmpresa",
                principalTable: "Empresa",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
