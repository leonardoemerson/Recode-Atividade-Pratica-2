using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDMVC.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    idDestino = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    endereco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    preco = table.Column<double>(type: "float", nullable: false),
                    qtdVagas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.idDestino);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinos");
        }
    }
}
