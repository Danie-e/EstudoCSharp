﻿namespace ScreenSound
{
    class Album
    {
        private List<Musica> Musicas = new List<Musica>();
        public string Nome { get; set; }
        public double Duracao => Musicas.Sum(x => x.Duracao);

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
    }
}
