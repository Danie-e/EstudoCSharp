namespace ScreenSound
{
    class Musica
    {
        public string Nome { get; set; } = string.Empty;
        public string Artista { get; set; } = string.Empty;
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string DescricaoResumida => $"A musica {Nome} é do artista {Artista}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}.");
            Console.WriteLine($"Artista: {Artista}.");
            Console.WriteLine($"Duracao: {Duracao}.");

            if (Disponivel)
                Console.WriteLine("Disponivel no plano.");
            else Console.WriteLine("Adquira o plano plus.");
        }
    }
}
