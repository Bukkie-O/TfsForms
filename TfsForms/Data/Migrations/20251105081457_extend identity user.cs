using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TfsForms.Data.Migrations
{
    /// <inheritdoc />
    public partial class extendidentityuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TempREId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TempREId",
                table: "AspNetUsers",
                column: "TempREId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_tblTempREs_TempREId",
                table: "AspNetUsers",
                column: "TempREId",
                principalTable: "tblTempREs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_tblTempREs_TempREId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TempREId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TempREId",
                table: "AspNetUsers");
        }
    }
}
