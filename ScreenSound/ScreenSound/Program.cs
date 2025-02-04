using ScreenSound;

public class Program
{
    static List<Banda> listaBandas = new List<Banda>();


    private static void Main(string[] args)
    {
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
        Console.WriteLine("Digite 4 para mostrar todas as bandas de um artista.");
        Console.WriteLine("Digite 5 para mostrar todas as musicas de uma banda.");
        Console.WriteLine("Digite 6 para avaliar uma musica.");
        Console.WriteLine("Digite 7 para exibir a média de uma banda.");
        Console.WriteLine("Digite -1 para sair.");

        Console.Write("\nDigite a sua opção: ");
        int opcaoEscolhida = int.Parse(Console.ReadLine()!);

        switch (opcaoEscolhida)
        {
            case 1:
                ExibirTituloDaOpcao(" Registrar Banda. ");
                RegistrarBandas();
                break;
            case 2:
                ExibirTituloDaOpcao(" Registrar Album. ");
                RegistrarAlbum();
                break;
            case 3:
                ExibirTituloDaOpcao(" Registrar Musica. ");
                RegistrarMusica();
                break;
            case 4:
                ExibirTituloDaOpcao(" Exibindo bandas registradas: ");
                ExibirBandas();
                break;
            case 5:
                ExibirTituloDaOpcao(" Exibindo musicas registradas: ");
                ExibirMusicas();
                break;
            case 6:
                ExibirTituloDaOpcao(" Avaliar musica. ");
                AvaliarBanda();
                break;
            case 7:
                ExibirTituloDaOpcao(" Exibir no geral da banda. ");
                ExibirMediaBanda();
                break;
            case -1:
                Console.WriteLine($"Tchau tchau!");
                Thread.Sleep(1000);
                break;
            default:
                Console.WriteLine("Valor digitado é invalido.");
                ExibirOpcoesDoMenu();
                break;
        }
    }


    private static void ExibirMediaBanda()
    {
        Console.Write("Digite o nome da banda que deseja saber a nota: ");
        string nomeBanda = Console.ReadLine()!;
        Banda bandaEscolhida = listaBandas.FirstOrDefault(new Banda(nomeBanda));
        if (bandaEscolhida != null)
        {
            Console.WriteLine($"A nota da banda é de {bandaEscolhida.MediaNotas()} pontos.");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine($"A banda {nomeBanda} não foi econtrada. \nDigite uma tecla para voltar ao menu principar.");
            Console.ReadKey();
        }
        ExibirOpcoesDoMenu();
    }

    private static void AvaliarBanda()
    {
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;
        Banda bandaEscolhida = listaBandas.FirstOrDefault(new Banda(nomeBanda));
        if (bandaEscolhida != null)
        {
            Console.Write("Digite uma nota para a banda: ");
            int nota = int.Parse(Console.ReadLine()!);
            bandaEscolhida.AdicionarNota(nota);
            Console.WriteLine($"A nota {nota} foi atribuida com sucesso para a banda {nomeBanda}");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine($"A banda {nomeBanda} não foi registrada. \nDigite uma tecla para voltar ao menu principar.");
            Console.ReadKey();
        }
        ExibirOpcoesDoMenu();
    }
    private static void ExibirMusicas()
    {
        Console.Write("Digite o nome do Album que deseja visualizar as Musicas: ");
        string nomeAlbum = Console.ReadLine()!;

        Banda bandaEscolhida = listaBandas.Find(i => i.albuns.FirstOrDefault(i => i.Nome.Equals(nomeAlbum)) != null);

        if (bandaEscolhida != null)
        {
            foreach (Album album in bandaEscolhida.albuns)
            {
                album.ExibirMusicasAlbum();
                Thread.Sleep(4000);
                ExibirOpcoesDoMenu();
            }
        }
        else
        {
            Console.WriteLine("\n Não foi possivel encontrar o Artista desejado.");
            Console.WriteLine("Digite qualquer valor para sair...");
            Console.ReadKey();
            ExibirOpcoesDoMenu();
        }
    }
    private static void ExibirBandas()
    {
        Console.Write("Digite o nome do artista que deseja visualizar os albuns: ");
        string nomeArtista = Console.ReadLine()!;

        Banda bandaEscolhida = listaBandas.FirstOrDefault(i => i.Nome == nomeArtista);

        if (bandaEscolhida != null)
        {
            foreach (Album album in bandaEscolhida.albuns)
            {
                album.ExibirMusicasAlbum();
                Thread.Sleep(4000);
                ExibirOpcoesDoMenu();
            }
        }
        else
        {
            Console.WriteLine("\n Não foi possivel encontrar o Artista desejado.");
            Console.WriteLine("Digite qualquer valor para sair...");
            Console.ReadKey();
            ExibirOpcoesDoMenu();
        }
    }

    private static void RegistrarMusica()
    {
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
            Album album = banda.albuns.FirstOrDefault(i => i.Nome.Equals(nomeAlbum));

            if (album != null)
            {
                album.AdicionaMusica(musica);
                Console.WriteLine("Banda musica com sucesso.");
                Thread.Sleep(2000);
                ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine("Não foi possivel registra a musica, crie o album primeiro.");
                Console.WriteLine("Digite qualquer valor para sair...");
                Console.ReadKey();
            }

        }
        else
        {
            Console.WriteLine("Não foi possivel registra a musica, crie a banda primeiro.");
            Console.WriteLine("Digite qualquer valor para sair...");
            Console.ReadKey();
        }
    }

    private static void RegistrarAlbum()
    {
        Console.Write("Digite o nome do album a ser registrado: ");
        string nomeAlbum = Console.ReadLine()!;
        Album album = new Album(nomeAlbum);
        Console.Write("A qual banda este album pertence: ");
        string nomeBanda = Console.ReadLine()!;
        Banda banda = listaBandas.FirstOrDefault(i => i.Nome.Equals(nomeBanda));
        if (banda != null)
        {
            banda.AdicionarAlbum(album);
            Console.WriteLine("Album cadastrada com sucesso.");
            Thread.Sleep(2000);
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine("Não foi possivel registra o Album, crie a banda primeiro.");
            Console.WriteLine("Digite qualquer valor para sair...");
            Console.ReadKey();
        }
    }

    private static void RegistrarBandas()
    {
        Console.Write("Digite o nome da banda que deseja registrar:");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        listaBandas.Add(banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);

        ExibirOpcoesDoMenu();
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

    private static void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

        Console.Clear();

        Console.WriteLine(asteriscos);
        Console.WriteLine($"{titulo}\n");
        Console.WriteLine(asteriscos);

    }
}