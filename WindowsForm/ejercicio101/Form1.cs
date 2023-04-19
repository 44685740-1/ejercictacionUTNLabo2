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

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = txtNombre.Text;
            string apellido;
            apellido = txtApellido.Text;
            string materia;
            materia = cmbMateria.Text;

            frm2 form2 = new frm2(nombre,apellido,materia);
            form2.ShowDialog();
        }
    }
}