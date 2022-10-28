using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void despensaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDespensa Despensa = new FormDespensa();
            Despensa.ShowDialog();
        }

        private void comidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComidas Comidas = new FormComidas();
            Comidas.ShowDialog();
        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecetas Recetas = new FormRecetas();
            Recetas.ShowDialog();
        }

        private void listaSuperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListSuper Super = new FormListSuper();
            Super.ShowDialog();
        }
        
        
    }
}
