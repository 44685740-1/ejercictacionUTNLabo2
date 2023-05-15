namespace ejemploHerenciaFrmDesign
{
    //no se puede hacer una instancia de una clase abstracta
    public  partial class frmPadre : Form
    {
        public frmPadre()
        {
            InitializeComponent();
        }

        public virtual void btnIr_Click(object sender, EventArgs e)
        {
            frmHijo frmHijo = new frmHijo();    
            frmHijo.ShowDialog();   
        }
    }
}