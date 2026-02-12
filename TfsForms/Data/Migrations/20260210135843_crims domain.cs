using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TfsForms.Data.Migrations
{
    /// <inheritdoc />
    public partial class crimsdomain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CRIMSId",
                table: "lkCRIMSLEAs",
                newName: "CRIMSDomain");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CRIMSDomain",
                table: "lkCRIMSLEAs",
                newName: "CRIMSId");
        }
    }
}
