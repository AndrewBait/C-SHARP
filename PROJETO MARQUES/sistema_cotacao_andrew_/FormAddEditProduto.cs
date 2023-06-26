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
    public partial class FormAddEditProduto : Form
    {
        // Propriedade para armazenar o Id do Produto 
        public int? ProdutoId { get; set; }

        public FormAddEditProduto()
        {
            InitializeComponent();
        }

        private void FormAddEditProduto_Load(object sender, EventArgs e)
        {
            if (ProdutoId.HasValue)
            {
                // editando um produto existente. Precisa preencher os campos de texto com os detalhes do produto.
                using (SqlConnection conn = new SqlConnection("Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Produtos WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", ProdutoId.Value);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNomeProduto.Text = reader["NomeProduto"].ToString();
                                txtCodigoEAN.Text = reader["CodigoEAN"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtNomeProduto.Text;
            string codigoEAN = txtCodigoEAN.Text;

            if (string.IsNullOrEmpty(nomeProduto))
            {
                MessageBox.Show("Por favor, preencha o campo nome do produto.");
                return;
            }
            if (string.IsNullOrEmpty(codigoEAN))
            {
                MessageBox.Show("Por favor, preencha o campo código EAN.");
                return;
            }
            if (codigoEAN.Length > 13 || !long.TryParse(codigoEAN, out _))
            {
                MessageBox.Show("O código EAN deve ser um número válido com no máximo 13 dígitos.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True"))
                {
                    conn.Open();

                    if (ProdutoId == null) //adicionando um novo produto.
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Produtos (NomeProduto, CodigoEAN) VALUES (@NomeProduto, @CodigoEAN)", conn))
                        {
                            cmd.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                            cmd.Parameters.AddWithValue("@CodigoEAN", codigoEAN);

                            cmd.ExecuteNonQuery();
                        }

                        // Limpa os campos de entrada após adicionar um novo produto.
                        txtNomeProduto.Text = "";
                        txtCodigoEAN.Text = "";

                        // Retorna DialogResult.OK após adicionar um novo produto.
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else // Estamos editando um produto existente.
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE Produtos SET NomeProduto = @NomeProduto, CodigoEAN = @CodigoEAN WHERE Id = @Id", conn))
                        {
                            cmd.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                            cmd.Parameters.AddWithValue("@CodigoEAN", codigoEAN);
                            cmd.Parameters.AddWithValue("@Id", ProdutoId.Value);

                            cmd.ExecuteNonQuery();
                        }

                        // Feche este formulário após editar um produto.
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                // erros de SQL específicos
                switch (ex.Number)
                {
                    case 2627:
                        // Violation of primary key (duplicate key).
                        MessageBox.Show("O produto já existe no banco de dados.");
                        break;

                    case 2601:
                        // Violation of unique index.
                        MessageBox.Show("O produto já existe no banco de dados.");
                        break;

                    default:
                        MessageBox.Show("Ocorreu um erro ao tentar salvar o produto: " + ex.Message);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
