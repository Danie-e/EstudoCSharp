namespace ScreenSound.Models.Menus
{
    internal class MenuExibirBandas : Menu
    {
        public override void Executar(List<Banda> listaBandas)
        {
            ExibirTituloDaOpcao(" Exibindo bandas registradas: ");

            Console.Write("Digite o nome do artista que deseja visualizar os albuns: ");
            string nomeArtista = Console.ReadLine()!;

            Banda bandaEscolhida = listaBandas.FirstOrDefault(i => i.Nome == nomeArtista);

            if (bandaEscolhida != null)
            {
                foreach (Album album in bandaEscolhida.Albuns)
                {
                    album.ExibirMusicasAlbum();
                    Thread.Sleep(4000);
                }
            }
            else
            {
                Console.WriteLine("\n Não foi possivel encontrar o Artista desejado.");
                Console.WriteLine("Digite qualquer valor para voltar ao menu principal...");
                Console.ReadKey();
            }
        }

    }
}
