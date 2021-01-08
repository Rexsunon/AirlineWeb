using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirlineWeb.Migrations
{
    public partial class InitialAirlineAPIMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_webhookSubscriptions",
                table: "webhookSubscriptions");

            migrationBuilder.RenameTable(
                name: "webhookSubscriptions",
                newName: "WebhookSubscriptions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WebhookSubscriptions",
                table: "WebhookSubscriptions",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FlightDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FlightCode = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WebhookSubscriptions",
                table: "WebhookSubscriptions");

            migrationBuilder.RenameTable(
                name: "WebhookSubscriptions",
                newName: "webhookSubscriptions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_webhookSubscriptions",
                table: "webhookSubscriptions",
                column: "Id");
        }
    }
}
