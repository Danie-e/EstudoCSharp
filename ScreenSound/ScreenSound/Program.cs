

public class Program
{
    static List<string> listaBandas = new List<string>();

    private static void Main(string[] args)
    {
        listaBandas.Add("U2");
        listaBandas.Add("Beatles");
        listaBandas.Add("Lady Gaga");

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
                RegistrarBandas();
                break;
            case 2:
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
        Console.Clear();
        Console.WriteLine("Exibindo bandas registradas:\n");

        foreach (string nomeBanda in listaBandas)
            Console.WriteLine($"Banda {nomeBanda}");

        Console.WriteLine("\nDigite uma tecla paa voltar ao menu pricipal");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }

    private static void RegistrarBandas()
    {
        Console.Clear();
        Console.WriteLine("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar:");
        string nomeDaBanda = Console.ReadLine()!;
        listaBandas.Add(nomeDaBanda);
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
}