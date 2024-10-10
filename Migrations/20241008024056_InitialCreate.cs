using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SimplyBooksBE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Favorite = table.Column<bool>(type: "boolean", nullable: true),
                    Uid = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Sale = table.Column<bool>(type: "boolean", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Favorite", "FirstName", "Image", "LastName", "Uid" },
                values: new object[,]
                {
                    { 1, "emily.turner@example.com", false, "Emily", "https://example.com/images/emily.jpg", "Turner", "3HLd4GH2OrYYJ1eAUWEqFcixcK02" },
                    { 2, "michael.smith@example.com", true, "Michael", "https://example.com/images/michael.jpg", "Smith", "3HLd4GH2OrYYJ1eAUWEqFcixcK02" },
                    { 3, "olivia.johnson@example.com", false, "Olivia", "https://example.com/images/olivia.jpg", "Johnson", "3HLd4GH2OrYYJ1eAUWEqFcixcK02" },
                    { 4, "james.williams@example.com", true, "James", "https://example.com/images/james.jpg", "Williams", "3HLd4GH2OrYYJ1eAUWEqFcixcK02" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Image", "Price", "Sale", "Title", "Uid" },
                values: new object[,]
                {
                    { 1, 1, "A comprehensive guide to C# programming.", "https://example.com/images/csharp.jpg", 29.99m, false, "Introduction to C#", "3HLd4GH2OrYYJ1eAUWEqFcixcK02" },
                    { 2, 2, "Advanced concepts in ASP.NET Core development.", "https://example.com/images/aspnet.jpg", 39.99m, true, "Mastering ASP.NET", "3HLd4GH2OrYYJ1eAUWEqFcixcK02" },
                    { 3, 3, "Learn the basics of JavaScript from scratch.", "https://example.com/images/javascript.jpg", 24.99m, true, "JavaScript Essentials", "3HLd4GH2OrYYJ1eAUWEqFcixcK02" },
                    { 4, 4, "An introduction to building web apps with React.", "https://example.com/images/react.jpg", 19.99m, false, "React for Beginners", "3HLd4GH2OrYYJ1eAUWEqFcixcK02" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
