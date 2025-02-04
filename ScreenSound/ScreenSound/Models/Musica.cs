namespace ScreenSound.Models
{
    class Musica
    {
        public Musica(string nome, Banda artista)
        {
            Nome = nome;
            Artista = artista;
        }

        public string Nome { get; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string DescricaoResumida => $"A musica {Nome} é do artista {Artista}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}.");
            Console.WriteLine($"Artista: {Artista.Nome}.");
            Console.WriteLine($"Duracao: {Duracao}.");

            if (Disponivel)
                Console.WriteLine("Disponivel no plano.");
            else Console.WriteLine("Adquira o plano plus.");
        }
    }
}
