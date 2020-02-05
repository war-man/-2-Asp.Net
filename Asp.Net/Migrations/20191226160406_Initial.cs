using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kursach.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessLevel = table.Column<int>(nullable: true),
                    Name_of_position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    type_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Department_name = table.Column<string>(nullable: true),
                    TypeOfDocumentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Departments_TypeOfDocuments_TypeOfDocumentId",
                        column: x => x.TypeOfDocumentId,
                        principalTable: "TypeOfDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    employee_name = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "input_Documents",
                columns: table => new
                {
                    Input_DocumentsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data_register = table.Column<DateTime>(nullable: true),
                    DeadLine = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    FileHref = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: true),
                    Access_Level = table.Column<int>(nullable: true),
                    ApproverEmployeeId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_input_Documents", x => x.Input_DocumentsId);
                    table.ForeignKey(
                        name: "FK_input_Documents_Employees_ApproverEmployeeId",
                        column: x => x.ApproverEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_input_Documents_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_input_Documents_TypeOfDocuments_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypeOfDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interior_Documents",
                columns: table => new
                {
                    Interior_DocumentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApproverEmployeeId = table.Column<int>(nullable: false),
                    ExecutorEmployeeId = table.Column<int>(nullable: false),
                    Data_register = table.Column<DateTime>(nullable: true),
                    DeadLine = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    FileHref = table.Column<string>(nullable: true),
                    Access_Level = table.Column<int>(nullable: true),
                    TypeId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interior_Documents", x => new { x.Interior_DocumentId, x.ExecutorEmployeeId, x.ApproverEmployeeId });
                    table.UniqueConstraint("AK_Interior_Documents_Interior_DocumentId", x => x.Interior_DocumentId);
                    table.ForeignKey(
                        name: "FK_Interior_Documents_Employees_ApproverEmployeeId",
                        column: x => x.ApproverEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Interior_Documents_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Interior_Documents_Employees_ExecutorEmployeeId",
                        column: x => x.ExecutorEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Interior_Documents_TypeOfDocuments_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypeOfDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Output_Documents",
                columns: table => new
                {
                    Output_DocumentsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data_register = table.Column<DateTime>(nullable: true),
                    Date_of_Execution = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    FileHref = table.Column<string>(nullable: true),
                    ExecutorEmployeeId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: true),
                    Access_Level = table.Column<int>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Output_Documents", x => x.Output_DocumentsId);
                    table.ForeignKey(
                        name: "FK_Output_Documents_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Output_Documents_Employees_ExecutorEmployeeId",
                        column: x => x.ExecutorEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Output_Documents_TypeOfDocuments_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypeOfDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_TypeOfDocumentId",
                table: "Departments",
                column: "TypeOfDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_input_Documents_ApproverEmployeeId",
                table: "input_Documents",
                column: "ApproverEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_input_Documents_DepartmentId",
                table: "input_Documents",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_input_Documents_TypeId",
                table: "input_Documents",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Interior_Documents_ApproverEmployeeId",
                table: "Interior_Documents",
                column: "ApproverEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Interior_Documents_DepartmentId",
                table: "Interior_Documents",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Interior_Documents_ExecutorEmployeeId",
                table: "Interior_Documents",
                column: "ExecutorEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Interior_Documents_TypeId",
                table: "Interior_Documents",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Output_Documents_DepartmentId",
                table: "Output_Documents",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Output_Documents_ExecutorEmployeeId",
                table: "Output_Documents",
                column: "ExecutorEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Output_Documents_TypeId",
                table: "Output_Documents",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "input_Documents");

            migrationBuilder.DropTable(
                name: "Interior_Documents");

            migrationBuilder.DropTable(
                name: "Output_Documents");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "TypeOfDocuments");
        }
    }
}
