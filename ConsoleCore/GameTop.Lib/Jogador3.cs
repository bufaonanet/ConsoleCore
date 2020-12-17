using GameTop.Interfaces;

namespace GameTop.Lib
{
    public class Jogador3 : IJogador
    {

        public string Chuta()
        {
            return "Jogador de Teste está chutando";
        }
        public string Corre()
        {
            return "Jogador de Teste está correndo";
        }
        public string Passa()
        {
            return "Jogador de Teste está passando";
        }

    }
}