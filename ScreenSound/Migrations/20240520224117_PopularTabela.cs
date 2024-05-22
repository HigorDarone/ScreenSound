using Microsoft.EntityFrameworkCore.Migrations;
using static System.Net.WebRequestMethods;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio"  }, new object[] {"Froid","https://www.google.com/url?sa=i&url=https%3A%2F%2Fuhuu.com%2Fevento%2Frs%2Fporto-alegre%2Fvictor-leo-12399&psig=AOvVaw2VtHE9-hbAzGoGA6wrvFv7&ust=1715814319084000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCMDwrMugjoYDFQAAAAAdAAAAABAE","Renato Alves Menezes Barreto mais conhecido pelo seu nome artístico Froid é um rapper nascido em Belo Horizonte no ano de 1993. Froid possui um disco de ouro pelo single SK8 do Matheus com Rodrigo Cartier, e 2x disco de platina pelo single Lamentável III com Cynthia Luz."});

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio" }, new object[] { "Pitty", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fuhuu.com%2Fevento%2Frs%2Fporto-alegre%2Fvictor-" +
                "leo-12399&psig=AOvVaw2VtHE9-hbAzGoGA6wrvFv7&ust=1715814319084000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCMDwrMugjoYDFQAAAAAdAAAAABAE",
                "Pitty, cujo nome real é Priscilla Novaes Leone, é uma cantora, compositora e instrumentista brasileira nascida em" +
                " 7 de outubro de 1977 em Salvador, Bahia. Ela é conhecida por sua mistura de rock alternativo com influências de música brasileira e punk" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio" }, new object[] { "Matuê", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fuhuu.com%2Fevento" +
                "%2Frs%2Fporto-alegre%2Fvictor-leo-12399&psig=AOvVaw2VtHE9-hbAzGoGA6wrvFv7&ust=171581431908400" +
                "0&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCMDwrMugjoYDFQAAAAAdAAAAABAE",
                "Matheus Brasileiro, mais conhecido como Matuê, é um rapper e cantor brasileiro" +
                " nascido em 18 de outubro de 1998 em Recife, Pernambuco. Ele ganhou destaque na cena" +
                " do trap nacional com suas letras marcantes e batidas envolventes." });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio" }, new object[] { "Veigh", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fuhuu.com" +
                "%2Fevento%2Frs%2Fporto-alegre%2Fvictor-leo-12399&psig=AOvVaw2VtHE9-hbAzGoGA6wrvFv7&ust=" +
                "1715814319084000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCMDwrMugjoYDFQAAAAAdAAAAABAE",
                "Veigh, cujo nome real é Victor Gabriel Rodrigues de Oliveira, é um cantor e compositor brasileiro" +
                " nascido em 25 de agosto de 1995 em São Paulo, São Paulo. Ele é reconhecido por suas músicas que mesclam" +
                " diferentes gêneros, como R&B, trap e pop." });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio" }, new object[] { "JovemDex", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fuhuu.com" +
                "%2Fevento%2Frs%2Fporto-alegre%2Fvictor-leo-12399&psig=AOvVaw2VtHE9-" +
                "hbAzGoGA6wrvFv7&ust=1715814319084000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCMDwrMugjoYDFQAAAAAdAAAAABAE",
                "JovemDex é o nome artístico de Lucas Felix, um rapper brasileiro conhecido " +
                "por suas letras irreverentes e humorísticas. Pouco se sabe sobre sua biografia pessoal," +
                " já que ele tende a manter uma persona misteriosa." });


         
          
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
            
        }
    }
}
