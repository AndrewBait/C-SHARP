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
    public partial class FormGerenciamentoFornecedores : Form
    {
        
        public FormGerenciamentoFornecedores()
        {
            InitializeComponent();
        }

        
        private void FormGerenciamentoFornecedores_Load(object sender, EventArgs e)
        {
            CarregarFornecedores();
        }

        // Método chamado quando o botão Adicionar Fornecedor é clicado
        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            using (FormAddEditFornecedor form = new FormAddEditFornecedor())
            {
                form.FormClosed += Form_FormClosed;
                form.ShowDialog();
            }
        }

        // Método chamado quando o botão Editar Fornecedor é clicado
        private void btnEditarFornecedor_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.SelectedRows.Count > 0)
            {
                int fornecedorId = (int)dgvFornecedores.SelectedRows[0].Cells["Id"].Value;

                using (FormAddEditFornecedor form = new FormAddEditFornecedor())
                {
                    form.FornecedorId = fornecedorId;
                    form.FormClosed += Form_FormClosed;
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um fornecedor para editar.");
            }
        }

        // Método chamado quando o botão Excluir Fornecedor é clicado
        private void btnExcluirFornecedor_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.SelectedRows.Count > 0)
            {
                int fornecedorId = (int)dgvFornecedores.SelectedRows[0].Cells["Id"].Value;

                // Confirmação da ação de exclusão
                var result = MessageBox.Show("Tem certeza que deseja excluir o fornecedor selecionado?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Conexão com o banco de dados para excluir o fornecedor
                    using (SqlConnection conn = new SqlConnection("Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True"))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Fornecedores WHERE Id = @Id", conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", fornecedorId);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Atualiza a lista de fornecedores
                    CarregarFornecedores();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um fornecedor para excluir.");
            }
        }

        // Método para carregar os fornecedores no DataGridView
        private void CarregarFornecedores()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Fornecedores", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dgvFornecedores.DataSource = dataTable;
                    }
                }
            }
            // Configuração do DataGridView
            dgvFornecedores.Columns["Id"].Visible = false;
            dgvFornecedores.Columns["Nome"].DisplayIndex = 0;
            dgvFornecedores.Columns["NumeroCelular"].DisplayIndex = 1;
            dgvFornecedores.Columns["NomeEmpresa"].DisplayIndex = 2;
        }

        // Método chamado quando o FormAddEditFornecedor é fechado
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarFornecedores();
        }

        // Método chamado quando o botão Voltar é clicado
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Fecha o formulário
            this.Close();
        }
    }
}
