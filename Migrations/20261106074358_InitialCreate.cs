using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreMinimalApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bookapi");

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "bookapi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalPages = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "bookapi",
                table: "Books",
                columns: new[] { "Id", "Author", "Category", "Description", "Language", "Title", "TotalPages" },
                values: new object[,]
                {
                    { new Guid("07f60fa5-7322-4bd3-b477-430eb8740de0"), "George Orwell", "Fiction", "A dystopian social science fiction novel and cautionary tale about the dangers of totalitarianism. ", "English", "1984", 328 },
                    { new Guid("1dea400c-9d39-4720-a3d7-d8abe67c9d69"), "Harper Lee", "Fiction", "A novel about the serious issues of rape and racial inequality.", "English", "To Kill a Mockingbird", 281 },
                    { new Guid("2fe401ca-9d79-4edf-94d6-27921b1ff0aa"), "George Orwell", "Fiction", "A dystopian social science fiction novel and cautionary tale about the dangers of totalitarianism. ", "English", "1984", 328 },
                    { new Guid("326f7658-6086-4d7e-b520-d1e3b219dee2"), "Harper Lee", "Fiction", "A novel about the serious issues of rape and racial inequality.", "English", "To Kill a Mockingbird", 281 },
                    { new Guid("5b9bc57a-d013-4039-99aa-d30a8d230533"), "Paulo Coelho", "Fiction", "The Alchemist follows the journey of an Andalusian shepherd", "English", "The Alchemist", 208 },
                    { new Guid("63a84adf-acb3-4022-8133-3b75f67a36f2"), "Paulo Coelho", "Fiction", "The Alchemist follows the journey of an Andalusian shepherd", "English", "The Alchemist", 208 },
                    { new Guid("8bafa0c9-7e9a-4694-b5ad-d92f27e55ea6"), "Aldous Huxley", "Science Fiction", "A futuristic society engineered through genetic modification and psychological conditioning.", "English", "Brave New World", 311 },
                    { new Guid("9c73b90c-8357-4843-b74a-31c95a4d44fb"), "J.R.R. Tolkien", "Fantasy", "An epic high-fantasy novel that follows the quest to destroy the One Ring.", "English", "The Lord of the Rings", 1178 },
                    { new Guid("a3c92449-8528-4070-b2a2-faa9e0c914d8"), "J.R.R. Tolkien", "Fantasy", "An epic high-fantasy novel that follows the quest to destroy the One Ring.", "English", "The Lord of the Rings", 1178 },
                    { new Guid("da7f7439-fe05-4ac6-b61a-50e7d0a16e96"), "Aldous Huxley", "Science Fiction", "A futuristic society engineered through genetic modification and psychological conditioning.", "English", "Brave New World", 311 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books",
                schema: "bookapi");
        }
    }
}
