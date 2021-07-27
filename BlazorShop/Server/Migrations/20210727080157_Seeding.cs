using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorShop.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 1, "book", "Books", "books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 2, "camera-slr", "Electronics", "electronics" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 3, "aperture", "Video Games", "video-games" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 7, 27, 10, 1, 57, 35, DateTimeKind.Local).AddTicks(5828), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The hitchhiker's Guide to the Galaxy (sometimes referred to as H) is comedy science fiction series", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", false, false, 19.99m, 9.99m, "The Hitchcker's guide tot he galaxy" },
                    { 3, 1, new DateTime(2021, 7, 27, 10, 1, 57, 37, DateTimeKind.Local).AddTicks(9140), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nineteen Eigthy-four: A Novel, Often published as 1984, is a dystopian social", "https://upload.wikimedia.org/wikipedia/en/c/c3/1984first.jpg", false, false, 0m, 6.99m, "Nineteen Eighty-Four" },
                    { 4, 2, new DateTime(2021, 7, 27, 10, 1, 57, 37, DateTimeKind.Local).AddTicks(9144), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi", "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg", false, false, 249.00m, 166.66m, "Pentax Spotmatic" },
                    { 5, 2, new DateTime(2021, 7, 27, 10, 1, 57, 37, DateTimeKind.Local).AddTicks(9147), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Xbox is a home video game console and the first installment in the Xbox series....", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", false, false, 299m, 159.99m, "XBox" },
                    { 6, 2, new DateTime(2021, 7, 27, 10, 1, 57, 37, DateTimeKind.Local).AddTicks(9158), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Super Nintendo Entertaiment System(SNES), also known as the Super NES or super nintendo, is a16-bit home video game", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", false, false, 400m, 74.74m, "Super Nintendo Entertaimen System" },
                    { 2, 3, new DateTime(2021, 7, 27, 10, 1, 57, 37, DateTimeKind.Local).AddTicks(9107), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-life 2 is a 2004 first person shooter game developed an published by value.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", false, false, 29.99m, 8.99m, "Half-Life 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
