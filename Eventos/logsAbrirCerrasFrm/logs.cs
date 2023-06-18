using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logsAbrirCerrasFrm
{
    public class logs
    {
        public delegate void FormEventHandler(string formName);
        public event FormEventHandler FormOpened;
        public event FormEventHandler FormClosed;

        public void SubscribeToFormEvents(Form form)
        {
            form.Load += Form_Load;
            form.FormClosed += Form_FormClosed;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            OnFormOpened(form.Name);
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = (Form)sender;
            OnFormClosed(form.Name);
        }

        protected virtual void OnFormOpened(string formName)
        {
            FormOpened?.Invoke(formName);
        }

        protected virtual void OnFormClosed(string formName)
        {
            FormClosed?.Invoke(formName);
        }

        public void LogsManejadorfrmAbierto(string nombreFrm) 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("frm abierto ultimo ");
            sb.Append(nombreFrm);
            File.WriteAllText("usuarioMovement.txt", sb.ToString());
        }

        public void LogsManejadorfrmCerrado(string nombreFrm)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("frm cerrado ultimo ");
            sb.Append(nombreFrm);
            File.WriteAllText("usuarioMovement.txt", sb.ToString());
        }


        public static void SuscrbirTodosFormulariosEventos(frmUno frmUno, frmDos frmDos) 
        {
            logs logs1 = new logs();
            
            logs1.SubscribeToFormEvents(frmUno);
            logs1.SubscribeToFormEvents(frmDos);

            logs1.FormOpened += logs1.LogsManejadorfrmAbierto;
            logs1.FormClosed += logs1.LogsManejadorfrmCerrado;
        }

    }
}
