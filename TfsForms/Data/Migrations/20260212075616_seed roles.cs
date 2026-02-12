using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TfsForms.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "159827e7-1887-4f58-905a-7a3e36ac6417", "159827e7-1887-4f58-905a-7a3e36ac6417", "RapidAML", "RAPIDAML" },
                    { "15b96b65-8560-4a3d-92b0-6f70967a3780", "15b96b65-8560-4a3d-92b0-6f70967a3780", "CRIMS", "CRIMS" },
                    { "8d6a86e9-9658-4cf7-9e4b-031c13f6eaab", "8d6a86e9-9658-4cf7-9e4b-031c13f6eaab", "TFS", "TFS" },
                    { "91c5db14-2747-4ffc-887d-8dc05789b1fb", "91c5db14-2747-4ffc-887d-8dc05789b1fb", "GoAML", "GOAML" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159827e7-1887-4f58-905a-7a3e36ac6417");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15b96b65-8560-4a3d-92b0-6f70967a3780");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d6a86e9-9658-4cf7-9e4b-031c13f6eaab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91c5db14-2747-4ffc-887d-8dc05789b1fb");
        }
    }
}
