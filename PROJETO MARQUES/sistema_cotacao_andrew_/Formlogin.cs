using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_cotacao_andrew_
{
    
    public partial class Formlogin : Form
    {
        // Construtor 
        public Formlogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;

        }

        // Método qnd o botão de login é clicado
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Coleta os dados de nome do usuário e senha 
            string nomeUsuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            // Verifica se o nome do usuário ou a senha estão vazios
            if (string.IsNullOrWhiteSpace(nomeUsuario) || string.IsNullOrWhiteSpace(senha))
            {
                
                MessageBox.Show("Por favor, insira seu nome de usuário e senha.");
                return;
            }
            


            try
            {
                // Cria uma conexão com o banco de dados
                using (SqlConnection conn = new SqlConnection("Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True"))
                {
                    conn.Open();  

                    
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE NomeUsuario = @NomeUsuario AND Senha = @Senha", conn))
                    {
                        // Adiciona os valores do nome do usuário e da senha ao comando SQL
                        cmd.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);
                        cmd.Parameters.AddWithValue("@Senha", senha);

                        // Executa o comando SQL e obtém os resultados
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Se um usuário for encontrado
                            if (reader.Read())
                            {
                                // Cria um novo formulário principal
                                FormPrincipal formPrincipal = new FormPrincipal();

                                // Quando o formulário principal for fechado, fecha também este formulário de login
                                formPrincipal.FormClosed += (s, args) => this.Visible = true;
                                formPrincipal.Show();

                                // Limpa os campos de texto
                                txtUsuario.Text = "";
                                txtSenha.Text = "";

                                // Esconde login
                                this.Visible = true;
                            }
                            // Se um usuário não for encontrado
                            else
                            {
                                
                                MessageBox.Show("Nome de usuário ou senha incorretos.");

                                // Limpa os campos de texto do nome do usuário e da senha
                                
                                txtSenha.Clear();
                            }
                        }
                    }
                }
            }
            // Se algum erro ocorrer ao tentar executar o código acima
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro
                MessageBox.Show("Ocorreu um erro ao tentar fazer login: " + ex.Message);
            }
        }
        private void chkMostrarSenhaLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarSenhaLogin.Checked)
            {
                // Se o CheckBox estiver marcado, mostra a senha
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                // Se o CheckBox não estiver marcado, oculta a senha
                txtSenha.PasswordChar = '*';
            }
        }


        // Método que é acionado quando o botão de registro é clicado
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário de registro
            FormRegistro formRegistro = new FormRegistro();

            // Mostra o formulário de registro
            formRegistro.Show();
        }
    }

}
