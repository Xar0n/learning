using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedTimestamp",
                table: "FileDescriptions");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "FileDescriptions");

            migrationBuilder.DropColumn(
                name: "UpdatedTimestamp",
                table: "FileDescriptions");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "FileDescriptions",
                newName: "Name");

            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "FileDescriptions",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "FileDescriptions");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FileDescriptions",
                newName: "FileName");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTimestamp",
                table: "FileDescriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FileDescriptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTimestamp",
                table: "FileDescriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
