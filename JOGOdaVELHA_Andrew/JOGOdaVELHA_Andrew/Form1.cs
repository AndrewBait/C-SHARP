using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using JogoDaVelhaNamespace;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        private bool jogador1 = true;
        private int jogadas = 0;

        JogoDaVelhaNamespace.JogoDaVelha jogo = new JogoDaVelhaNamespace.JogoDaVelha();

        public Form1()
        {
            InitializeComponent();
        }

        private List<Jogador> jogadores = new List<Jogador>();
        private string arquivoJogadores = "jogadores.txt";
        private bool jogarContraComputador = false;
        private Random random = new Random();

        public class Jogador
        {
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public int Vitorias { get; set; }
        }

        private void SalvarJogadores()
        {
            using (StreamWriter sw = new StreamWriter(arquivoJogadores))
            {
                foreach (var jogador in jogadores)
                {
                    sw.WriteLine($"{jogador.Nome},{jogador.Cpf},{jogador.Vitorias}");
                }
            }
        }

        private bool ValidarCpf(string cpf)
        {
            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            for (int i = 0; i < 10; i++)
            {
                if (cpf == new string(i.ToString()[0], 11))
                    return false;
            }

            int[] firstMultiplier = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] secondMultiplier = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int sum = 0;

            for (int i = 0; i < 9; i++)
                sum += int.Parse(tempCpf[i].ToString()) * firstMultiplier[i];

            int result = sum % 11;
            result = result < 2 ? 0 : 11 - result;

            tempCpf += result.ToString();

            sum = 0;
            for (int i = 0; i < 10; i++)
                sum += int.Parse(tempCpf[i].ToString()) * secondMultiplier[i];

            result = sum % 11;
            result = result < 2 ? 0 : 11 - result;

            tempCpf += result.ToString();

            return cpf == tempCpf;

        }

        private void AtualizarVitorias(string nome)
        {
            var jogador = jogadores.FirstOrDefault(p => p.Nome == nome);

            if (jogador != null)
            {
                jogador.Vitorias++;

                foreach (DataGridViewRow row in dataGridViewRanking.Rows)
                {
                    if (row.Cells["Nome"].Value.ToString() == jogador.Nome)
                    {
                        int vitoriasAtuais = Convert.ToInt32(row.Cells["Vitorias"].Value);
                        row.Cells["Vitorias"].Value = vitoriasAtuais + 1;
                        break;
                    }
                }

                SalvarJogadores();
            }
        }

        private void CarregarJogadores()
        {
            if (File.Exists(arquivoJogadores))
            {
                using (StreamReader sr = new StreamReader(arquivoJogadores))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        jogadores.Add(new Jogador { Nome = data[0], Cpf = data[1], Vitorias = int.Parse(data[2]) });
                    }
                }
            }
        }

        private void FazerJogadaComputador()
        {
            List<Button> botoesDisponiveis = new List<Button>();

            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button && ctrl.Name.StartsWith("button") && ctrl.Text == "")
                {
                    botoesDisponiveis.Add((Button)ctrl);
                }
            }

            if (botoesDisponiveis.Count > 0)
            {
                int indice = random.Next(botoesDisponiveis.Count);
                Button btn = botoesDisponiveis[indice];
                btn.Text = "O";
                btn.ForeColor = Color.Blue;

                jogador1 = !jogador1;
                jogadas++;

                VerificarVitoria();
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (jogador1)
            {
                btn.Text = "X";
                btn.ForeColor = Color.Red;
            }
            else
            {
                btn.Text = "O";
                btn.ForeColor = Color.Blue;
            }

            int posicao = int.Parse(btn.Name.Replace("button", "")) - 1;
            if (jogo.FazerJogada(posicao))
            {
                btn.Enabled = false;
                jogadas++;
            }

            if (!VerificarVitoria()) //Se não houve vitória, é a vez do computador
            {
                FazerJogadaComputador();
                jogador1 = !jogador1;
            }
        }



        private void FinalizarJogo(string mensagem)
        {
            lblStatus.Text = mensagem;
            lblStatus.Visible = true;

            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button && ctrl.Name.StartsWith("button"))
                {
                    ((Button)ctrl).Enabled = false;
                }
            }
        }

        private void BtnNovoJogo_Click_1(object sender, EventArgs e)
        {
            jogadas = 0;
            jogo.IniciarNovoJogo();
            lblStatus.Visible = false;

            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button && ctrl.Name.StartsWith("button"))
                {
                    ((Button)ctrl).Text = "";
                    ((Button)ctrl).ForeColor = Color.Black;
                    ((Button)ctrl).Enabled = true;
                }
            }
        }
        private bool VerificarVitoria()
        {
            bool vitoria = false;

            // Verifica linhas
            for (int i = 1; i <= 3; i++)
            {
                if (Controls.ContainsKey("button" + ((i - 1) * 3 + 1)) &&
                    Controls.ContainsKey("button" + ((i - 1) * 3 + 2)) &&
                    Controls.ContainsKey("button" + ((i - 1) * 3 + 3)) &&
                    Controls["button" + ((i - 1) * 3 + 1)].Text != "" &&
                    Controls["button" + ((i - 1) * 3 + 1)].Text == Controls["button" + ((i - 1) * 3 + 2)].Text &&
                    Controls["button" + ((i - 1) * 3 + 2)].Text == Controls["button" + ((i - 1) * 3 + 3)].Text)
                {
                    vitoria = true;
                }
            }

            // Verifica colunas
            for (int i = 1; i <= 3; i++)
            {
                if (Controls.ContainsKey("button" + i) &&
                    Controls.ContainsKey("button" + (i + 3)) &&
                    Controls.ContainsKey("button" + (i + 6)) &&
                    Controls["button" + i].Text != "" &&
                    Controls["button" + i].Text == Controls["button" + (i + 3)].Text &&
                    Controls["button" + (i + 3)].Text == Controls["button" + (i + 6)].Text)
                {
                    vitoria = true;
                }
            }

            // Verifica diagonais
            if (Controls.ContainsKey("button1") &&
                Controls.ContainsKey("button5") &&
                Controls.ContainsKey("button9") &&
                Controls["button1"].Text != "" &&
                Controls["button1"].Text == Controls["button5"].Text &&
                Controls["button5"].Text == Controls["button9"].Text)
            {
                vitoria = true;
            }

            if (Controls.ContainsKey("button3") &&
                Controls.ContainsKey("button5") &&
                Controls.ContainsKey("button7") &&
                Controls["button3"].Text != "" &&
                Controls["button3"].Text == Controls["button5"].Text &&
                Controls["button5"].Text == Controls["button7"].Text)
            {
                vitoria = true;
            }


            if (vitoria)
            {
                string vencedor = VerificarVitoria() ? (jogador1 ? "O" : "X") : "";
                MessageBox.Show($"Parabéns, jogador {vencedor}! Você venceu!", "Vitória!");
                DesabilitarBotoes();
                return true;
            }
            else if (jogo.VerificarEmpate())
            {
                MessageBox.Show("Empate!", "Empate!");
                return true;
            }

            return false;
        }


        private void DesabilitarBotoes()
        {
            for (int i = 1; i <= 9; i++)
            {
                Controls["button" + i].Enabled = false;
            }
        }


        // (Eventos de clique dos botões, que chamam Button_Click)

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            jogarContraComputador = checkBox1.Checked;
        }

        private void exibirRankingButton_Click(object sender, EventArgs e)
        {
            dataGridViewRanking.Rows.Clear();
            var jogadoresOrdenados = jogadores.OrderByDescending(p => p.Vitorias).Take(10);
            foreach (var jogador in jogadoresOrdenados)
            {
                dataGridViewRanking.Rows.Add(jogador.Nome, jogador.Cpf, jogador.Vitorias);
            }
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            string nome = nomeBox.Text;
            string cpf = cpfBox.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || !ValidarCpf(cpf))
            {
                MessageBox.Show("Por favor, insira um nome e um CPF válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                jogadores.Add(new Jogador { Nome = nome, Cpf = cpf, Vitorias = 0 });
                SalvarJogadores();
                MessageBox.Show("Jogador cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nomeBox.Clear();
                cpfBox.Clear();
            }
        }

        private void dataGridViewRanking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRanking.CurrentRow != null)
            {
                int selectedRowIndex = dataGridViewRanking.CurrentRow.Index;

                if (selectedRowIndex >= 0)
                {
                    string cpf = dataGridViewRanking.Rows[selectedRowIndex].Cells["Cpf"].Value.ToString();
                    string nome = dataGridViewRanking.Rows[selectedRowIndex].Cells["Nome"].Value.ToString();

                    cpfBox.Text = cpf;
                    nomeBox.Text = nome;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   

        private void cpfBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeBox_TextChanged(object sender, EventArgs e)
        {

        }

    
       
    }
}