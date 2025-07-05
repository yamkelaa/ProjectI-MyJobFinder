using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewTableFKFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TargetWebsites_UserId",
                table: "TargetWebsites",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TargetWebsites_Users_UserId",
                table: "TargetWebsites",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TargetWebsites_Users_UserId",
                table: "TargetWebsites");

            migrationBuilder.DropIndex(
                name: "IX_TargetWebsites_UserId",
                table: "TargetWebsites");
        }
    }
}
