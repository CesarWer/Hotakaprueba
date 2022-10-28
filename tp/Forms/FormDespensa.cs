using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Forms
{
    public partial class FormDespensa : Form
    {
        Archivo archivo = new Archivo();
        //Producto producto = new Producto();
        public FormDespensa()
        {
            InitializeComponent();
        }

        private void DGVDespensa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void FormDespensa_Load(object sender, EventArgs e)
        {
            DGVDespensa.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        public void CargarDespensa()
        {
            ActualizarGrilla();
        }
              
        
        private void ActualizarGrilla()
        {
            DGVDespensa.DataSource = null;            
            DGVDespensa.DataSource = archivo.Buscar();
        }

        private void BTNVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
