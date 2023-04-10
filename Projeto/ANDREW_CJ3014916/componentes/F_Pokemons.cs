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
    public partial class F_Pokemons : Form
    {
        F_Principal fp;
        public F_Pokemons(string v, F_Principal f)
        {
            InitializeComponent();

            tb_listaPokemons.Text = v;
            fp = f;
            f.num = 10;
        }

        private void F_Pokemons_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaPokemon.Text = tb_listaPokemons.Text;
        }
    }
}
