using GameTop.Interfaces;

namespace GameTop.Lib
{
    public class Jogador1 : IJogador
    {
        private readonly string _nome;

        public Jogador1(string nome = "Douglas")
        {
            _nome = nome;
        }

        public string Chuta()
        {
            return $"{_nome} está chutando";
        }
        public string Corre()
        {
            return $"{_nome} está correndo";
        }
        public string Passa()
        {
            return $"{_nome} está passando";
        }

    }
}