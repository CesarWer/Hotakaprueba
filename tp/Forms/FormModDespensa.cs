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
    public partial class FormModDespensa : Form
    {
           
        public FormModDespensa()
        {
            InitializeComponent();
        }

        public FormModDespensa(string Nombre)
        {
            //this.TxtNombre = Nombre;
        }
        private void CMBTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = CMBTipo.Text;
            ComprobarVisible(tipo);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
        }
        private void ComprobarVisible(string Tipo)
        {
            if (CMBTipo.Text == "Queso" || CMBTipo.Text == "Carne" || CMBTipo.Text == "Pescado" || CMBTipo.Text == "Panaderia")
            {
                LBLKilos.Visible = true;
                TxtCant.Visible = true;
                LBLCantMin.Visible = true;
                TxtCantMinima.Visible = true;
            }
            if (CMBTipo.Text == "Hortaliza" || CMBTipo.Text == "Fruta")
            {
                LBLCant.Visible = true;
                TxtCant.Visible = true;
                LBLCantMin.Visible = true;
                TxtCantMinima.Visible = true;
            }
            if (CMBTipo.Text == "Lacteo")
            {
                LBLLitros.Visible = true;
                TxtCant.Visible = true;
                LBLCantMin.Visible = true;
                TxtCantMinima.Visible = true;
            }
            if (CMBTipo.Text == "Bebida")
            {
                LBLCant.Visible = true;
                TxtCant.Visible = true;
                LBLCantMin.Visible = true;
                TxtCantMinima.Visible = true;
                LBLTipoBebida.Visible = true;
                CMBTipoBebida.Visible = true;
            }
        }

        private void FormModDespensa_Load(object sender, EventArgs e)
        {

        }

        private void BTNVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
