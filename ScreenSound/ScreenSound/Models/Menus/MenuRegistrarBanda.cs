namespace ScreenSound.Models.Menus
{
    class MenuRegistrarBanda : Menu
    {
        public override void Executar(List<Banda> listaBandas)
        {
            ExibirTituloDaOpcao(" Registrar Banda. ");

            Console.Write("Digite o nome da banda que deseja registrar:");
            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeDaBanda);
            listaBandas.Add(banda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(2000);
        }
    }
}
