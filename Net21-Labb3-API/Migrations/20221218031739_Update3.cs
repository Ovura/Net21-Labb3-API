using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net21Labb3API.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Interests",
                newName: "Title");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Websites",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Interests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Mx Mountain Bikes and Motorcycle racing");

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Deep Sea and hobby Fishing");

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Fresstyle swimming");

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Websites_PersonId",
                table: "Websites",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Websites_People_PersonId",
                table: "Websites",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Websites_People_PersonId",
                table: "Websites");

            migrationBuilder.DropIndex(
                name: "IX_Websites_PersonId",
                table: "Websites");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Websites");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Interests");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Interests",
                newName: "Name");
        }
    }
}
