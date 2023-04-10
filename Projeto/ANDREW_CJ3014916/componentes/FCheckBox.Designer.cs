namespace componentes
{
    partial class F_CheckBox
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
            this.cb_agua = new System.Windows.Forms.CheckBox();
            this.cb_fogo = new System.Windows.Forms.CheckBox();
            this.cb_planta = new System.Windows.Forms.CheckBox();
            this.cb_eletrico = new System.Windows.Forms.CheckBox();
            this.btn_pokemonMarcado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_agua
            // 
            this.cb_agua.AutoSize = true;
            this.cb_agua.Location = new System.Drawing.Point(25, 16);
            this.cb_agua.Name = "cb_agua";
            this.cb_agua.Size = new System.Drawing.Size(51, 17);
            this.cb_agua.TabIndex = 0;
            this.cb_agua.Text = "Água";
            this.cb_agua.UseVisualStyleBackColor = true;
            // 
            // cb_fogo
            // 
            this.cb_fogo.AutoSize = true;
            this.cb_fogo.Location = new System.Drawing.Point(25, 50);
            this.cb_fogo.Name = "cb_fogo";
            this.cb_fogo.Size = new System.Drawing.Size(50, 17);
            this.cb_fogo.TabIndex = 1;
            this.cb_fogo.Text = "Fogo";
            this.cb_fogo.UseVisualStyleBackColor = true;
            // 
            // cb_planta
            // 
            this.cb_planta.AutoSize = true;
            this.cb_planta.Location = new System.Drawing.Point(25, 88);
            this.cb_planta.Name = "cb_planta";
            this.cb_planta.Size = new System.Drawing.Size(56, 17);
            this.cb_planta.TabIndex = 2;
            this.cb_planta.Text = "Planta";
            this.cb_planta.UseVisualStyleBackColor = true;
            // 
            // cb_eletrico
            // 
            this.cb_eletrico.AutoSize = true;
            this.cb_eletrico.Location = new System.Drawing.Point(25, 122);
            this.cb_eletrico.Name = "cb_eletrico";
            this.cb_eletrico.Size = new System.Drawing.Size(61, 17);
            this.cb_eletrico.TabIndex = 3;
            this.cb_eletrico.Text = "Elétrico";
            this.cb_eletrico.UseVisualStyleBackColor = true;
            // 
            // btn_pokemonMarcado
            // 
            this.btn_pokemonMarcado.Location = new System.Drawing.Point(142, 25);
            this.btn_pokemonMarcado.Name = "btn_pokemonMarcado";
            this.btn_pokemonMarcado.Size = new System.Drawing.Size(279, 42);
            this.btn_pokemonMarcado.TabIndex = 4;
            this.btn_pokemonMarcado.Text = "Pokemon Marcado";
            this.btn_pokemonMarcado.UseVisualStyleBackColor = true;
            this.btn_pokemonMarcado.Click += new System.EventHandler(this.btn_pokemonMarcado_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.btn_pokemonMarcado);
            this.Controls.Add(this.cb_eletrico);
            this.Controls.Add(this.cb_planta);
            this.Controls.Add(this.cb_fogo);
            this.Controls.Add(this.cb_agua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_agua;
        private System.Windows.Forms.CheckBox cb_fogo;
        private System.Windows.Forms.CheckBox cb_planta;
        private System.Windows.Forms.CheckBox cb_eletrico;
        private System.Windows.Forms.Button btn_pokemonMarcado;
    }
}