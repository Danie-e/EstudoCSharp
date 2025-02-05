namespace ScreenSound.Models
{
    internal class Album : IAvaliavel
    {
        public Album(string nome)
        {
            Nome = nome;
        }

        private List<Musica> Musicas = new List<Musica>();
        private List<Avaliacao> notas = new List<Avaliacao>();
        public string Nome { get; }
        public double Duracao => Musicas.Sum(x => x.Duracao);
        public double Media => notas.Count == 0 ? 0 : notas.Average(i => i.Nota);

        public void AdicionaMusica(Musica musica)
        {
            Musicas.Add(musica);
        }

        public void ExibirMusicasAlbum()
        {
            Console.WriteLine("Musicas do album: \n");
            foreach (var musica in Musicas)
            {
                musica.ExibirFichaTecnica();
                Console.WriteLine();
            }
            Console.WriteLine($"Para ouvir esse albun inteiro você precisa de {Duracao} minutos.");
        }

        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }
    }
}
