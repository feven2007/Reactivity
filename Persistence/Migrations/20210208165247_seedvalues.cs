using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class seedvalues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MyProperty",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "feven" });

            migrationBuilder.InsertData(
                table: "MyProperty",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "feven1" });

            migrationBuilder.InsertData(
                table: "MyProperty",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "feven2" });

            migrationBuilder.InsertData(
                table: "MyProperty",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "feven3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MyProperty",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MyProperty",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MyProperty",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MyProperty",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
