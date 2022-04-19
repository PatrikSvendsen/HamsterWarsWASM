using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsWASM.Server.Migrations;

public partial class NewSeedDataMatches : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<int>(
            name: "MatchId",
            table: "Hamsters",
            type: "int",
            nullable: false,
            defaultValue: 0);

        migrationBuilder.CreateTable(
            name: "Matches",
            columns: table => new
            {
                MatchId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                WinnerId = table.Column<int>(type: "int", nullable: false),
                LoserId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Matches", x => x.MatchId);
            });

        migrationBuilder.InsertData(
            table: "Matches",
            columns: new[] { "MatchId", "LoserId", "WinnerId" },
            values: new object[] { 1, 1, 2 });

        migrationBuilder.InsertData(
            table: "Matches",
            columns: new[] { "MatchId", "LoserId", "WinnerId" },
            values: new object[] { 2, 4, 3 });

        migrationBuilder.InsertData(
            table: "Matches",
            columns: new[] { "MatchId", "LoserId", "WinnerId" },
            values: new object[] { 3, 5, 6 });

        migrationBuilder.UpdateData(
            table: "Hamsters",
            keyColumn: "HamsterId",
            keyValue: 1,
            column: "MatchId",
            value: 1);

        migrationBuilder.UpdateData(
            table: "Hamsters",
            keyColumn: "HamsterId",
            keyValue: 2,
            column: "MatchId",
            value: 1);

        migrationBuilder.UpdateData(
            table: "Hamsters",
            keyColumn: "HamsterId",
            keyValue: 3,
            column: "MatchId",
            value: 2);

        migrationBuilder.UpdateData(
            table: "Hamsters",
            keyColumn: "HamsterId",
            keyValue: 4,
            column: "MatchId",
            value: 2);

        migrationBuilder.UpdateData(
            table: "Hamsters",
            keyColumn: "HamsterId",
            keyValue: 5,
            column: "MatchId",
            value: 3);

        migrationBuilder.UpdateData(
            table: "Hamsters",
            keyColumn: "HamsterId",
            keyValue: 6,
            column: "MatchId",
            value: 3);

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

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Hamsters_Matches_MatchId",
            table: "Hamsters");

        migrationBuilder.DropTable(
            name: "Matches");

        migrationBuilder.DropIndex(
            name: "IX_Hamsters_MatchId",
            table: "Hamsters");

        migrationBuilder.DropColumn(
            name: "MatchId",
            table: "Hamsters");
    }
}
