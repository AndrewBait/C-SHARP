using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sistema_cotacao_andrew_
{
    
    public partial class FormPrincipal : Form
    {
        // Construtor
        public FormPrincipal()
        {
            InitializeComponent(); 
        }

        // Método chamado quando o botão Produtos é clicado

        private void picBoxProdutos_Click(object sender, EventArgs e)
        {
            // Verifica se o formulário de gerenciamento de produtos já está aberto
            FormGerenciamentoProdutos formAberto = Application.OpenForms.OfType<FormGerenciamentoProdutos>().FirstOrDefault();

            if (formAberto != null)
            {
                // Se já estiver aberto, traz ele para o primeiro plano
                formAberto.BringToFront();
            }
            else
            {
                // Se  não estiver aberto, cria uma nova instância e o mostra
                FormGerenciamentoProdutos formGerenciamentoProdutos = new FormGerenciamentoProdutos();
                formGerenciamentoProdutos.Show();
            }
        }

        private void picBoxFornecedores_Click(object sender, EventArgs e)
        {
            // Verifica se o formulário de gerenciamento de fornecedores já está aberto
            FormGerenciamentoFornecedores formFornecedoresAberto = Application.OpenForms.OfType<FormGerenciamentoFornecedores>().FirstOrDefault();

            if (formFornecedoresAberto != null)
            {
                // Traga para frente se já estiver aberto
                formFornecedoresAberto.BringToFront();
            }
            else
            {
                // Abra o formulário de gerenciamento de fornecedores se não estiver aberto.
                FormGerenciamentoFornecedores formGerenciamentoFornecedores = new FormGerenciamentoFornecedores();
                formGerenciamentoFornecedores.Show();
            }
        }

        private void picBoxCotacao_Click(object sender, EventArgs e)
        {
            // Verifica se o formulário de cotação já está aberto
            FormCotacao formCotacaoAberto = Application.OpenForms.OfType<FormCotacao>().FirstOrDefault();

            if (formCotacaoAberto != null)
            {
                // Traz para frente se já estiver aberto
                formCotacaoAberto.BringToFront();
            }
            else
            {
                // Abra o formulário de cotação se não estiver aberto.
                FormCotacao formCotacao = new FormCotacao();
                formCotacao.Show();
            }
        }

        private void picBoxRelatorios_Click(object sender, EventArgs e)
        {
            // Seu código para abrir o Form de Relatórios
        }


        private void adicionarUsuarioAuxiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Código para adicionar um usuário auxiliar
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();

            
        }
        private void picBoxProdutos_MouseEnter(object sender, EventArgs e)
        {
            // Altera a borda do PictureBox quando o mouse passa sobre ele
            picBoxProdutos.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picBoxProdutos_MouseLeave(object sender, EventArgs e)
        {
            // Retorna à borda original quando o mouse sai
            picBoxProdutos.BorderStyle = BorderStyle.None;
        }

        private void picBoxProdutos_MouseDown(object sender, MouseEventArgs e)
        {
            // Altera a cor de fundo quando o botão do mouse é pressionado
            picBoxProdutos.BackColor = Color.DarkGreen;
        }

        private void picBoxProdutos_MouseUp(object sender, MouseEventArgs e)
        {
            // Retorna à cor de fundo original quando o botão do mouse é liberado
            picBoxProdutos.BackColor = Color.Transparent;
        }


        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.DarkGreen;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }


        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.DarkGreen;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }



        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Fecha a aplicação
            Application.Exit();
        }


        // Método chamado quando o FormPrincipal é carregado.
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
