namespace ScreenSound.Models.Menus
{
    internal class MenuAvaliarBanda : Menu
    {
        public override void Executar(List<Banda> listaBandas)
        {
            ExibirTituloDaOpcao(" Avaliar musica. ");

            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeBanda = Console.ReadLine()!;
            Banda bandaEscolhida = listaBandas.FirstOrDefault(new Banda(nomeBanda));
            if (bandaEscolhida != null)
            {
                Console.Write("Digite uma nota para a banda: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                bandaEscolhida.AdicionarNota(nota);
                Console.WriteLine($"A nota {nota.Nota} foi atribuida com sucesso para a banda {nomeBanda}");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine($"A banda {nomeBanda} não foi registrada. \nDigite uma tecla para voltar ao menu principar.");
                Console.ReadKey();
            }
        }
    }
}
