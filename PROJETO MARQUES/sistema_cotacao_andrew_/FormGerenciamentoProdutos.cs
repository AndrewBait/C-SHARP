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

    public partial class FormGerenciamentoProdutos : Form
    {
        // Construtor 
        public FormGerenciamentoProdutos()
        {
            InitializeComponent(); // interface gráfica
        }

        // Método chamado quando o FormGerenciamentoProdutos é carregado
        private void FormGerenciamentoProdutos_Load(object sender, EventArgs e)
        {
            // Conexão com o banco de dados para buscar os produtos
            using (SqlConnection conn = new SqlConnection("Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Produtos", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dgvProdutos.DataSource = dataTable;
                    }
                }
            }

            // Configuração das colunas do DataGridView
            dgvProdutos.Columns["Id"].Visible = false;
            dgvProdutos.Columns["CodigoEAN"].DisplayIndex = 0;
            dgvProdutos.Columns["NomeProduto"].DisplayIndex = 1;
            dgvProdutos.Columns["NomeProduto"].Width = 250;
        }

        // Método chamado quando o botão Excluir é clicado
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Obtem o produto selecionado
            DataGridViewRow row = dgvProdutos.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }

            int produtoId = (int)row.Cells["Id"].Value;

            // Conexão com o banco de dados para excluir o produto
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Produtos WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", produtoId);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Atualiza o DataGridView.
                FormGerenciamentoProdutos_Load(null, null);
            }
            catch (Exception ex)
            {
                // Caso ocorra um erro, é exibida uma mensagem
                MessageBox.Show("Ocorreu um erro ao tentar excluir o produto: " + ex.Message);
            }
        }

        // Método para atualizar o DataGridView
        public void AtualizarDataGridView()
        {
            // Conexão com o banco de dados para atualizar os dados exibidos no DataGridView
            using (SqlConnection conn = new SqlConnection("Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Produtos", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dgvProdutos.DataSource = dataTable;
                    }
                }
            }

            // Configuração das colunas do DataGridView
            dgvProdutos.Columns["Id"].Visible = false;
            dgvProdutos.Columns["CodigoEAN"].DisplayIndex = 0;
            dgvProdutos.Columns["NomeProduto"].DisplayIndex = 1;
            dgvProdutos.Columns["NomeProduto"].Width = 250;
        }

        // Método chamado quando o botão Adicionar é clicado
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Abre o formulário de adicionar/editar produto
            FormAddEditProduto formAddEditProduto = new FormAddEditProduto();
            if (formAddEditProduto.ShowDialog() == DialogResult.OK)
            {
                AtualizarDataGridView();
            }
        }

        // Método chamado quando o botão Editar é clicado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtem o produto selecionado
            DataGridViewRow row = dgvProdutos.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }

            int produtoId = (int)row.Cells["Id"].Value;

            // Abre o formulário de adicionar/editar produto para edição
            FormAddEditProduto formAddEditProduto = new FormAddEditProduto();
            formAddEditProduto.ProdutoId = produtoId;
            if (formAddEditProduto.ShowDialog() == DialogResult.OK)
            {
                AtualizarDataGridView();
            }
        }

        
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
