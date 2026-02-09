using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TfsForms.Data.Migrations
{
    /// <inheritdoc />
    public partial class addlookuptables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CRIMSReportingEntityId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GoAMLReportingEntityId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RapidAMLReportingEntityId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "lkCRIMSLEAs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CRIMSId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LEA = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lkCRIMSLEAs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lkGoAMLREs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoAMLId = table.Column<int>(type: "int", nullable: false),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lkGoAMLREs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lkRapidAMLREs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RapidAMLId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lkRapidAMLREs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lkCRIMSLEAs");

            migrationBuilder.DropTable(
                name: "lkGoAMLREs");

            migrationBuilder.DropTable(
                name: "lkRapidAMLREs");

            migrationBuilder.DropColumn(
                name: "CRIMSReportingEntityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GoAMLReportingEntityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RapidAMLReportingEntityId",
                table: "AspNetUsers");
        }
    }
}
