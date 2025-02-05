namespace ScreenSound.Models.Menus
{
    internal class MenuRegistrarMusica : Menu
    {
        public override void Executar(List<Banda> listaBandas)
        {
            ExibirTituloDaOpcao(" Registrar Musica. ");

            Console.Write("Digite o nome do musica a ser registrado: ");
            string nomeMusica = Console.ReadLine()!;

            Console.Write("A qual banda este musica pertence: ");
            string nomeBanda = Console.ReadLine()!;
            Banda banda = listaBandas.FirstOrDefault(i => i.Nome.Equals(nomeBanda));

            if (banda != null)
            {
                Musica musica = new Musica(nomeMusica, banda);
                Console.Write("Digite o nome do album que a musica pertence: ");
                string nomeAlbum = Console.ReadLine()!;
                Album album = banda.Albuns.FirstOrDefault(i => i.Nome.Equals(nomeAlbum));

                if (album != null)
                {
                    album.AdicionaMusica(musica);
                    Console.WriteLine("Banda musica com sucesso.");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Não foi possivel registra a musica, crie o album primeiro.");
                    Console.WriteLine("Digite qualquer valor para voltar ao menu principal...");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("Não foi possivel registra a musica, crie a banda primeiro.");
                Console.WriteLine("Digite qualquer valor para voltar ao menu principal...");
                Console.ReadKey();
            }
        }


    }
}
