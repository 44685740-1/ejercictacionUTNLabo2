using bibliotecaLogicaProblemaParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemaParcial
{
    public partial class frmPrincipal : Form
    {
        List<Productos> listaProductos = new List<Productos>();
        public delegate void ActualizarDtg();

        public List<Productos> Productos { get; set; }

        public frmPrincipal()
        {
            InitializeComponent();
            listaProductos = Hardcodeo.HardcodearProductos();
            this.Productos = listaProductos;    
            dtgProductos.DataSource = listaProductos;

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        public void ActualizarDtgProductos()
        {
            dtgProductos.DataSource = null;
            dtgProductos.DataSource = listaProductos;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            frmAdd frmAdd = new frmAdd(this, ActualizarDtgProductos);
            DialogResult =  frmAdd.ShowDialog();
           

        }
    }
}
