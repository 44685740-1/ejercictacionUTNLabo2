namespace ejemploHerenciaDeForms
{
    public partial class frmPadre : Form
    {
        public frmPadre()
        {
            InitializeComponent();
        }

        private void btnFrmHijo_Click(object sender, EventArgs e)
        {
            frmHijo frmHijo = new frmHijo();
            frmHijo.ShowDialog();
        }
    }
}