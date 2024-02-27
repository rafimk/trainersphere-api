﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Notifications.Persistence.Migrations
{
    public partial class CreateInboxMessageConsumers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "inbox_message_consumers",
                schema: "notifications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_inbox_message_consumers", x => new { x.id, x.name });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inbox_message_consumers",
                schema: "notifications");
        }
    }
}
