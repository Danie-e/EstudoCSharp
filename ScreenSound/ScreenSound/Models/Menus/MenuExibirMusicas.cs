namespace ScreenSound.Models.Menus
{
    internal class MenuExibirMusicas : Menu
    {
        public override void Executar(List<Banda> listaBandas)
        {
            ExibirTituloDaOpcao(" Exibindo musicas registradas: ");

            Console.Write("Digite o nome do Album que deseja visualizar as Musicas: ");
            string nomeAlbum = Console.ReadLine()!;

            Banda bandaEscolhida = listaBandas.Find(i => i.Albuns.FirstOrDefault(i => i.Nome.Equals(nomeAlbum)) != null);

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
