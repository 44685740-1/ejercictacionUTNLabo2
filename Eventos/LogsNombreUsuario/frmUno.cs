using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogsNombreUsuario
{
    public partial class frmUno : Form,Imanejador
    {
        public delegate void EventoHandlerForm(string frmNombre);
        public event EventoHandlerForm FormAbrierto;
        public event EventoHandlerForm FormCerrado;

        public frmUno()
        {
            InitializeComponent();
        }

        private void frmUno_Load(object sender, EventArgs e)
        {
            OnfrmAbierto("frmUno");
        }

        public void frmcerradoNotificacion(object sender, EventArgs e)
        {
            OnFormCerrado("frmUno");
        }

        public void OnfrmAbierto(string nombreForm)
        {
            FormAbrierto?.Invoke(nombreForm);
        }

        public void OnFormCerrado(string nombreForm)
        {
            FormCerrado?.Invoke(nombreForm);
        }
    }
}
