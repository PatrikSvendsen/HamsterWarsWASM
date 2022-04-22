using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsWASM.Server.Migrations
{
    public partial class FixedMatchProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HamsterMatch");

            migrationBuilder.AddColumn<int>(
                name: "HamsterId",
                table: "Matches",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "HamsterMatch",
                columns: table => new
                {
                    MatchHamstersId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HamsterMatch", x => new { x.MatchHamstersId, x.MatchId });
                    table.ForeignKey(
                        name: "FK_HamsterMatch_Hamsters_MatchHamstersId",
                        column: x => x.MatchHamstersId,
                        principalTable: "Hamsters",
                        principalColumn: "HamsterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HamsterMatch_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HamsterMatch_MatchId",
                table: "HamsterMatch",
                column: "MatchId");
        }
    }
}
