using System; 
using System.Collections.Generic;
using System.Data; 
using System.Data.SqlClient; 
using System.Drawing; 
using System.IO; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms;
using ExcelDataReader;
using OfficeOpenXml; 

namespace sistema_cotacao_andrew_
{
    public partial class FormCotacao : Form 
    {
        
        public FormCotacao()
        {
            InitializeComponent();  
            LoadProducts(); // Carrega os produtos ao inicializar o formulário.            
        }
       
        private void LoadProducts()
        {
            lbxProdutos.Items.Clear(); // Limpa os itens da lista de produtos.

            // Conexão com o banco de dados.
            using (SqlConnection conn = new SqlConnection("Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True"))
            {
                conn.Open(); // Abre a conexão.

                
                using (SqlCommand cmd = new SqlCommand("SELECT NomeProduto FROM Produtos", conn))
                {
                    // Executa o comando e mostra os resultados.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Adiciona cada produto à lista de produtos.
                        while (reader.Read())
                        {
                            lbxProdutos.Items.Add(reader["NomeProduto"].ToString());
                        }
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;

            lbxProdutos.Items.Clear(); // Limpa os itens da lista de produtos.

            using (SqlConnection conn = new SqlConnection("Data Source=ANDREW;Initial Catalog=cotacao;Integrated Security=True"))
            {
                conn.Open(); // Abre a conexão.

                using (SqlCommand cmd = new SqlCommand("SELECT NomeProduto FROM Produtos WHERE NomeProduto LIKE @SearchTerm", conn))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lbxProdutos.Items.Add(reader["NomeProduto"].ToString());
                        }
                    }
                }
            }
        }


        // Este método é chamado quando o botão "Adicionar Cotação" é clicado.
        private void btnAdicionarCotacao_Click(object sender, EventArgs e)
        {
            // Verifica se um produto foi selecionado.
            if (lbxProdutos.SelectedItem != null)
            {
                lbxCotacao.Items.Add(lbxProdutos.SelectedItem); // Adiciona o produto selecionado à lista de cotação.

            }
            else
            {
                // Se nenhum produto foi selecionado, mostra uma mensagem.
                MessageBox.Show("Por favor, selecione um produto para adicionar à cotação.");
            }
        }

        // Este método é chamado quando o botão "Remover Cotação" é clicado.
        private void btnRemoverCotacao_Click(object sender, EventArgs e)
        {
            // Verifica se um produto foi selecionado na lista de cotação.
            if (lbxCotacao.SelectedItem != null)
            {
                // Remove o produto selecionado da lista de cotação.
                lbxCotacao.Items.Remove(lbxCotacao.SelectedItem);

            }
            else
            {
                // Se nenhum produto foi selecionado na lista de cotação, mostra uma mensagem.
                MessageBox.Show("Por favor, selecione um produto para remover da cotação.");
            }
        }      




        // Este método é chamado quando o botão "Voltar" é clicado.
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void btnImportarCotacao_Click(object sender, EventArgs e)
        {
            
            var arquivoExel = new ExcelPackage(new FileInfo("C:\\Users\\andre\\Desktop\\ANDREW\\meus scripts\\cotaçãoo"));

        }

        private void btnExportarCotacao_Click(object sender, EventArgs e)
        {
            using (ExcelPackage pck = new ExcelPackage())
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Cotacao");
                int rowStart = 1;

                foreach (var item in lbxCotacao.Items)
                {
                    ws.Cells[rowStart, 1].Value = item.ToString();
                    rowStart++;
                }

                // Cria uma instância da caixa de diálogo "Salvar como"
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos Excel | *.xlsx";
                saveFileDialog.Title = "Salvar cotação como...";
                saveFileDialog.FileName = "cotacao_exportada.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Se o arquivo existir, deleta.
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        File.Delete(saveFileDialog.FileName);
                    }

                    // Cria o arquivo
                    File.WriteAllBytes(saveFileDialog.FileName, pck.GetAsByteArray());

                    // Mensagem para confirmar a exportação
                    MessageBox.Show("Arquivo de cotação exportado com sucesso!");
                }
            }

        }

        DataTableCollection tableCollection;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97 - 2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using (var stream = System.IO.File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;

        }
    }
}
