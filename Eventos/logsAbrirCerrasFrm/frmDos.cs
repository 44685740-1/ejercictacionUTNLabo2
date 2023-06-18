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
    public partial class frmDos : Form,Imanejador
    {
        public delegate void FormEventHandler(string formName);
        public event FormEventHandler FormOpened;
        public event FormEventHandler FormClosed;


        public frmDos()
        {
            InitializeComponent();
        }

        private void frmDos_Load(object sender, EventArgs e)
        {
            OnFormOpened("frmDos");
        }

        public void ChildForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Notify the closing of this form
            OnFormClosed("frmDos");
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
        private void ChildForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
             // Notify the closing of this form
              OnFormClosed("frmDos");
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
