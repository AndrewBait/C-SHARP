namespace sistema_cotacao_andrew_
{
    partial class FormCotacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxProdutos = new System.Windows.Forms.ListBox();
            this.lbxCotacao = new System.Windows.Forms.ListBox();
            this.btnAdicionarCotacaos = new System.Windows.Forms.Button();
            this.btnRemoverCotacao = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxProdutos
            // 
            this.lbxProdutos.FormattingEnabled = true;
            this.lbxProdutos.Location = new System.Drawing.Point(12, 78);
            this.lbxProdutos.Name = "lbxProdutos";
            this.lbxProdutos.Size = new System.Drawing.Size(429, 264);
            this.lbxProdutos.TabIndex = 0;
            // 
            // lbxCotacao
            // 
            this.lbxCotacao.FormattingEnabled = true;
            this.lbxCotacao.Location = new System.Drawing.Point(489, 78);
            this.lbxCotacao.Name = "lbxCotacao";
            this.lbxCotacao.Size = new System.Drawing.Size(347, 264);
            this.lbxCotacao.TabIndex = 1;
            // 
            // btnAdicionarCotacaos
            // 
            this.btnAdicionarCotacaos.Location = new System.Drawing.Point(355, 348);
            this.btnAdicionarCotacaos.Name = "btnAdicionarCotacaos";
            this.btnAdicionarCotacaos.Size = new System.Drawing.Size(86, 35);
            this.btnAdicionarCotacaos.TabIndex = 2;
            this.btnAdicionarCotacaos.Text = "adicionar";
            this.btnAdicionarCotacaos.UseVisualStyleBackColor = true;
            this.btnAdicionarCotacaos.Click += new System.EventHandler(this.btnAdicionarCotacao_Click);
            // 
            // btnRemoverCotacao
            // 
            this.btnRemoverCotacao.Location = new System.Drawing.Point(489, 360);
            this.btnRemoverCotacao.Name = "btnRemoverCotacao";
            this.btnRemoverCotacao.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverCotacao.TabIndex = 3;
            this.btnRemoverCotacao.Text = "remover";
            this.btnRemoverCotacao.UseVisualStyleBackColor = true;
            this.btnRemoverCotacao.Click += new System.EventHandler(this.btnRemoverCotacao_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 480);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(748, 362);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportarCotacao_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(102, 358);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(247, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pesquisar";
            // 
            // FormCotacao
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(848, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRemoverCotacao);
            this.Controls.Add(this.btnAdicionarCotacaos);
            this.Controls.Add(this.lbxCotacao);
            this.Controls.Add(this.lbxProdutos);
            this.Name = "FormCotacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button btnAdicionarCotacao;  
        
        
        private System.Windows.Forms.Button btnImportarCotacao;
        private System.Windows.Forms.Button btnExportarCotacao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.ListBox lbxProdutos;
        private System.Windows.Forms.ListBox lbxCotacao;
        private System.Windows.Forms.Button btnAdicionarCotacaos;
        private System.Windows.Forms.Button btnRemoverCotacao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}