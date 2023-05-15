using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploHerenciaFrmDesign
{
    public partial class frmHijo : frmPadre
    {
        public frmHijo()
        //:base() 
        {
            InitializeComponent();
        }

        private void frmHijo_Load(object sender, EventArgs e)
        {

        }

        public override void btnIr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mensaje del hijo");
        }
    }
}
