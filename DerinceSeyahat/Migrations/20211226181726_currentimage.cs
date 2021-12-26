﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DerinceSeyahat.Migrations
{
    public partial class currentimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AracImage",
                table: "Araclar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CurrentAracImage",
                table: "Araclar",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentAracImage",
                table: "Araclar");

            migrationBuilder.AlterColumn<string>(
                name: "AracImage",
                table: "Araclar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
