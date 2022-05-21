using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFWork.Migrations
{
    /// <inheritdoc />
    public partial class IdentityAdding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentsPackId = table.Column<int>(type: "int", nullable: false),
                    PasportId = table.Column<int>(type: "int", nullable: true),
                    EmploementHistory = table.Column<int>(type: "int", nullable: true),
                    MedicalBook = table.Column<int>(type: "int", nullable: true),
                    SNILS = table.Column<int>(type: "int", nullable: true),
                    ControlListId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Document__2104C85E41EBEFF1", x => x.DocumentsPackId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Salary = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    TableNumberId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    SizeOfClothes = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DateOfPromotion = table.Column<DateTime>(type: "date", nullable: true),
                    DocumentsPackId = table.Column<int>(type: "int", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__EB6F9EC90E204A3B", x => x.TableNumberId);
                    table.ForeignKey(
                        name: "FK__Employee__Docume__403A8C7D",
                        column: x => x.DocumentsPackId,
                        principalTable: "Documents",
                        principalColumn: "DocumentsPackId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Employee__PostId__412EB0B6",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "UQ__Document__07E30CA0F29E4E30",
                table: "Documents",
                column: "PasportId",
                unique: true,
                filter: "[PasportId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Document__2D66F6430DB004A5",
                table: "Documents",
                column: "MedicalBook",
                unique: true,
                filter: "[MedicalBook] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Document__4CE954544317CD4D",
                table: "Documents",
                column: "ControlListId",
                unique: true,
                filter: "[ControlListId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Document__7EB2A6F9C32908ED",
                table: "Documents",
                column: "SNILS",
                unique: true,
                filter: "[SNILS] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Document__A81A8E1A90305683",
                table: "Documents",
                column: "EmploementHistory",
                unique: true,
                filter: "[EmploementHistory] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DocumentsPackId",
                table: "Employee",
                column: "DocumentsPackId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PostId",
                table: "Employee",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "UQ__Posts__44C68B9F5CAFB844",
                table: "Posts",
                column: "JobTitle",
                unique: true,
                filter: "[JobTitle] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
