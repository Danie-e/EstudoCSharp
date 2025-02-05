namespace ScreenSound.Models.Menus
{
    internal class MenuExibirMediaBanda : Menu
    {
        public override void Executar(List<Banda> listaBandas)
        {
            ExibirTituloDaOpcao(" Exibir no geral da banda. ");

            Console.Write("Digite o nome da banda que deseja saber a nota: ");
            string nomeBanda = Console.ReadLine()!;
            Banda bandaEscolhida = listaBandas.FirstOrDefault(new Banda(nomeBanda));
            if (bandaEscolhida != null)
            {
                Console.WriteLine($"A nota da banda é de {bandaEscolhida.Media} pontos.");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine($"A banda {nomeBanda} não foi econtrada. \nDigite uma tecla para voltar ao menu principar.");
                Console.ReadKey();
            }
        }
    }
}
