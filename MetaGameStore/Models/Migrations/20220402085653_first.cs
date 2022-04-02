using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Users",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Users",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "Users",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Users",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Users",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "phone_number",
                table: "Users",
                type: "integer",
                maxLength: 9,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "postal_code",
                table: "Users",
                type: "character varying(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "user_type",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Users",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    paymentType = table.Column<int>(type: "integer", nullable: false),
                    ammount = table.Column<int>(type: "integer", nullable: false),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    producer = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    desription = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    price = table.Column<double>(type: "double precision", nullable: false),
                    count = table.Column<int>(type: "integer", nullable: false),
                    photo = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    price = table.Column<double>(type: "double precision", nullable: false),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    shippingName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    shippingCity = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    shippingAddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    shippingPostalCode = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    shippingCountry = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    idUser = table.Column<int>(type: "integer", nullable: false),
                    idPayment = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_Orders_Payments_idPayment",
                        column: x => x.idPayment,
                        principalTable: "Payments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_idUser",
                        column: x => x.idUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    game_type = table.Column<int>(type: "integer", nullable: false),
                    premiere = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    pegi = table.Column<string>(type: "text", nullable: false),
                    platform = table.Column<int>(type: "integer", nullable: false),
                    game_mode = table.Column<string>(type: "text", nullable: false),
                    id_product = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsGames_Products_id_product",
                        column: x => x.id_product,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    productPrice = table.Column<double>(type: "double precision", nullable: false),
                    productCount = table.Column<int>(type: "integer", nullable: false),
                    productDiscount = table.Column<int>(type: "integer", nullable: false),
                    idOrder = table.Column<int>(type: "integer", nullable: false),
                    idProduct = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_idOrder",
                        column: x => x.idOrder,
                        principalTable: "Orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_idProduct",
                        column: x => x.idProduct,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_idOrder",
                table: "OrderDetails",
                column: "idOrder");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_idProduct",
                table: "OrderDetails",
                column: "idProduct",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_idPayment",
                table: "Orders",
                column: "idPayment",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_idUser",
                table: "Orders",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsGames_id_product",
                table: "ProductsGames",
                column: "id_product",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductsGames");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropColumn(
                name: "address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "country",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "phone_number",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "postal_code",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "user_type",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Users");
        }
    }
}
