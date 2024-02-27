﻿// <auto-generated />
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Persistence.Migrations
{
    public partial class AddUserRegistrationDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "first_name",
                schema: "users",
                table: "user_registrations",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "identity_provider_id",
                schema: "users",
                table: "user_registrations",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "last_name",
                schema: "users",
                table: "user_registrations",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "first_name",
                schema: "users",
                table: "user_registrations");

            migrationBuilder.DropColumn(
                name: "identity_provider_id",
                schema: "users",
                table: "user_registrations");

            migrationBuilder.DropColumn(
                name: "last_name",
                schema: "users",
                table: "user_registrations");
        }
    }
}