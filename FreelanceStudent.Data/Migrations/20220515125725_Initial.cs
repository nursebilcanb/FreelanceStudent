using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreelanceStudent.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Backgrounds",
                columns: table => new
                {
                    BackgroundId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Github = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.BackgroundId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ForeignLanguages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackgroundId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignLanguages", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_ForeignLanguages_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "BackgroundId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackgroundId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobExperiences_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "BackgroundId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackgroundId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguages", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_ProgrammingLanguages_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "BackgroundId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    AdvertId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 15, 15, 57, 24, 359, DateTimeKind.Local).AddTicks(5061)),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.AdvertId);
                    table.ForeignKey(
                        name: "FK_Adverts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Backgrounds",
                columns: new[] { "BackgroundId", "Department", "Github", "ImageUrl", "LinkedIn", "University" },
                values: new object[] { 1, "Software Engineer", null, null, null, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Yazılım" });

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "AdvertId", "CategoryId", "CreatedTime", "Deadline", "Detail", "IsActivated", "Price", "Title" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 15, 15, 57, 24, 369, DateTimeKind.Local).AddTicks(2808), new DateTime(2022, 5, 20, 15, 57, 24, 369, DateTimeKind.Local).AddTicks(3654), "Ders için bir proje", true, 100m, "Freelance Student" });

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_CategoryId",
                table: "Adverts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForeignLanguages_BackgroundId",
                table: "ForeignLanguages",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_JobExperiences_BackgroundId",
                table: "JobExperiences",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammingLanguages_BackgroundId",
                table: "ProgrammingLanguages",
                column: "BackgroundId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");

            migrationBuilder.DropTable(
                name: "ForeignLanguages");

            migrationBuilder.DropTable(
                name: "JobExperiences");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguages");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Backgrounds");
        }
    }
}
