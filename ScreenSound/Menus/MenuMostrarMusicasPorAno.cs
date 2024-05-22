using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuMostrarMusicasPorAno:Menu
    {
       public override void Executar(DAL<Artista> artistaDAL)
        {
            base.Executar(artistaDAL);
            ExibirTituloDaOpcao("Exibir musicas por ano de lancamento");
            Console.WriteLine("Digite o Ano de lancamento das musicas que deseja ouvir");
            string Anolancamento  = Console.ReadLine()!;
            var musicaDAL = new DAL<Musica>(new ScreenSoundContext());
            var MusicasPorAno = musicaDAL.RecuperarPorAno(a => a.AnoLancamento == Convert.ToInt32(Anolancamento)).ToList();

            if(MusicasPorAno.Any())
            {

                Console.WriteLine($"\nMusica pelo ano de {Anolancamento}");
                foreach(var musica in MusicasPorAno)
                {
                    musica.ExibirFichaTecnica();
                }
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nMusicas do ano {MusicasPorAno} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
