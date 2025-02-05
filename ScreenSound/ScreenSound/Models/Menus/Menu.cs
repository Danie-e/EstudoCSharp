namespace ScreenSound.Models.Menus
{
    internal class Menu
    {

        public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

            Console.Clear();

            Console.WriteLine(asteriscos);
            Console.WriteLine($"{titulo}\n");
            Console.WriteLine(asteriscos);

        }
        public virtual void Executar(List<Banda> listaBandas) { }
    }
}
