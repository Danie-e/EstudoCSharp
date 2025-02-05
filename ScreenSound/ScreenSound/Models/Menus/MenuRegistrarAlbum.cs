namespace ScreenSound.Models.Menus
{
    internal class MenuRegistrarAlbum : Menu
    {
        public override void Executar(List<Banda> listaBandas)
        {
            ExibirTituloDaOpcao(" Registrar Album. ");

            Console.Write("Digite o nome do album a ser registrado: ");
            string nomeAlbum = Console.ReadLine()!;
            Album album = new Album(nomeAlbum);
            Console.Write("A qual banda este album pertence: ");
            string nomeBanda = Console.ReadLine()!;
            Banda banda = listaBandas.FirstOrDefault(i => i.Nome.Equals(nomeBanda));
            if (banda != null)
            {
                banda.AdicionarAlbum(album);
                Console.WriteLine("Album cadastrado com sucesso.");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Não foi possivel registrar o Album, crie a banda primeiro.");
                Console.WriteLine("Digite qualquer valor para voltar ao menu principal...");
                Console.ReadKey();
            }
        }
    }
}
