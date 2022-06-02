using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCoreDB.Migrations
{
    public partial class SecondStep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblOgrenciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true),
                    Soyad = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true),
                    Numara = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOgrenciler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblOgretmenler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOgretmenler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblOgrenciler_Numara",
                table: "tblOgrenciler",
                column: "Numara",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOgrenciler");

            migrationBuilder.DropTable(
                name: "tblOgretmenler");
        }
    }
}
