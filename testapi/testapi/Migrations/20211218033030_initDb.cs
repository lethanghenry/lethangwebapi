using Microsoft.EntityFrameworkCore.Migrations;

namespace testapi.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    idCategory = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.idCategory);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    idProduct = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nameProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pictureProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    priceProduct = table.Column<int>(type: "int", nullable: false),
                    discountProduct = table.Column<int>(type: "int", nullable: false),
                    decriptionProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    weightProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dimensionsProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rateProduct = table.Column<int>(type: "int", nullable: false),
                    qualityProduct = table.Column<int>(type: "int", nullable: false),
                    idCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.idProduct);
                });

            migrationBuilder.CreateTable(
                name: "userProducts",
                columns: table => new
                {
                    idUser = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    reviewUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nameUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userProducts", x => x.idUser);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "userProducts");
        }
    }
}
