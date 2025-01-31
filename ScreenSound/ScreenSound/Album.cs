namespace ScreenSound
{
    class Album
    {
        private List<Musica> Musicas = new List<Musica>();
        public string Nome { get; set; }
        public double Duracao { get; set; }

        public void AdicionaMusica(Musica musica)
        {
            Musicas.Add(musica);
        }
    }
}
