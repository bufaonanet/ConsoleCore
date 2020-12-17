using GameTop.Interfaces;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {

        public string Chuta()
        {
            return "Jogador 2 está chutando";
        }
        public string Corre()
        {
            return "Jogador 2 está correndo";
        }
        public string Passa()
        {
            return "Jogador 2 está passando";
        }

    }
}