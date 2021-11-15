using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Data.Migrations
{
    public partial class Artice_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Chantier_Article_CTN_ID",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_Article_CTN_ID",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "Article_CTN_ID",
                table: "Article");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Article_CTN_ID",
                table: "Article",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Article_Article_CTN_ID",
                table: "Article",
                column: "Article_CTN_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Chantier_Article_CTN_ID",
                table: "Article",
                column: "Article_CTN_ID",
                principalTable: "Chantier",
                principalColumn: "Ctn_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
