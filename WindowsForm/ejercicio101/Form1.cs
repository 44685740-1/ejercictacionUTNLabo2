namespace ejercicio101
{
    public partial class fmr1 : Form
    {
        public fmr1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMateria.Items.Add("programacion ||");
            cmbMateria.Items.Add("Estadistica");
            cmbMateria.Items.Add("Matematica");
        }
    }
}