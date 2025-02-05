using ScreenSound.Models;
using ScreenSound.Models.Menus;

public class Program
{
    static List<Banda> listaBandas = new List<Banda>();
    static Dictionary<int, Menu> menu = new Dictionary<int, Menu>();

    private static void Main(string[] args)
    {
        Banda banda = new Banda("Banda Teste");
        Musica musica = new Musica("Musica Teste", banda);
        Album album = new Album("Album Teste");
        menu.Add(1, new MenuRegistrarBanda());
        menu.Add(2, new MenuRegistrarAlbum());
        menu.Add(3, new MenuRegistrarMusica());
        menu.Add(4, new MenuExibirBandas());
        menu.Add(5, new MenuExibirMusicas());
        menu.Add(6, new MenuAvaliarBanda());
        menu.Add(7, new MenuExibirMediaBanda());

        album.AdicionaMusica(musica);
        banda.AdicionarAlbum(album);
        banda.AdicionarNota(new Avaliacao(2));
        banda.AdicionarNota(new Avaliacao(4));
        listaBandas.Add(banda);

        ExibirMenssagensDeBoasVindas();
        ExibirOpcoesDoMenu();
    }

    private static void ExibirOpcoesDoMenu()
    {
        Console.Clear();

        ExibirMenssagensDeBoasVindas();
        Console.WriteLine("Digite 1 para registrar uma Banda.");
        Console.WriteLine("Digite 2 para registrar uma Album.");
        Console.WriteLine("Digite 3 para registrar uma Musica.");
        Console.WriteLine("Digite 4 para mostrar todas os albuns de um artista.");
        Console.WriteLine("Digite 5 para mostrar todas as musicas de uma banda.");
        Console.WriteLine("Digite 6 para avaliar uma banda.");
        Console.WriteLine("Digite 7 para exibir a média de uma banda.");
        Console.WriteLine("Digite -1 para sair.");

        Console.Write("\nDigite a sua opção: ");
        int opcaoEscolhida = int.Parse(Console.ReadLine()!);

        if (menu.ContainsKey(opcaoEscolhida))
        {
            Menu menuEscolhido = menu[opcaoEscolhida];
            menuEscolhido.Executar(listaBandas);
            ExibirOpcoesDoMenu();
        }
        else if (opcaoEscolhida == -1)
            return;
        else
        {
            Console.WriteLine("Opção escolhida é invalida.");
            Thread.Sleep(2000);
            ExibirOpcoesDoMenu();
        }
    }

    private static void ExibirMenssagensDeBoasVindas()
    {
        string mensagemdeBoasVindas = @"

 ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
 ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
 ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
 ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
 ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
 ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
";
        Console.WriteLine(mensagemdeBoasVindas);
        Console.WriteLine("Boas vindas ao Screen Sound!\n");

    }
}