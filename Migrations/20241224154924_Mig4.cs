using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_LibManagmentProject.Migrations
{
    /// <inheritdoc />
    public partial class Mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "Admins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_ManagerId",
                table: "Admins",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Admins_ManagerId",
                table: "Admins",
                column: "ManagerId",
                principalTable: "Admins",
                principalColumn: "AdminId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Admins_ManagerId",
                table: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Admins_ManagerId",
                table: "Admins");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
