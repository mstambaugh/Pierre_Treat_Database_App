using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PierreTreats.Migrations
{
    public partial class Authorization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Flavors_FlavorId1",
                table: "FlavorTreat");

            migrationBuilder.DropIndex(
                name: "IX_FlavorTreat_FlavorId1",
                table: "FlavorTreat");

            migrationBuilder.DropColumn(
                name: "FlavorId1",
                table: "FlavorTreat");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Treats",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FlavorId",
                table: "Flavors",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Flavors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treats_UserId",
                table: "Treats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FlavorTreat_FlavorId",
                table: "FlavorTreat",
                column: "FlavorId");

            migrationBuilder.CreateIndex(
                name: "IX_Flavors_UserId",
                table: "Flavors",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flavors_AspNetUsers_UserId",
                table: "Flavors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Flavors_FlavorId",
                table: "FlavorTreat",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flavors_AspNetUsers_UserId",
                table: "Flavors");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Flavors_FlavorId",
                table: "FlavorTreat");

            migrationBuilder.DropForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats");

            migrationBuilder.DropIndex(
                name: "IX_Treats_UserId",
                table: "Treats");

            migrationBuilder.DropIndex(
                name: "IX_FlavorTreat_FlavorId",
                table: "FlavorTreat");

            migrationBuilder.DropIndex(
                name: "IX_Flavors_UserId",
                table: "Flavors");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Flavors");

            migrationBuilder.AddColumn<string>(
                name: "FlavorId1",
                table: "FlavorTreat",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FlavorId",
                table: "Flavors",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_FlavorTreat_FlavorId1",
                table: "FlavorTreat",
                column: "FlavorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Flavors_FlavorId1",
                table: "FlavorTreat",
                column: "FlavorId1",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
