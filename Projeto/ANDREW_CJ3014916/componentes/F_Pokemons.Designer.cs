namespace componentes
{
    partial class F_Pokemons
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
            this.tb_listaPokemons = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_listaPokemons
            // 
            this.tb_listaPokemons.Location = new System.Drawing.Point(22, 23);
            this.tb_listaPokemons.Multiline = true;
            this.tb_listaPokemons.Name = "tb_listaPokemons";
            this.tb_listaPokemons.Size = new System.Drawing.Size(309, 397);
            this.tb_listaPokemons.TabIndex = 0;
            // 
            // F_Pokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 436);
            this.Controls.Add(this.tb_listaPokemons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Pokemons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pokemon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Pokemons_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_listaPokemons;
    }
}