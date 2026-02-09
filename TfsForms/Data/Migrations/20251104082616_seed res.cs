using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TfsForms.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblTempRE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTempRE", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "tblTempRE",
                columns: new[] { "Id", "REName" },
                values: new object[,]
                {
                    { 1, "Access Bank" },
                    { 2, "GT Bank" },
                    { 3, "Standard Chartered Bank" },
                    { 4, "Zenith Bank" },
                    { 5, "Opay Digital Services" },
                    { 6, "Palmpay Limited" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblTempRE");
        }
    }
}
