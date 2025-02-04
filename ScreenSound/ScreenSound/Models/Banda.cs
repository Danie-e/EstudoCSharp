namespace ScreenSound.Models
{
    internal class Banda
    {
        public Banda(string nome)
        {
            Nome = nome;
        }

        private List<Avaliacao> notas = new List<Avaliacao>();
        public List<Album> Albuns = new List<Album>();
        public string Nome { get; }
        public double Media => notas.Count == 0 ? 0 : notas.Average(a => a.Nota);

        public void AdicionarAlbum(Album album)
        {
            Albuns.Add(album);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            foreach (Album album in Albuns)
            {
                Console.WriteLine($"Album: {album.Nome} ({album.Duracao})");
            }
        }

        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }
    }
}
