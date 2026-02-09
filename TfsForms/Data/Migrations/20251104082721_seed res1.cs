using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TfsForms.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedres1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblTempRE",
                table: "tblTempRE");

            migrationBuilder.RenameTable(
                name: "tblTempRE",
                newName: "tblTempREs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblTempREs",
                table: "tblTempREs",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblTempREs",
                table: "tblTempREs");

            migrationBuilder.RenameTable(
                name: "tblTempREs",
                newName: "tblTempRE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblTempRE",
                table: "tblTempRE",
                column: "Id");
        }
    }
}
