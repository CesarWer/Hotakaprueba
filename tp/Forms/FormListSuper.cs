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
    public partial class FormListSuper : Form
    {
        public FormListSuper()
        {
            InitializeComponent();
        }

        private void FormListSuper_Load(object sender, EventArgs e)
        {

        }

        private void BTNVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
