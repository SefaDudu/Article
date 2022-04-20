using Microsoft.EntityFrameworkCore.Migrations;

namespace Article.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "fa-mobile-screen", "TELEFON" },
                    { 2, "fa-computer", "BİLGİSAYAR" },
                    { 3, "fa-tv", "TELEVİZYON" },
                    { 4, "fa-camera", "KAMERA" },
                    { 5, "fa-blender", "BEYAZ EŞYA" },
                    { 6, "fa-chair", "EV ALETLERİ" },
                    { 7, "fa-spray-can-sparkles", "BAKIM" },
                    { 8, "fa-gamepad", "OYUN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "password" },
                values: new object[] { 1, "sefa@sefa", "sefa" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Oppo" },
                    { 22, 8, "Spor" },
                    { 21, 7, "Bakım Sağlık3" },
                    { 20, 7, "Bakım Sağlık2" },
                    { 19, 7, "Bakım Sağlık" },
                    { 18, 6, "Ev Aleti 3" },
                    { 17, 6, "Ev Aleti 2" },
                    { 16, 6, "Ev Aleti 1" },
                    { 15, 5, "Fırın" },
                    { 14, 5, "Çamaşır Makinası" },
                    { 13, 5, "Buzdolabı" },
                    { 12, 4, "makine 3" },
                    { 11, 4, "makine 2" },
                    { 10, 4, "makine 1" },
                    { 9, 3, "Grundig" },
                    { 8, 3, "LG" },
                    { 7, 3, "Samsung" },
                    { 6, 2, "Lenova" },
                    { 5, 2, "HP" },
                    { 4, 2, "Huawei" },
                    { 3, 1, "Iphone" },
                    { 2, 1, "Samsung" },
                    { 23, 8, "Spor2" },
                    { 24, 8, "Spor3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
