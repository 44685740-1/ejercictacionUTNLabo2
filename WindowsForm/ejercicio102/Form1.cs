using Ingresantes;
namespace ejercicio102
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int edad = (int)NumericUpEdad.Value;
            string pais = listBoxPaises.Text;
            string genero;
            string curso;
            genero = " ";
            if (radioBtnFemenino.Checked)
            {
                genero = radioBtnFemenino.Text;
            }
          
            if(radioBtnMasculino.Checked) 
            {
               genero =radioBtnMasculino.Text;
            }
               
            if (radioBtnNoBinario.Checked)
            {
               genero = radioBtnNoBinario.Text;
            }

            curso = " ";
            if (checkBoxcSharp.Checked)
            {
                curso += checkBoxcSharp.Text;
            }

            if (checkBoxCmas.Checked)
            {
                curso += checkBoxCmas.Text;
            }

            if (CheackBoxJavaScript.Checked)
            {
                curso += CheackBoxJavaScript.Text;
            }

            Ingresante nuevoIngresante = new Ingresante(curso,direccion,edad,genero,nombre,pais);
            MessageBox.Show(nuevoIngresante.Mostrar());
        }
    }
}