using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace JWTAuthentication.WebApi.Migrations
{
    public partial class foodModels_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCard",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(nullable: false),
                    SecurityCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCard", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<string>(maxLength: 10, nullable: false),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: false),
                    HomeLocation = table.Column<Geometry>(nullable: false),
                    CurrentLocatiion = table.Column<Geometry>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OperatingTime",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingTime", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryContacts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WhatsAppNumber = table.Column<int>(nullable: true),
                    OtherNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryContacts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreditCard = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK__PaymentDe__Credi__38996AB5",
                        column: x => x.CreditCard,
                        principalTable: "CreditCard",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    PaymentType = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_Customer",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekDay = table.Column<string>(maxLength: 10, nullable: false),
                    StartingHour = table.Column<TimeSpan>(type: "time(0)", nullable: false),
                    ClosingHour = table.Column<TimeSpan>(type: "time(0)", nullable: false),
                    OperatingTimeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Day_OperatingTime",
                        column: x => x.OperatingTimeID,
                        principalTable: "OperatingTime",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimaryPhone = table.Column<int>(nullable: false),
                    SecondaryContacts = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Contact__Seconda__656C112C",
                        column: x => x.SecondaryContacts,
                        principalTable: "SecondaryContacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restorant",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    OperatingTimeID = table.Column<int>(nullable: false),
                    Location = table.Column<Geometry>(nullable: false),
                    Rating = table.Column<double>(nullable: false),
                    ContactID = table.Column<int>(nullable: false),
                    PaymentDetailsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restorant", x => x.ID);
                    table.UniqueConstraint("AK_Restorant_PaymentDetailsID", x => x.PaymentDetailsID);
                    table.ForeignKey(
                        name: "FK__Restorant__Conta__123EB7A3",
                        column: x => x.ContactID,
                        principalTable: "Contact",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Restorant__Opera__114A936A",
                        column: x => x.OperatingTimeID,
                        principalTable: "OperatingTime",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Restorant__Payme__1332DBDC",
                        column: x => x.PaymentDetailsID,
                        principalTable: "PaymentDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Picture = table.Column<byte[]>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    RestorantID = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Item_Order",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Restorant",
                        column: x => x.RestorantID,
                        principalTable: "Restorant",
                        principalColumn: "PaymentDetailsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<double>(nullable: false),
                    ResturantID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rating_Customer",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rating_Restorant",
                        column: x => x.ResturantID,
                        principalTable: "Restorant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestorantUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    RestorantId = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestorantUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestorantUsers_Restorant_RestorantId",
                        column: x => x.RestorantId,
                        principalTable: "Restorant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "Contact_secondaryContact",
                table: "Contact",
                column: "SecondaryContacts",
                unique: true,
                filter: "[SecondaryContacts] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Day_OperatingTimeID",
                table: "Day",
                column: "OperatingTimeID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_OrderID",
                table: "Item",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_RestorantID",
                table: "Item",
                column: "RestorantID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "Payment_CreditCard",
                table: "PaymentDetails",
                column: "CreditCard",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rating_CustomerID",
                table: "Rating",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ResturantID",
                table: "Rating",
                column: "ResturantID");

            migrationBuilder.CreateIndex(
                name: "Restorant_Contact",
                table: "Restorant",
                column: "ContactID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Restorant_operatingTime",
                table: "Restorant",
                column: "OperatingTimeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Restorant_PaymentdDetails",
                table: "Restorant",
                column: "PaymentDetailsID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestorantUsers_RestorantId",
                table: "RestorantUsers",
                column: "RestorantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Day");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "RestorantUsers");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Restorant");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "OperatingTime");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "SecondaryContacts");

            migrationBuilder.DropTable(
                name: "CreditCard");
        }
    }
}
