using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componentes
{
    public partial class F_CheckBox : Form
    {
        List<CheckBox> pokemon = new List<CheckBox>();   
        public F_CheckBox()
        {
            InitializeComponent();
            pokemon.Add(cb_agua);
            pokemon.Add(cb_fogo);
            pokemon.Add(cb_planta);
            pokemon.Add(cb_eletrico);
        }

        private void btn_pokemonMarcado_Click(object sender, EventArgs e)
        {

            string txt = "";
            foreach (CheckBox t in pokemon)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                } 

            }
            MessageBox.Show(txt);
        }
    }
}
