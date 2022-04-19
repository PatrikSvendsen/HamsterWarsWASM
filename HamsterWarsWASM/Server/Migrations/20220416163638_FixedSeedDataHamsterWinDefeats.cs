using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsWASM.Server.Migrations
{
    public partial class FixedSeedDataHamsterWinDefeats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 1,
                columns: new[] { "Defeats", "Games" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 2,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 3,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 4,
                columns: new[] { "Defeats", "Games" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 5,
                columns: new[] { "Defeats", "Games" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 6,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 1,
                columns: new[] { "Defeats", "Games" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 2,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 3,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 4,
                columns: new[] { "Defeats", "Games" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 5,
                columns: new[] { "Defeats", "Games" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 6,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 0, 0 });
        }
    }
}
