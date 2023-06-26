using LogicParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogsFinal
{
    public partial class frmUno : Form,IformManejador
    {
        public delegate void EventoHandlerForm(string frmNombre);
        public event EventoHandlerForm FormAbrierto;
        public event EventoHandlerForm FormCerrado;


        public frmUno()
        {
            InitializeComponent();
        }

        public void FormOpen()
        {
            OnFrmAbierto("frmDos");
        }

        public void FormClose()
        {
            OnFrmCerrado("frmDos");
        }

        public void OnFrmAbierto(string nombreForm)
        {
            FormAbrierto?.Invoke(nombreForm);
        }

        public void OnFrmCerrado(string nombreForm)
        {
            FormCerrado?.Invoke(nombreForm);
        }

    }
}
