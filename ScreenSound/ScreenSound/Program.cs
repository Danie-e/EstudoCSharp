
// Screen Sound



public class Program
{
    private static void Main(string[] args)
    {
        ExibirMenssagensDeBoasVindas();
        ExibirOpcoesDoMenu();
    }

    private static void ExibirOpcoesDoMenu()
    {
        Console.WriteLine("Digite 1 para registrar uma banda.");
        Console.WriteLine("Digite 2 para mostrar todas as bandas.");
        Console.WriteLine("Digite 3 para avaliar uma banda.");
        Console.WriteLine("Digite 4 para exibir a média de uma banda.");
        Console.WriteLine("Digite -1 para sair.");
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