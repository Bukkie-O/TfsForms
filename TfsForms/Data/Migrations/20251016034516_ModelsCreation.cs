using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TfsForms.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModelsCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RcNumber",
                table: "tblDesignees",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "OriginatingLea",
                table: "tblDesignees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NslPermanentNumber",
                table: "tblDesignees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DesignationType",
                table: "tblDesignees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateDesignated",
                table: "tblDesignees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.CreateTable(
                name: "tblResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportingEntityName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ReportingEntityCategory = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DesigneeId = table.Column<int>(type: "int", nullable: false),
                    HasRelationship = table.Column<bool>(type: "bit", nullable: false),
                    AccountHolderName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    BVN = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    IsAccountFrozen = table.Column<bool>(type: "bit", nullable: false),
                    DateFrozen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AmountFrozen = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    CurrentBalance = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    AccountType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SuspiciousActivity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LegalChallenges = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ComplianceSteps = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImplementationObservations = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsFalsePositive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblResponses_tblDesignees_DesigneeId",
                        column: x => x.DesigneeId,
                        principalTable: "tblDesignees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblAssets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponseId = table.Column<int>(type: "int", nullable: false),
                    DesigneeId = table.Column<int>(type: "int", nullable: false),
                    AssetName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AssetValue = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblAssets_tblDesignees_DesigneeId",
                        column: x => x.DesigneeId,
                        principalTable: "tblDesignees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblAssets_tblResponses_ResponseId",
                        column: x => x.ResponseId,
                        principalTable: "tblResponses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAssociates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponseId = table.Column<int>(type: "int", nullable: false),
                    DesigneeId = table.Column<int>(type: "int", nullable: false),
                    AssociateName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RcNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAssociates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblAssociates_tblDesignees_DesigneeId",
                        column: x => x.DesigneeId,
                        principalTable: "tblDesignees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblAssociates_tblResponses_ResponseId",
                        column: x => x.ResponseId,
                        principalTable: "tblResponses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblFalsePositives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponseId = table.Column<int>(type: "int", nullable: false),
                    AssociatedDesigneeId = table.Column<int>(type: "int", nullable: false),
                    AssociateName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RcNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    BVN = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFalsePositives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblFalsePositives_tblDesignees_AssociatedDesigneeId",
                        column: x => x.AssociatedDesigneeId,
                        principalTable: "tblDesignees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblFalsePositives_tblResponses_ResponseId",
                        column: x => x.ResponseId,
                        principalTable: "tblResponses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblAssets_DesigneeId",
                table: "tblAssets",
                column: "DesigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAssets_ResponseId",
                table: "tblAssets",
                column: "ResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAssociates_AccountNumber",
                table: "tblAssociates",
                column: "AccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_tblAssociates_DesigneeId",
                table: "tblAssociates",
                column: "DesigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAssociates_ResponseId",
                table: "tblAssociates",
                column: "ResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_tblFalsePositives_AccountNumber",
                table: "tblFalsePositives",
                column: "AccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_tblFalsePositives_AssociatedDesigneeId",
                table: "tblFalsePositives",
                column: "AssociatedDesigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblFalsePositives_ResponseId",
                table: "tblFalsePositives",
                column: "ResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_tblResponses_DesigneeId",
                table: "tblResponses",
                column: "DesigneeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAssets");

            migrationBuilder.DropTable(
                name: "tblAssociates");

            migrationBuilder.DropTable(
                name: "tblFalsePositives");

            migrationBuilder.DropTable(
                name: "tblResponses");

            migrationBuilder.AlterColumn<string>(
                name: "RcNumber",
                table: "tblDesignees",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "OriginatingLea",
                table: "tblDesignees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "NslPermanentNumber",
                table: "tblDesignees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DesignationType",
                table: "tblDesignees",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateDesignated",
                table: "tblDesignees",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
