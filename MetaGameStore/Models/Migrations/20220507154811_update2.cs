using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_idOrder",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_idProduct",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_idPayment",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsGames_id",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Users",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Users",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Users",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "user_type",
                table: "Users",
                newName: "UserType");

            migrationBuilder.RenameColumn(
                name: "postal_code",
                table: "Users",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "Users",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "premiere",
                table: "ProductsGames",
                newName: "Premiere");

            migrationBuilder.RenameColumn(
                name: "platform",
                table: "ProductsGames",
                newName: "Platform");

            migrationBuilder.RenameColumn(
                name: "pegi",
                table: "ProductsGames",
                newName: "Pegi");

            migrationBuilder.RenameColumn(
                name: "game_type",
                table: "ProductsGames",
                newName: "GameType");

            migrationBuilder.RenameColumn(
                name: "game_mode",
                table: "ProductsGames",
                newName: "GameMode");

            migrationBuilder.RenameColumn(
                name: "producer",
                table: "Products",
                newName: "Producer");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "photo",
                table: "Products",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "desription",
                table: "Products",
                newName: "Desription");

            migrationBuilder.RenameColumn(
                name: "count",
                table: "Products",
                newName: "Count");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Payments",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "paymentType",
                table: "Payments",
                newName: "PaymentType");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Payments",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "ammount",
                table: "Payments",
                newName: "Ammount");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Payments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "shippingPostalCode",
                table: "Orders",
                newName: "ShippingPostalCode");

            migrationBuilder.RenameColumn(
                name: "shippingName",
                table: "Orders",
                newName: "ShippingName");

            migrationBuilder.RenameColumn(
                name: "shippingCountry",
                table: "Orders",
                newName: "ShippingCountry");

            migrationBuilder.RenameColumn(
                name: "shippingCity",
                table: "Orders",
                newName: "ShippingCity");

            migrationBuilder.RenameColumn(
                name: "shippingAddress",
                table: "Orders",
                newName: "ShippingAddress");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Orders",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "idPayment",
                table: "Orders",
                newName: "IdPayment");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Orders",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_idPayment",
                table: "Orders",
                newName: "IX_Orders_IdPayment");

            migrationBuilder.RenameColumn(
                name: "productPrice",
                table: "OrderDetails",
                newName: "ProductPrice");

            migrationBuilder.RenameColumn(
                name: "productDiscount",
                table: "OrderDetails",
                newName: "ProductDiscount");

            migrationBuilder.RenameColumn(
                name: "productCount",
                table: "OrderDetails",
                newName: "ProductCount");

            migrationBuilder.RenameColumn(
                name: "idProduct",
                table: "OrderDetails",
                newName: "IdProduct");

            migrationBuilder.RenameColumn(
                name: "idOrder",
                table: "OrderDetails",
                newName: "IdOrder");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_idProduct",
                table: "OrderDetails",
                newName: "IX_OrderDetails_IdProduct");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_idOrder",
                table: "OrderDetails",
                newName: "IX_OrderDetails_IdOrder");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_IdOrder",
                table: "OrderDetails",
                column: "IdOrder",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_IdProduct",
                table: "OrderDetails",
                column: "IdProduct",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_IdPayment",
                table: "Orders",
                column: "IdPayment",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsGames_Id",
                table: "Products",
                column: "Id",
                principalTable: "ProductsGames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_IdOrder",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_IdProduct",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_IdPayment",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsGames_Id",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Users",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Users",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Users",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "UserType",
                table: "Users",
                newName: "user_type");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Users",
                newName: "postal_code");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Users",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "Premiere",
                table: "ProductsGames",
                newName: "premiere");

            migrationBuilder.RenameColumn(
                name: "Platform",
                table: "ProductsGames",
                newName: "platform");

            migrationBuilder.RenameColumn(
                name: "Pegi",
                table: "ProductsGames",
                newName: "pegi");

            migrationBuilder.RenameColumn(
                name: "GameType",
                table: "ProductsGames",
                newName: "game_type");

            migrationBuilder.RenameColumn(
                name: "GameMode",
                table: "ProductsGames",
                newName: "game_mode");

            migrationBuilder.RenameColumn(
                name: "Producer",
                table: "Products",
                newName: "producer");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Products",
                newName: "photo");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Desription",
                table: "Products",
                newName: "desription");

            migrationBuilder.RenameColumn(
                name: "Count",
                table: "Products",
                newName: "count");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Payments",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "PaymentType",
                table: "Payments",
                newName: "paymentType");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Payments",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Ammount",
                table: "Payments",
                newName: "ammount");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Payments",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ShippingPostalCode",
                table: "Orders",
                newName: "shippingPostalCode");

            migrationBuilder.RenameColumn(
                name: "ShippingName",
                table: "Orders",
                newName: "shippingName");

            migrationBuilder.RenameColumn(
                name: "ShippingCountry",
                table: "Orders",
                newName: "shippingCountry");

            migrationBuilder.RenameColumn(
                name: "ShippingCity",
                table: "Orders",
                newName: "shippingCity");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress",
                table: "Orders",
                newName: "shippingAddress");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Orders",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "IdPayment",
                table: "Orders",
                newName: "idPayment");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Orders",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_IdPayment",
                table: "Orders",
                newName: "IX_Orders_idPayment");

            migrationBuilder.RenameColumn(
                name: "ProductPrice",
                table: "OrderDetails",
                newName: "productPrice");

            migrationBuilder.RenameColumn(
                name: "ProductDiscount",
                table: "OrderDetails",
                newName: "productDiscount");

            migrationBuilder.RenameColumn(
                name: "ProductCount",
                table: "OrderDetails",
                newName: "productCount");

            migrationBuilder.RenameColumn(
                name: "IdProduct",
                table: "OrderDetails",
                newName: "idProduct");

            migrationBuilder.RenameColumn(
                name: "IdOrder",
                table: "OrderDetails",
                newName: "idOrder");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_IdProduct",
                table: "OrderDetails",
                newName: "IX_OrderDetails_idProduct");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_IdOrder",
                table: "OrderDetails",
                newName: "IX_OrderDetails_idOrder");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_idOrder",
                table: "OrderDetails",
                column: "idOrder",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_idProduct",
                table: "OrderDetails",
                column: "idProduct",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_idPayment",
                table: "Orders",
                column: "idPayment",
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
    }
}
