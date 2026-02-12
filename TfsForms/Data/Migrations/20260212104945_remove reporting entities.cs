using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TfsForms.Data.Migrations
{
    /// <inheritdoc />
    public partial class removereportingentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropIndex(
            //    name: "IX_Responses_QuestionId_DesigneeId_ReportingEntityId",
            //    table: "Responses");

            migrationBuilder.DropColumn(
                name: "ReportingEntityId",
                table: "Responses");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_QuestionId",
                table: "Responses",
                column: "QuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Responses_QuestionId",
                table: "Responses");

            migrationBuilder.AddColumn<int>(
                name: "ReportingEntityId",
                table: "Responses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Responses_QuestionId_DesigneeId_ReportingEntityId",
                table: "Responses",
                columns: new[] { "QuestionId", "DesigneeId", "ReportingEntityId" },
                unique: true);
        }
    }
}
