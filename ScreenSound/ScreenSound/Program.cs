using ScreenSound;

public class Program
{
    static Dictionary<string, List<int>> dicionarioBandas = new Dictionary<string, List<int>>();

    private static void Main(string[] args)
    {
        Musica musica1 = new Musica()
        {
            nome = "Musica",
            artista = "teste",
            duracao = 201,
        };
        musica1.EscreveDisponivel(true);
        musica1.ExibirFichaTecnica();
    }


    //private static void Main(string[] args)
    //{
    //    dicionarioBandas.Add("U2", new List<int>() { 2,4,8});
    //    dicionarioBandas.Add("Beatles", new List<int>());
    //    dicionarioBandas.Add("Lady Gaga", new List<int>());

    //    ExibirOpcoesDoMenu();
    //}

    private static void ExibirOpcoesDoMenu()
    {
        Console.Clear();

        ExibirMenssagensDeBoasVindas();
        Console.WriteLine("Digite 1 para registrar uma banda.");
        Console.WriteLine("Digite 2 para mostrar todas as bandas.");
        Console.WriteLine("Digite 3 para avaliar uma banda.");
        Console.WriteLine("Digite 4 para exibir a média de uma banda.");
        Console.WriteLine("Digite -1 para sair.");

        Console.Write("\nDigite a sua opção: ");
        int opcaoEscolhida = int.Parse(Console.ReadLine()!);

        switch (opcaoEscolhida)
        {
            case 1:
                ExibirTituloDaOpcao(" Registro de bandas. ");
                RegistrarBandas();
                break;
            case 2:
                ExibirTituloDaOpcao(" Exibindo bandas registradas: ");
                ExibirBandas();
                break;
            case 3:
                ExibirTituloDaOpcao(" Avaliar banda. ");
                AvaliarBanda();
                break;
            case 4:
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
        if (dicionarioBandas.ContainsKey(nomeBanda))
        {
            List<int> notas = dicionarioBandas[nomeBanda];
            Console.WriteLine($"A nota da banda é de {notas.Average()} pontos.");
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
        string nomeBanda = Console.ReadLine();
        if (dicionarioBandas.ContainsKey(nomeBanda))
        {
            Console.Write("Digite uma nota para a banda: ");
            int nota = int.Parse(Console.ReadLine()!);
            dicionarioBandas[nomeBanda].Add(nota);
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

    private static void ExibirBandas()
    {
        foreach (string nomeBanda in dicionarioBandas.Keys)
            Console.WriteLine($"Banda {nomeBanda}");

        Console.WriteLine("\nDigite uma tecla paa voltar ao menu pricipal");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }

    private static void RegistrarBandas()
    {
        Console.Write("Digite o nome da banda que deseja registrar:");
        string nomeDaBanda = Console.ReadLine()!;
        dicionarioBandas.Add(nomeDaBanda, new List<int>());
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