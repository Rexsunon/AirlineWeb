﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirlineWeb.Migrations
{
    public partial class WebhookInitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "webhookSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WebhookURI = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Secret = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    WebhookType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    WebhookPublisher = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_webhookSubscriptions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "webhookSubscriptions");
        }
    }
}
