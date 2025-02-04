namespace ScreenSound.Models
{
    class Banda
    {
        public Banda(string nome)
        {
            Nome = nome;
        }

        public List<Album> albuns = new List<Album>();
        private List<int> notas = new List<int>();
        public string Nome { get; }
        public double Media => notas.Average();

        public void AdicionarAlbum(Album album)
        {
            albuns.Add(album);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            foreach (Album album in albuns)
            {
                Console.WriteLine($"Album: {album.Nome} ({album.Duracao})");
            }
        }

        public void AdicionarNota(int nota)
        {
            notas.Add(nota);
        }
    }
}
