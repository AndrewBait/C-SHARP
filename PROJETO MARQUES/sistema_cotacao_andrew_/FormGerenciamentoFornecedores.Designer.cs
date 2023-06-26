namespace sistema_cotacao_andrew_
{
    partial class FormGerenciamentoFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciamentoFornecedores));
            this.btnAdicionarFornecedor = new System.Windows.Forms.Button();
            this.btnEditarFornecedor = new System.Windows.Forms.Button();
            this.btnExcluirFornecedor = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarFornecedor
            // 
            this.btnAdicionarFornecedor.Location = new System.Drawing.Point(33, 112);
            this.btnAdicionarFornecedor.Name = "btnAdicionarFornecedor";
            this.btnAdicionarFornecedor.Size = new System.Drawing.Size(75, 55);
            this.btnAdicionarFornecedor.TabIndex = 0;
            this.btnAdicionarFornecedor.Text = "ADICIONAR";
            this.btnAdicionarFornecedor.UseVisualStyleBackColor = true;
            this.btnAdicionarFornecedor.Click += new System.EventHandler(this.btnAdicionarFornecedor_Click);
            // 
            // btnEditarFornecedor
            // 
            this.btnEditarFornecedor.Location = new System.Drawing.Point(33, 189);
            this.btnEditarFornecedor.Name = "btnEditarFornecedor";
            this.btnEditarFornecedor.Size = new System.Drawing.Size(75, 55);
            this.btnEditarFornecedor.TabIndex = 1;
            this.btnEditarFornecedor.Text = "EDITAR";
            this.btnEditarFornecedor.UseVisualStyleBackColor = true;
            this.btnEditarFornecedor.Click += new System.EventHandler(this.btnEditarFornecedor_Click);
            // 
            // btnExcluirFornecedor
            // 
            this.btnExcluirFornecedor.Location = new System.Drawing.Point(33, 271);
            this.btnExcluirFornecedor.Name = "btnExcluirFornecedor";
            this.btnExcluirFornecedor.Size = new System.Drawing.Size(75, 55);
            this.btnExcluirFornecedor.TabIndex = 2;
            this.btnExcluirFornecedor.Text = "EXCLUIR";
            this.btnExcluirFornecedor.UseVisualStyleBackColor = true;
            this.btnExcluirFornecedor.Click += new System.EventHandler(this.btnExcluirFornecedor_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Location = new System.Drawing.Point(133, 77);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(427, 360);
            this.dgvFornecedores.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 414);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "<<Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "LISTA DE FORNECEDORES";
            // 
            // FormGerenciamentoFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(601, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.btnExcluirFornecedor);
            this.Controls.Add(this.btnEditarFornecedor);
            this.Controls.Add(this.btnAdicionarFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGerenciamentoFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.FormGerenciamentoFornecedores_Load);
            this.Click += new System.EventHandler(this.FormGerenciamentoFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarFornecedor;
        private System.Windows.Forms.Button btnEditarFornecedor;
        private System.Windows.Forms.Button btnExcluirFornecedor;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
    }
}