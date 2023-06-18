namespace logsAbrirCerrasFrm
{
    public partial class frmPrincipal : Form
    {

        private frmUno frmUno1 { get; set; }

        private frmDos frmDos1 { get; set; }

        public frmPrincipal()
        {
            InitializeComponent();
            frmUno frmUno = new frmUno();
            frmDos frmDos = new frmDos();
            this.frmUno1 = frmUno;
            this.frmDos1 = frmDos;
            logs.SuscrbirTodosFormulariosEventos(frmUno1, frmDos1);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFrmUno_Click(object sender, EventArgs e)
        {
            frmUno1.ShowDialog();
        }

        private void btnFrmDos_Click(object sender, EventArgs e)
        {
            frmDos1.ShowDialog();
        }
    }
}