using Microsoft.EntityFrameworkCore.Migrations;

namespace TI_Repository.Migrations
{
    public partial class empresas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ee71be6-fda1-490a-8440-e8b51764890c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9f5602d-c352-418a-a843-5da8bfd40c15");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "702355d7-8d63-47b2-ab94-01a7218b6f38", "4dbcfc87-150b-4bf9-81b5-a50788de3d0c", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9fc038e3-6f48-4f56-9069-b0d1d9379fc5", "5f7d07bb-57e1-40fb-b93d-2274c7ccc033", "Alunos", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "702355d7-8d63-47b2-ab94-01a7218b6f38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fc038e3-6f48-4f56-9069-b0d1d9379fc5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ee71be6-fda1-490a-8440-e8b51764890c", "568f69bc-6fc9-44c9-8431-0ec3a8e0ccac", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9f5602d-c352-418a-a843-5da8bfd40c15", "183947d7-7cbf-4aa5-aafd-7c998bffff9a", "Alunos", null });
        }
    }
}
