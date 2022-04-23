using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsWASM.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    HamsterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FavFood = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Loves = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Defeats = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.HamsterId);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinnerId = table.Column<int>(type: "int", nullable: false),
                    LoserId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchId);
                });

            migrationBuilder.CreateTable(
                name: "HamsterMatches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HamsterId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HamsterMatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HamsterMatches_Hamsters_HamsterId",
                        column: x => x.HamsterId,
                        principalTable: "Hamsters",
                        principalColumn: "HamsterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HamsterMatches_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "HamsterId", "Age", "Defeats", "Deleted", "FavFood", "Games", "ImgName", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 1, 0, false, "Pizza", 0, "/images/hamsters/hamster-9.jpg", "Hjulet", "Rasmus", 0 },
                    { 2, 2, 0, false, "Fika", 0, "/images/hamsters/hamster-8.jpg", "Meetings", "Jimmy", 0 },
                    { 3, 3, 0, false, "Pancakes", 0, "/images/hamsters/hamster-7.jpg", "Intellisense", "Claes", 0 },
                    { 4, 2, 0, false, "Korv", 0, "/images/hamsters/hamster-1.jpg", "Korvar", "Korven", 0 },
                    { 5, 2, 0, false, "Sallad", 0, "/images/hamsters/hamster-2.jpg", "Jumping", "Patrik", 0 },
                    { 6, 4, 0, false, "Bark", 0, "/images/hamsters/hamster-3.jpg", "Kvivksilver", "Pontus", 0 },
                    { 7, 7, 0, false, "Popcorn", 0, "/images/hamsters/hamster-4.jpg", "Berras Bio", "Mikael", 0 },
                    { 8, 10, 0, false, "Bark", 0, "/images/hamsters/hamster-5.jpg", "Träd", "Bävern", 0 },
                    { 9, 2, 0, false, "Blötmat", 0, "/images/hamsters/hamster-6.jpg", "Lekar", "Kattis", 0 },
                    { 10, 3, 0, false, "FUZEON", 0, "/images/hamsters/hamster-10.jpg", "Kids", "Hyaena", 0 },
                    { 11, 3, 0, false, "Sallad", 0, "/images/hamsters/hamster-11.jpg", "Lekar", "Kingfisher", 0 },
                    { 12, 4, 0, false, "Bark", 0, "/images/hamsters/hamster-12.jpg", "Hjulet", "Robin", 0 },
                    { 13, 1, 0, false, "Sallad", 0, "/images/hamsters/hamster-13.jpg", "Lekar", "Lynx", 0 },
                    { 14, 1, 0, false, "Bark", 0, "/images/hamsters/hamster-14.jpg", "Lekar", "Duck", 0 },
                    { 15, 2, 0, false, "Blötmat", 0, "/images/hamsters/hamster-15.jpg", "Hjulet", "Rhinoceros", 0 },
                    { 16, 3, 0, false, "Sallad", 0, "/images/hamsters/hamster-16.jpg", "Lekar", "Red", 0 },
                    { 17, 1, 0, false, "Bark", 0, "/images/hamsters/hamster-17.jpg", "Hjulet", "Gazelle", 0 },
                    { 18, 5, 0, false, "Sallad", 0, "/images/hamsters/hamster-18.jpg", "Lekar", "Dragon", 0 },
                    { 19, 4, 0, false, "Blötmat", 0, "/images/hamsters/hamster-19.jpg", "Lekar", "Lourie", 0 },
                    { 20, 3, 0, false, "Bark", 0, "/images/hamsters/hamster-20.jpg", "Hjulet", "Squirrel", 0 },
                    { 21, 2, 0, false, "Sallad", 0, "/images/hamsters/hamster-21.jpg", "Lekar", "Carmine", 0 },
                    { 22, 2, 0, false, "Popcorn", 0, "/images/hamsters/hamster-22.jpg", "Hjulet", "Snake", 0 },
                    { 23, 1, 0, false, "Sallad", 0, "/images/hamsters/hamster-23.jpg", "Lekar", "Bear", 0 },
                    { 24, 3, 0, false, "Bark", 0, "/images/hamsters/hamster-24.jpg", "Hjulet", "Chickadee", 0 },
                    { 25, 3, 0, false, "Sallad", 0, "/images/hamsters/hamster-25.jpg", "Lekar", "Vervet ", 0 },
                    { 26, 3, 0, false, "Bark", 0, "/images/hamsters/hamster-26.jpg", "Hjulet", "Malagasy ", 0 },
                    { 27, 3, 0, false, "Sallad", 0, "/images/hamsters/hamster-27.jpg", "Lekar", "Malleefowl", 0 },
                    { 28, 1, 0, false, "Bark", 0, "/images/hamsters/hamster-28.jpg", "Hjulet", "Desert", 0 },
                    { 29, 2, 0, false, "Popcorn", 0, "/images/hamsters/hamster-29.jpg", "Lekar", "Kaffir", 0 },
                    { 30, 1, 0, false, "Sallad", 0, "/images/hamsters/hamster-30.jpg", "Lekar", "Nubian ", 0 },
                    { 31, 2, 0, false, "Popcorn", 0, "/images/hamsters/hamster-31.jpg", "Hjulet", "Macaw", 0 },
                    { 32, 3, 0, false, "Blötmat", 0, "/images/hamsters/hamster-32.jpg", "Lekar", "Woodcock", 0 },
                    { 33, 4, 0, false, "Sallad", 0, "/images/hamsters/hamster-33.jpg", "Hjulet", "Eurasian", 0 },
                    { 34, 4, 0, false, "Gräs", 0, "/images/hamsters/hamster-34.jpg", "Lekar", "Mynah", 0 },
                    { 35, 4, 0, false, "Popcorn", 0, "/images/hamsters/hamster-35.jpg", "Lekar", "Sportive", 0 },
                    { 36, 3, 0, false, "Gräs", 0, "/images/hamsters/hamster-36.jpg", "Hjulet", "Marten", 0 },
                    { 37, 2, 0, false, "Sallad", 0, "/images/hamsters/hamster-37.jpg", "Lekar", "Malagasy", 0 },
                    { 38, 1, 0, false, "Popcorn", 0, "/images/hamsters/hamster-38.jpg", "Hjulet", "Grey ", 0 },
                    { 39, 1, 0, false, "Gräs", 0, "/images/hamsters/hamster-39.jpg", "Lekar", "Bear", 0 },
                    { 40, 2, 0, false, "Sallad", 0, "/images/hamsters/hamster-40.jpg", "Hjulet", "Four", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HamsterMatches_HamsterId",
                table: "HamsterMatches",
                column: "HamsterId");

            migrationBuilder.CreateIndex(
                name: "IX_HamsterMatches_MatchId",
                table: "HamsterMatches",
                column: "MatchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HamsterMatches");

            migrationBuilder.DropTable(
                name: "Hamsters");

            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
