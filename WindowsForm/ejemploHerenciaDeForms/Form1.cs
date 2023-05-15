using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploHerenciaDeForms
{
    public partial class frmHijo : frmPadre
    {
        public frmHijo()
        {
            InitializeComponent();
        }

        private void btnFrmHijo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mensaje del metodo hijo");
        }
    }
}
