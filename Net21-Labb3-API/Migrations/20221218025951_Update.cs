using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net21Labb3API.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Websites_Interests_InterestId",
                table: "Websites");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Websites",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InterestId",
                table: "Websites",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Cycling");

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Fishing");

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Swimming");

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 1,
                column: "InterestId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 2,
                column: "InterestId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 3,
                column: "InterestId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 4,
                column: "InterestId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Websites_Interests_InterestId",
                table: "Websites",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Websites_Interests_InterestId",
                table: "Websites");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Websites",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "InterestId",
                table: "Websites",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Swimming");

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Cycling");

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Fishing");

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 1,
                column: "InterestId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 2,
                column: "InterestId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 3,
                column: "InterestId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "Id",
                keyValue: 4,
                column: "InterestId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Websites_Interests_InterestId",
                table: "Websites",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "Id");
        }
    }
}
