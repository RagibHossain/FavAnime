using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class NewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.CreateTable(
                name: "AnimeReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Review = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeReviews", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimeReviews");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DirectorName", "Title", "Views" },
                values: new object[] { 1, "SRK", "DDLJ", 100000000 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DirectorName", "Title", "Views" },
                values: new object[] { 2, "HR", "ZNMD", 100000000 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DirectorName", "Title", "Views" },
                values: new object[] { 3, "AK", "3 Idiots", 100000000 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DirectorName", "Title", "Views" },
                values: new object[] { 4, "PC", "Ishaqzaade", 100000000 });
        }
    }
}
