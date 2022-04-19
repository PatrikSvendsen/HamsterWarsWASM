using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsWASM.Server.Migrations
{
    public partial class FixedPropHamster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hamsters_Matches_MatchId",
                table: "Hamsters");

            migrationBuilder.DropIndex(
                name: "IX_Hamsters_MatchId",
                table: "Hamsters");

            migrationBuilder.AddColumn<int>(
                name: "HamsterId",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlName",
                table: "Matches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 1,
                column: "UrlName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 2,
                column: "UrlName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 3,
                column: "UrlName",
                value: "");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HamsterId",
                table: "Matches",
                column: "HamsterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Hamsters_HamsterId",
                table: "Matches",
                column: "HamsterId",
                principalTable: "Hamsters",
                principalColumn: "HamsterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Hamsters_HamsterId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_HamsterId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "HamsterId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "UrlName",
                table: "Matches");

            migrationBuilder.CreateIndex(
                name: "IX_Hamsters_MatchId",
                table: "Hamsters",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hamsters_Matches_MatchId",
                table: "Hamsters",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "MatchId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
