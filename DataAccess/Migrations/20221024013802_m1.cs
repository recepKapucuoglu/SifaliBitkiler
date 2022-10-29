using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bitkis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Acıklaması = table.Column<string>(nullable: true),
                    ResimUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitkis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SikayetEtkis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Etkisi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SikayetEtkis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SikayetEtkiBitki",
                columns: table => new
                {
                    BitkiId = table.Column<int>(nullable: false),
                    SikayetEtkiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SikayetEtkiBitki", x => new { x.SikayetEtkiId, x.BitkiId });
                    table.ForeignKey(
                        name: "FK_SikayetEtkiBitki_Bitkis_BitkiId",
                        column: x => x.BitkiId,
                        principalTable: "Bitkis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SikayetEtkiBitki_SikayetEtkis_SikayetEtkiId",
                        column: x => x.SikayetEtkiId,
                        principalTable: "SikayetEtkis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SikayetEtkiBitki_BitkiId",
                table: "SikayetEtkiBitki",
                column: "BitkiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SikayetEtkiBitki");

            migrationBuilder.DropTable(
                name: "Bitkis");

            migrationBuilder.DropTable(
                name: "SikayetEtkis");
        }
    }
}
