using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsWASM.Server.Migrations
{
    public partial class AddedPropToHamster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Editing",
                table: "Hamsters",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Editing",
                table: "Hamsters");
        }
    }
}
