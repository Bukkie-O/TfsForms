using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TfsForms.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueIndex_ResponseTriplet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Responses_QuestionId",
                table: "Responses");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_QuestionId_DesigneeId_ReportingEntityId",
                table: "Responses",
                columns: new[] { "QuestionId", "DesigneeId", "ReportingEntityId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Responses_QuestionId_DesigneeId_ReportingEntityId",
                table: "Responses");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_QuestionId",
                table: "Responses",
                column: "QuestionId");
        }
    }
}
