using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Anos luz", 2017 });
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Bala", 2022 });
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Na Sua Estante", 2005 });
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Engana Dizendo Que Ama", 2023 });
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Money Rain ", 2022 });

           

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Musica");
        }
    }
}
