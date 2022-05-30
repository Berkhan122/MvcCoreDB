using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCoreDB.Migrations
{
    public partial class FirstStep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblOgrenciler",
                columns: table => new
                {
                    ogrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ogrName = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true),
                    ogrSurname = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOgrenciler", x => x.ogrId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOgrenciler");
        }
    }
}
