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
    public partial class frmAdd : Form
    {
        public frmPrincipal frmPrincipal { get; set; } 

        public List<Productos> listaProductos { get; set; }

        private Action delegadoActualizarDtg;
        public frmAdd(frmPrincipal frmPrincipal, Action delegadoActualizarDtg)
        {
            InitializeComponent();
            this.delegadoActualizarDtg = delegadoActualizarDtg;
            this.frmPrincipal = frmPrincipal;   
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Productos> productos = new List<Productos>();
            Productos producto = new Productos("Masa Madre",19,20);
            productos = frmPrincipal.Productos;
            productos.Add(producto);    
            frmPrincipal.Productos = productos;
            OnActualizarDtgProductos();
        }

        private void OnActualizarDtgProductos() 
        {
            delegadoActualizarDtg();
        }
    }
}
