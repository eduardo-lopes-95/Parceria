using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parceria.Data.Migrations
{
    public partial class _1thMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Convites",
                columns: table => new
                {
                    ConviteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmailDestinatario = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    WalletRemetente = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Link = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convites", x => x.ConviteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Convites");
        }
    }
}
