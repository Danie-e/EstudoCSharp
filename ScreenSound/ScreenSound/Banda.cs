

namespace ScreenSound
{
    class Banda
    {
        public Banda(string nome)
        {
            Nome = nome;
        }

        public List<Album> albuns = new List<Album>();
        public string Nome { get; }
        private List<int> notas = new List<int>();

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

        internal void AdicionarNota(int nota)
        {
            notas.Add(nota);
        }

        internal object MediaNotas()
        {
            return notas.Average();
        }
    }
}
