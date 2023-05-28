namespace ejemploMDI
{
    public partial class frmContenedor : Form
    {
        public frmContenedor()
        {
            InitializeComponent();
        }

        private void frmContenedor_Load(object sender, EventArgs e)
        {

        }

        private void ventanasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventanasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            List<Productos> lista = new List<Productos>();
            frmLsitados frmlistadoHijo = new frmLsitados();
            frmContenedor frmContenedor = new frmContenedor();  
            frmlistadoHijo.MdiParent = frmContenedor;
            frmlistadoHijo.Show();
        }

        private void frmContenedor_Load_1(object sender, EventArgs e)
        {

        }
    }
}