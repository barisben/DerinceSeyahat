using Microsoft.EntityFrameworkCore.Migrations;

namespace DerinceSeyahat.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Araclar",
                columns: table => new
                {
                    AracId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracMarka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AracModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AracKapasite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AracAdet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AracImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Araclar", x => x.AracId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Araclar");
        }
    }
}
