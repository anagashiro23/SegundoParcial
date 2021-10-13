using Microsoft.EntityFrameworkCore.Migrations;

namespace SegundoParcialAndresNagashiro.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Naipes",
                columns: table => new
                {
                    naipe = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    carta = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naipes", x => x.naipe);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Naipes");
        }
    }
}
