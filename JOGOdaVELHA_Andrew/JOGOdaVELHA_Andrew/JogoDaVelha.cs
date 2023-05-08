using System.Linq;
using JogoDaVelha;




namespace JogoDaVelhaNamespace
{


    public class JogoDaVelha
    {
        private string[] tabuleiro = new string[9];
        private string jogadorAtual = "X";

        public JogoDaVelha()
        {
            IniciarNovoJogo();
        }

        public void IniciarNovoJogo()
        {
            for (int i = 0; i < tabuleiro.Length; i++)
            {
                tabuleiro[i] = "";
            }
        }

        public bool FazerJogada(int posicao)
        {
            if (tabuleiro[posicao] == "")
            {
                tabuleiro[posicao] = jogadorAtual;
                jogadorAtual = jogadorAtual == "X" ? "O" : "X";
                return true;
            }

            return false;
        }

        public bool VerificarVitoria()
        {
            int[][] combinacoesVitoriosas = new int[][]
            {
                new int[] { 0, 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8 },
                new int[] { 0, 3, 6 },
                new int[] { 1, 4, 7 },
                new int[] { 2, 5, 8 },
                new int[] { 0, 4, 8 },
                new int[] { 2, 4, 6 },
            };

            foreach (var combinacao in combinacoesVitoriosas)
            {
                if (tabuleiro[combinacao[0]] != "" &&
                    tabuleiro[combinacao[0]] == tabuleiro[combinacao[1]] &&
                    tabuleiro[combinacao[0]] == tabuleiro[combinacao[2]])
                {
                    return true;
                }
            }

            return false;
        }

        public bool VerificarEmpate()
        {
            return !tabuleiro.Any(c => c == "");
        }

        public string JogadorAtual
        {
            get { return jogadorAtual == "X" ? "O" : "X"; }
        }
    }
}

