using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TfsForms.Data.Migrations
{
    /// <inheritdoc />
    public partial class addcreatedby : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Responses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CreatedById",
                table: "Responses",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_AspNetUsers_CreatedById",
                table: "Responses",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_AspNetUsers_CreatedById",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_Responses_CreatedById",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Responses");
        }
    }
}
