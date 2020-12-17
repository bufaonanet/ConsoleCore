using GameTop.Interfaces;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;

        public JogoFoda(IJogador jogador1, IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            System.Console.WriteLine(_jogador1.Chuta());
            System.Console.WriteLine(_jogador1.Corre());
            System.Console.WriteLine(_jogador1.Passa());

            System.Console.WriteLine("Ooutro Jogado \n");

            System.Console.WriteLine(_jogador2.Chuta());
            System.Console.WriteLine(_jogador2.Corre());
            System.Console.WriteLine(_jogador2.Passa());
        }
    }
}