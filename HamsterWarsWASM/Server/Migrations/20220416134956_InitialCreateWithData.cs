using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsWASM.Server.Migrations
{
    public partial class InitialCreateWithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    HamsterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FavFood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loves = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Defeats = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.HamsterId);
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "HamsterId", "Age", "Defeats", "FavFood", "Games", "ImgName", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 2, 0, "", 0, "/images/hamsters/hamster-1.jpg", "", "Rasmus", 0 },
                    { 2, 2, 0, "", 0, "/images/hamsters/hamster-2.jpg", "", "Patrik", 0 },
                    { 3, 4, 0, "", 0, "/images/hamsters/hamster-3.jpg", "", "Pontus", 0 },
                    { 4, 7, 0, "", 0, "/images/hamsters/hamster-4.jpg", "", "Mikael", 0 },
                    { 5, 10, 0, "", 0, "/images/hamsters/hamster-5.jpg", "", "Claes", 0 },
                    { 6, 6, 0, "", 0, "/images/hamsters/hamster-6.jpg", "", "Jimmy", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hamsters");
        }
    }
}
