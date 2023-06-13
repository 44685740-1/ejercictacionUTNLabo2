using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class FrmTestDelegados : Form
    {
        public delegate void DelegadoActualizarNombre(string nombre);
        //Action<string> delegadoActualizarNombree;
        private DelegadoActualizarNombre delegadoActualizarNombre;

        public FrmTestDelegados(DelegadoActualizarNombre delegadoActualizarNombre)
        {
            InitializeComponent();
            this.delegadoActualizarNombre = delegadoActualizarNombre;   
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (delegadoActualizarNombre is not null)
            {
                delegadoActualizarNombre(txtNombre.Text);
                //delegadoActualizarNombre.Invoke(txtNombre.Text);  
            }
        }
    }
}
