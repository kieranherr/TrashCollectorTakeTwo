using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddDateToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29df2c19-425f-4dde-8866-ef1725501774");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41a88cde-d332-4c2a-900b-44edb187dcf2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbcfe4a2-487e-4d10-b14d-5be2b802e388");

            migrationBuilder.AddColumn<string>(
                name: "PickUpDate",
                table: "Customer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7cfa5178-d098-4ed7-9ec3-ee264e47c134", "11b3f2fe-c0cc-4397-b8f1-aa2ec8a1f13c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2eaf33c7-3d50-48d7-9bf2-2062d6986de7", "89341b63-020f-4b09-a95a-d78a4b08e138", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "15b16948-d751-452e-a6ef-cfc392b1d5a3", "bc109987-2a7d-4a35-8824-233b4cd2fdda", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15b16948-d751-452e-a6ef-cfc392b1d5a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2eaf33c7-3d50-48d7-9bf2-2062d6986de7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cfa5178-d098-4ed7-9ec3-ee264e47c134");

            migrationBuilder.DropColumn(
                name: "PickUpDate",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41a88cde-d332-4c2a-900b-44edb187dcf2", "ec8f05c0-b907-4626-a41d-2f56b1331ce9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbcfe4a2-487e-4d10-b14d-5be2b802e388", "ad0bbb50-4333-41bd-b62e-9f8faace8746", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29df2c19-425f-4dde-8866-ef1725501774", "ad4a6859-0400-4109-9173-5c4a7fe9f73d", "Employee", "EMPLOYEE" });
        }
    }
}
