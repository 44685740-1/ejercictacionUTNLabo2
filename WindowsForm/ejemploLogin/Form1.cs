namespace ejemploLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //unico usuario que puede ingresar
            //Usuario: ahuitz sin ser Case Sensitive
            //Contraseña: Caracciolo si es case Sensitive

            string usuario = this.txtUsuario.Text;
            string contrasenia = this.texContrasenia.Text;

            string usuarioLowercase = usuario.ToLower();

            if (usuarioLowercase == "ahuitz" && contrasenia == "Caracciolo")
            {
                MessageBox.Show("BIENVENIDO");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}