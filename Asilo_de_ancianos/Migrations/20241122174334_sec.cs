using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asilo_de_ancianos.Migrations
{
    /// <inheritdoc />
    public partial class sec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "CollecionUsuarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollecionUsuarios",
                table: "CollecionUsuarios",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CollecionUsuarios",
                table: "CollecionUsuarios");

            migrationBuilder.RenameTable(
                name: "CollecionUsuarios",
                newName: "Usuarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");
        }
    }
}
