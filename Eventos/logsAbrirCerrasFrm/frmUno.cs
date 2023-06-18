using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logsAbrirCerrasFrm
{
    public partial class frmUno : Form,Imanejador
    {
        public delegate void FormEventHandler(string formName);
        public event FormEventHandler FormOpened;
        public event FormEventHandler FormClosed;


        public frmUno()
        {
            InitializeComponent();
        }

        private void frmUno_Load(object sender, EventArgs e)
        {
            OnFormOpened("frmUno");
        }

        public void ChildForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Notify the closing of this form
            OnFormClosed("frmUno");
        }

        public void OnFormOpened(string formName)
        {
            FormOpened?.Invoke(formName);
        }

        public void OnFormClosed(string formName)
        {
            FormClosed?.Invoke(formName);
        }

        /*
        private void ChildForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Notify the closing of this form
            OnFormClosed("frmUno");
        }

        protected virtual void OnFormOpened(string formName)
        {
            FormOpened?.Invoke(formName);
        }

        protected virtual void OnFormClosed(string formName)
        {
            FormClosed?.Invoke(formName);
        }
        */
    }
}
