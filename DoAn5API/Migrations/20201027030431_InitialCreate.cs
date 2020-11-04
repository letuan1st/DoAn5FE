using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAn5API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phims",
                columns: table => new
                {
                    MaPhim = table.Column<string>(nullable: false),
                    TenPhim = table.Column<string>(nullable: true),
                    SoTap = table.Column<string>(nullable: true),
                    Nam = table.Column<int>(nullable: false),
                    Anh = table.Column<string>(nullable: true),
                    NoiDung = table.Column<string>(nullable: true),
                    LuotXem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phims", x => x.MaPhim);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phims");
        }
    }
}
