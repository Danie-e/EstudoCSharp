namespace ScreenSound
{
    class Musica
    {
        public string nome;
        public string artista;
        public int duracao;
        private bool disponivel;

        public void EscreveDisponivel(bool value)
        {
            disponivel = value;
        }
        public bool EscreveDisponivel()
        {
            return disponivel;
        }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($@"
Nome: {nome}.
Artista: {artista}.
Duracao: {duracao}.");
            if (disponivel)
                Console.WriteLine("Disponivel no plano.");
            else Console.WriteLine("Adquira o plano plus.");
        }
    }
}
