using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Net21Labb3API.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Interests",
                newName: "Name");

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name", "PersonId" },
                values: new object[,]
                {
                    { 1, "Swimming", null },
                    { 2, "Cycling", null },
                    { 3, "Fishing", null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "James Brown" },
                    { 2, "Tom Cruise" },
                    { 3, "Peter Pan" }
                });

            migrationBuilder.InsertData(
                table: "Websites",
                columns: new[] { "Id", "Descripton", "InterestId", "Url" },
                values: new object[,]
                {
                    { 1, null, null, "https://www.etsy.com/market/fishing_lovers" },
                    { 2, null, null, "https://www.topendsports.com/sport/cycling-sports.htm" },
                    { 3, null, null, "https://www.swimmingworldmagazine.com/news/ranking-the-best-mens-swimmers-in-the-world-from-1-25-as-olympic-year-arrives/" },
                    { 4, null, null, "https://www.waterworksswim.com/swim-library/detail/2014-09-05-top-10-swimmers-of-all-time-post-378" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Interests",
                newName: "Description");
        }
    }
}
