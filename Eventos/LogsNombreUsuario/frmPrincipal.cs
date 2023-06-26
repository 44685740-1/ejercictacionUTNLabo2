
using logicaParcial;

namespace LogsNombreUsuario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

       

        private void btnFrmUno_Click(object sender, EventArgs e)
        {
            frmUno frmUno = new frmUno();   
            Logs logs = new Logs();
            logs.SubscribirEventosForm(frmUno);
            logs.FormAbrierto += logs.ManejadorFrmAbierto;
            logs.FormCerrado += logs.ManejadorFrmCerrado;
            frmUno.ShowDialog();
        }

        private void btnfrmDos_Click(object sender, EventArgs e)
        {
            frmDos frmDos = new frmDos();   
            Logs logs = new Logs();
            logs.SubscribirEventosForm(frmDos);
            logs.FormAbrierto += logs.ManejadorFrmAbierto;
            logs.FormCerrado += logs.ManejadorFrmCerrado;   
            frmDos.ShowDialog();    
        }

       
    }
}