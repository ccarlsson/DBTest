using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookDB.Api.Data.Migrations
{
    public partial class Customers_Groups_Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { new Guid("ac9c8a4d-656c-44eb-9a96-62faa5ce050e"), "TE18:1" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { new Guid("f87f4b0d-345c-4240-aa12-7126b5e6a7b5"), "TE18:2" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { new Guid("6aad4c8c-e11c-4d90-b789-dd225fcbf452"), "ES18:1" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { new Guid("8bafeac9-7c73-4448-bc12-59ed95d02186"), "ES18:2 " });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { new Guid("d5e77fbe-0dc1-4968-ab12-cdd41d42a7b9"), "EE18A" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Firstname", "GroupId", "Lastname" },
                values: new object[] { new Guid("f9e9f3f1-9a31-4af9-84c9-9b60154f7887"), "Leona", new Guid("ac9c8a4d-656c-44eb-9a96-62faa5ce050e"), "Perry" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Firstname", "GroupId", "Lastname" },
                values: new object[] { new Guid("4ea68fd8-c632-41e0-95ad-445559e551f6"), "Khalil", new Guid("ac9c8a4d-656c-44eb-9a96-62faa5ce050e"), "Trelawney" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Firstname", "GroupId", "Lastname" },
                values: new object[] { new Guid("0c5a5aa0-ee03-482a-a5cd-81e18856dd19"), "Marcia", new Guid("f87f4b0d-345c-4240-aa12-7126b5e6a7b5"), "O'Doherty" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Firstname", "GroupId", "Lastname" },
                values: new object[] { new Guid("a2bf8bfc-8cd4-44fe-80fd-51a3531aadaa"), "Mathilde", new Guid("f87f4b0d-345c-4240-aa12-7126b5e6a7b5"), "Mills" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Firstname", "GroupId", "Lastname" },
                values: new object[] { new Guid("09c29016-7d6d-4bc0-b55f-13da76f418c3"), "Aniela", new Guid("f87f4b0d-345c-4240-aa12-7126b5e6a7b5"), "Freeman" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("09c29016-7d6d-4bc0-b55f-13da76f418c3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0c5a5aa0-ee03-482a-a5cd-81e18856dd19"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4ea68fd8-c632-41e0-95ad-445559e551f6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a2bf8bfc-8cd4-44fe-80fd-51a3531aadaa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f9e9f3f1-9a31-4af9-84c9-9b60154f7887"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("6aad4c8c-e11c-4d90-b789-dd225fcbf452"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("8bafeac9-7c73-4448-bc12-59ed95d02186"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("d5e77fbe-0dc1-4968-ab12-cdd41d42a7b9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("ac9c8a4d-656c-44eb-9a96-62faa5ce050e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("f87f4b0d-345c-4240-aa12-7126b5e6a7b5"));
        }
    }
}
