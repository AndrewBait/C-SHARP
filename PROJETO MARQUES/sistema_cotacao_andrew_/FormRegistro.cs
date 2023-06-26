using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_cotacao_andrew_
{
    
    public partial class FormRegistro : Form
    {
        //conexão com o banco de dados
        private static readonly string connString = "Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True";

        // Construtor
        public FormRegistro()
        {
            InitializeComponent();  
        }

        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {            
            string nomeUsuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            // Verifica se o nome do usuário ou a senha estão vazios
            if (string.IsNullOrEmpty(nomeUsuario) || string.IsNullOrEmpty(senha))
            {
                // Se algum deles estiver vazio, exibe uma mensagem de erro e encerra este método
                MessageBox.Show("Nome de usuário e senha são obrigatórios.");
                return;
            }

            // Verifica se a senha e a confirmação de senha coincidem
            if (senha != confirmarSenha)
            {
                // Se não coincidirem, exibe uma mensagem de erro e encerra este método
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            
            if (senha.Length < 8)
            {               
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres.");
                return;
            }
            // Verifica se a senha atende aos critérios de complexidade
            if (!Regex.IsMatch(senha, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$"))
            {
                MessageBox.Show("A senha deve conter pelo menos uma letra maiúscula, uma letra minúscula, um número e um caractere especial.");
                return;
            }            

            //variável para a conexão com o banco de dados
            SqlConnection conn = null;

            // Tenta executar o código a seguir
            try
            {
                
                conn = new SqlConnection(connString);
                conn.Open();  

                // insere um novo usuário com o nome e senha fornecidos
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (NomeUsuario, Senha) VALUES (@NomeUsuario, @Senha)", conn))
                {
                    // Adiciona os valores do nome do usuário e da senha ao comando SQL
                    cmd.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);
                    
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Usuário registrado com sucesso.");

                    // Fecha o formulário de registro após o registro bem-sucedido
                    this.Close();

                }
            }
            // Caso ocorrer um erro SQL ao tentar executar o código acima
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    // Se o erro for devido a uma violação da chave primária (ou seja, tentando inserir um nome de usuário que já existe), exibe uma mensagem de erro
                    MessageBox.Show("O nome de usuário já existe. Por favor, escolha um diferente.");
                }
                else
                {
                    // mensagem de erro genérica
                    MessageBox.Show("Ocorreu um erro ao tentar registrar o usuário. Por favor, tente novamente mais tarde.");
                }
            }
            // Se algum outro erro ocorrer ao tentar executar o código acima
            catch (Exception ex)
            {
                //erro genérica
                MessageBox.Show("Ocorreu um erro. Por favor, tente novamente mais tarde." + ex.Message);
            }
            finally
            {
                // Garante que a conexão com o banco de dados seja fechada, independentemente de um erro ter ocorrido ou não
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarSenha.Checked)
            {
                // Se o CheckBox estiver marcado, mostra a senha
                txtSenha.PasswordChar = '\0';
                txtConfirmarSenha.PasswordChar = '\0';
            }
            else
            {
                // Se o CheckBox não estiver marcado, oculta a senha
                txtSenha.PasswordChar = '*';
                txtConfirmarSenha.PasswordChar = '*';
            }
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}
