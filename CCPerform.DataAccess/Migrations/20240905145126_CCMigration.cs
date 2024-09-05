using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCPerform.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CCMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashCenterGroups",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CashCenterGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashCenterGroups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OperationDepartments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OperationDepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationDepartments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SecurityDepartments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SecurityDepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityDepartments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CashCenters",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CashCenterCode = table.Column<short>(type: "smallint", nullable: false),
                    CashCenterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CashCenterGroupID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OperationDepartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SecurityDepartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashCenters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CashCenters_CashCenterGroups_CashCenterGroupID",
                        column: x => x.CashCenterGroupID,
                        principalTable: "CashCenterGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CashCenters_OperationDepartments_OperationDepartmentID",
                        column: x => x.OperationDepartmentID,
                        principalTable: "OperationDepartments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CashCenters_SecurityDepartments_SecurityDepartmentID",
                        column: x => x.SecurityDepartmentID,
                        principalTable: "SecurityDepartments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CashCenters_CashCenterGroupID",
                table: "CashCenters",
                column: "CashCenterGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_CashCenters_OperationDepartmentID",
                table: "CashCenters",
                column: "OperationDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_CashCenters_SecurityDepartmentID",
                table: "CashCenters",
                column: "SecurityDepartmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashCenters");

            migrationBuilder.DropTable(
                name: "CashCenterGroups");

            migrationBuilder.DropTable(
                name: "OperationDepartments");

            migrationBuilder.DropTable(
                name: "SecurityDepartments");
        }
    }
}
