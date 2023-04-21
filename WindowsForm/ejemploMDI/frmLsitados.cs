using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ejemploMDI;
namespace ejemploMDI
{
    public partial class frmLsitados : Form
    {
        List<Productos> productoss;
        public frmLsitados()
        {
            InitializeComponent();
            productoss = new List<Productos>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLsitados_Load(object sender, EventArgs e)
        {
            hardCodeoProdcutos.hardCodeo(productoss);
            dgListado.DataSource = productoss;
        }

        private void actualizarDataGrid(List<Productos> productos) 
        {
            dgListado.DataSource= null;
            dgListado.DataSource = productos;
        }
    }
}
