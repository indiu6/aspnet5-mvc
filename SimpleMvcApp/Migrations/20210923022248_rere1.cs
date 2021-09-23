using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleMvcApp.Migrations
{
    public partial class rere1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Message");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Message",
                newName: "Borrower");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Borrower",
                table: "Message",
                newName: "Title");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Message",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Message",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
