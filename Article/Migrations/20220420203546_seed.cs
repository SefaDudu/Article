using Microsoft.EntityFrameworkCore.Migrations;

namespace Article.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "UnitPrice",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Feature", "UnitPrice" },
                values: new object[] { "Ürün özellikleri Gelecek", 100.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "Feature",
                value: "Ürün özellikleri");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "Feature",
                value: "Ürün özellikleri");
        }
    }
}
