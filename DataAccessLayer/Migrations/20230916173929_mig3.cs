using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "Commets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Commets_BlogID",
                table: "Commets",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Commets_Blogs_BlogID",
                table: "Commets",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commets_Blogs_BlogID",
                table: "Commets");

            migrationBuilder.DropIndex(
                name: "IX_Commets_BlogID",
                table: "Commets");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Commets");
        }
    }
}
