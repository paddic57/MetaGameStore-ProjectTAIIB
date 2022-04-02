using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_idPayment",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsGames_Products_id_product",
                table: "ProductsGames");

            migrationBuilder.DropIndex(
                name: "IX_ProductsGames_id_product",
                table: "ProductsGames");

            migrationBuilder.DropIndex(
                name: "IX_Orders_idPayment",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "id_product",
                table: "ProductsGames");

            migrationBuilder.DropColumn(
                name: "idPayment",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Products",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Orders",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_id",
                table: "Orders",
                column: "id",
                principalTable: "Payments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsGames_id",
                table: "Products",
                column: "id",
                principalTable: "ProductsGames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_id",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsGames_id",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "id_product",
                table: "ProductsGames",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Products",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Orders",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<int>(
                name: "idPayment",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsGames_id_product",
                table: "ProductsGames",
                column: "id_product",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_idPayment",
                table: "Orders",
                column: "idPayment",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_idPayment",
                table: "Orders",
                column: "idPayment",
                principalTable: "Payments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsGames_Products_id_product",
                table: "ProductsGames",
                column: "id_product",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
