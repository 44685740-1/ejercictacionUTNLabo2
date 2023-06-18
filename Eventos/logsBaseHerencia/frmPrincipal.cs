using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logsBaseHerencia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnfrmUno_Click(object sender, EventArgs e)
        {
            frmUno frmUno = new frmUno();       
            frmUno.ShowDialog();    
        }

        private void btnfrmDos_Click(object sender, EventArgs e)
        {
            frmDos frmDos = new frmDos();   
            frmDos.ShowDialog();    
        }
    }
}
