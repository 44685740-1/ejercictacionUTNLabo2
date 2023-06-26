using System.Text;
namespace logicaParcial
{
    public class Logs 
    {
        public delegate void EventoHandlerForm(string frmNombre);
        public event EventoHandlerForm FormAbrierto;
        public event EventoHandlerForm FormCerrado;

        public void SubscribirEventosForm(Form form)
        {
            form.Load += frmLoad;
            form.FormClosed += frmCerrado;
        }

        private void frmLoad(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            OnfrmAbierto(form.Name);
        }

        private void frmCerrado(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            OnfrmCerrado(form.Name);
        }

        private void OnfrmAbierto(string nombreForm)
        {
            FormAbrierto(nombreForm);
        }

        private void OnfrmCerrado(string nombreForm)
        {
            FormCerrado(nombreForm);
        }

        public void ManejadorFrmAbierto(string nombreForm)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("frm abierto ultimo ");
            sb.Append(nombreForm);
            File.WriteAllText("usuarioMovement.txt", sb.ToString());
        }

        public void ManejadorFrmCerrado(string nombreForm)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("frm cerrado ultimo ");
            sb.Append(nombreForm);
            File.WriteAllText("usuarioMovement.txt", sb.ToString());
        }
    }
}