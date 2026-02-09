using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TfsForms.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAssets");

            migrationBuilder.DropTable(
                name: "tblAssociates");

            migrationBuilder.DropTable(
                name: "tblFalsePositives");

            migrationBuilder.DropTable(
                name: "tblResponses");

            migrationBuilder.DropTable(
                name: "tblDesignees");

            migrationBuilder.CreateTable(
                name: "Designees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DesignationType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    RcNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateDesignated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NslPermanentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OriginatingLea = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    QuestionType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesigneeId = table.Column<int>(type: "int", nullable: false),
                    ReportingEntityId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsDraft = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArchivetblResponses",
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
                    table.PrimaryKey("PK_ArchivetblResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArchivetblResponses_Designees_DesigneeId",
                        column: x => x.DesigneeId,
                        principalTable: "Designees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponseId = table.Column<int>(type: "int", nullable: false),
                    AssetType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EstimatedValue = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ArchivetblResponseId = table.Column<int>(type: "int", nullable: true),
                    DesigneeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assets_ArchivetblResponses_ArchivetblResponseId",
                        column: x => x.ArchivetblResponseId,
                        principalTable: "ArchivetblResponses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assets_Designees_DesigneeId",
                        column: x => x.DesigneeId,
                        principalTable: "Designees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assets_Responses_ResponseId",
                        column: x => x.ResponseId,
                        principalTable: "Responses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Associates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponseId = table.Column<int>(type: "int", nullable: false),
                    AssociateName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RelationshipType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AdditionalIdentifiers = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ArchivetblResponseId = table.Column<int>(type: "int", nullable: true),
                    DesigneeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Associates_ArchivetblResponses_ArchivetblResponseId",
                        column: x => x.ArchivetblResponseId,
                        principalTable: "ArchivetblResponses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Associates_Designees_DesigneeId",
                        column: x => x.DesigneeId,
                        principalTable: "Designees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Associates_Responses_ResponseId",
                        column: x => x.ResponseId,
                        principalTable: "Responses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FalsePositives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponseId = table.Column<int>(type: "int", nullable: false),
                    MatchedName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    BVN = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    AdditionalIdentifiers = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ArchivetblResponseId = table.Column<int>(type: "int", nullable: true),
                    DesigneeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FalsePositives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FalsePositives_ArchivetblResponses_ArchivetblResponseId",
                        column: x => x.ArchivetblResponseId,
                        principalTable: "ArchivetblResponses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FalsePositives_Designees_DesigneeId",
                        column: x => x.DesigneeId,
                        principalTable: "Designees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FalsePositives_Responses_ResponseId",
                        column: x => x.ResponseId,
                        principalTable: "Responses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArchivetblResponses_DesigneeId",
                table: "ArchivetblResponses",
                column: "DesigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_ArchivetblResponseId",
                table: "Assets",
                column: "ArchivetblResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_DesigneeId",
                table: "Assets",
                column: "DesigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_ResponseId",
                table: "Assets",
                column: "ResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_Associates_AccountNumber",
                table: "Associates",
                column: "AccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Associates_ArchivetblResponseId",
                table: "Associates",
                column: "ArchivetblResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_Associates_DesigneeId",
                table: "Associates",
                column: "DesigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Associates_ResponseId",
                table: "Associates",
                column: "ResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_FalsePositives_AccountNumber",
                table: "FalsePositives",
                column: "AccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_FalsePositives_ArchivetblResponseId",
                table: "FalsePositives",
                column: "ArchivetblResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_FalsePositives_DesigneeId",
                table: "FalsePositives",
                column: "DesigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_FalsePositives_ResponseId",
                table: "FalsePositives",
                column: "ResponseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Associates");

            migrationBuilder.DropTable(
                name: "FalsePositives");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "ArchivetblResponses");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Designees");

            migrationBuilder.CreateTable(
                name: "tblDesignees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDesignated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DesignationType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NslPermanentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OriginatingLea = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RcNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDesignees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesigneeId = table.Column<int>(type: "int", nullable: false),
                    AccountHolderName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AccountType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AmountFrozen = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    BVN = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    ComplianceSteps = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CurrentBalance = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    DateFrozen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HasRelationship = table.Column<bool>(type: "bit", nullable: false),
                    ImplementationObservations = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsAccountFrozen = table.Column<bool>(type: "bit", nullable: false),
                    IsFalsePositive = table.Column<bool>(type: "bit", nullable: false),
                    LegalChallenges = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ReportingEntityCategory = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ReportingEntityName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SuspiciousActivity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAssets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesigneeId = table.Column<int>(type: "int", nullable: false),
                    ResponseId = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
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
                    DesigneeId = table.Column<int>(type: "int", nullable: false),
                    ResponseId = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AssociateName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RcNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAssociates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblAssociates_tblDesignees_DesigneeId",
                        column: x => x.DesigneeId,
                        principalTable: "tblDesignees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    AssociatedDesigneeId = table.Column<int>(type: "int", nullable: false),
                    ResponseId = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AssociateName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BVN = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    RcNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFalsePositives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblFalsePositives_tblDesignees_AssociatedDesigneeId",
                        column: x => x.AssociatedDesigneeId,
                        principalTable: "tblDesignees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
    }
}
