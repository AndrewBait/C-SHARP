using System; 
using System.Data; 
using System.Data.SqlClient;
using System.Windows.Forms; 

namespace sistema_cotacao_andrew_
{
    public partial class FormAddEditFornecedor : Form 
    {
        public int? FornecedorId { get; set; } // Propriedade para armazenar o ID do fornecedor.

        public FormAddEditFornecedor()
        {
            InitializeComponent(); 
        }

        
        private void FormAddEditFornecedor_Load(object sender, EventArgs e)
        {
            // Se o FornecedorId tem valor, então este formulário está no modo "editar".
            if (FornecedorId.HasValue)
            {
                
                using (SqlConnection conn = new SqlConnection("Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True"))
                {
                    conn.Open(); 

                    
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Fornecedores WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", FornecedorId.Value); // Adicionando o parâmetro ao comando SQL.

                        // Executando o comando e obtendo os resultados.
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            //preenche os campos do formulário com os dados do fornecedor.
                            if (reader.Read())
                            {
                                txtNome.Text = reader["Nome"].ToString();
                                txtNumeroCelular.Text = reader["NumeroCelular"].ToString();
                                txtNomeEmpresa.Text = reader["NomeEmpresa"].ToString();
                            }
                        }
                    }
                }
            }
        }

        // Este método é chamado quando o botão Salvar é clicado.
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string numeroCelular = txtNumeroCelular.Text;
            string nomeEmpresa = txtNomeEmpresa.Text;

            

            // Conexão com o banco de dados.
            using (SqlConnection conn = new SqlConnection("Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True"))
            {
                conn.Open(); // Abrindo a conexão.

                if (FornecedorId == null) // Se o FornecedorId é nulo, então este formulário está no modo "adicionar".
                {
                    // Comando SQL para inserir um novo fornecedor.
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Fornecedores (Nome, NumeroCelular, NomeEmpresa) VALUES (@Nome, @NumeroCelular, @NomeEmpresa)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome); // Adicionando os parâmetros ao comando SQL.
                        cmd.Parameters.AddWithValue("@NumeroCelular", numeroCelular);
                        cmd.Parameters.AddWithValue("@NomeEmpresa", nomeEmpresa);

                        cmd.ExecuteNonQuery(); // Executando o comando SQL.
                    }
                }
                else // Se o FornecedorId tem valor, então este formulário está no modo "editar".
                {
                    // Comando SQL para atualizar o fornecedor existente.
                    using (SqlCommand cmd = new SqlCommand("UPDATE Fornecedores SET Nome = @Nome, NumeroCelular = @NumeroCelular, NomeEmpresa = @NomeEmpresa WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome); // Adicionando os parâmetros ao comando SQL.
                        cmd.Parameters.AddWithValue("@NumeroCelular", numeroCelular);
                        cmd.Parameters.AddWithValue("@NomeEmpresa", nomeEmpresa);
                        cmd.Parameters.AddWithValue("@Id", FornecedorId.Value);

                        cmd.ExecuteNonQuery(); // Executando o comando SQL.
                    }
                }
            }

            this.DialogResult = DialogResult.OK; 
            this.Close(); 
        }

        // Este método é chamado quando o botão Cancelar é clicado.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
