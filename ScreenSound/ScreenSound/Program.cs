

using Microsoft.Win32;

public class Program
{
    static Dictionary<string, List<int>> dicionarioBandas = new Dictionary<string, List<int>>();

    private static void Main(string[] args)
    {
        dicionarioBandas.Add("U2",new List<int>());
        dicionarioBandas.Add("Beatles", new List<int>());
        dicionarioBandas.Add("Lady Gaga", new List<int>());

        ExibirOpcoesDoMenu();
    }

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
                ExibirTituloDaOpcao(" Registro de bandas ");
                RegistrarBandas();
                break;
            case 2:
                ExibirTituloDaOpcao(" Exibindo bandas registradas: ");
                ExibirBandas();
                break;
            case 3:
                Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
                break;
            case 4:
                Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
                break;
            case -1:
                Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
                break;
            default:
                Console.WriteLine("Valor digitado é invalido.");
                ExibirOpcoesDoMenu();
                break;
        }
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