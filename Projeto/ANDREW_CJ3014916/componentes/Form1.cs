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
    public partial class F_Principal : Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_pokemon.Text == "")
            {
                MessageBox.Show("Digite um Pokemon"); 
                tb_pokemon.Focus();
                return; 
            }
            tb_listaPokemon.Text += tb_pokemon.Text + ", ";
            tb_pokemon.Clear();
            tb_pokemon.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaPokemon.Clear();
            tb_pokemon.Clear();
            tb_pokemon.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Pokemons  f_Pokemons = new F_Pokemons(tb_listaPokemon.Text, this);
            f_Pokemons.ShowDialog();
        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog(); 
        }
    }
}
