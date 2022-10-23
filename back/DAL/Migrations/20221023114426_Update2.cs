using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_FileDescriptions_PhotoId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_PhotoId",
                table: "Offers");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "Offers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "FileDescriptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_PhotoId",
                table: "Offers",
                column: "PhotoId",
                unique: true,
                filter: "[PhotoId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_FileDescriptions_PhotoId",
                table: "Offers",
                column: "PhotoId",
                principalTable: "FileDescriptions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_FileDescriptions_PhotoId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_PhotoId",
                table: "Offers");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "FileDescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_PhotoId",
                table: "Offers",
                column: "PhotoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_FileDescriptions_PhotoId",
                table: "Offers",
                column: "PhotoId",
                principalTable: "FileDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
