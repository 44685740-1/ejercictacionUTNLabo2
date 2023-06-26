using LogicaParcial;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace vistaLogs
{
    public partial class Form1 : Form,ImanejadorEventosFrm
    {
        string usuario;

        public Form1()
        {
            InitializeComponent();
            ConexionSQL conexionSQL = new ConexionSQL();
            conexionSQL.Abrir();
            this.usuario = "Ahuitz";
            this.Name = "Form1";
            this.Load += FrmAbierto;
            this.FormClosed += FrmCerrado;
            Logs.ActividadUsuarioEvent += ActividadUsuarioEventHandlerFuncion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnfrmUno_Click(object sender, EventArgs e)
        {
            frmUno frmUno = new frmUno();
            frmUno.ShowDialog();    
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            frmDos frmDos = new frmDos();   
            frmDos.ShowDialog();
        }

        public void ActividadUsuarioEventHandlerFuncion(string usuariaNombre, string frmNombre, bool estaAbierto)
        {
            string accion;
            if (estaAbierto)
            {
                accion = "Abrio";
                movimientosUsuarioHandler movimientosUsuarioHandler = new movimientosUsuarioHandler();
                movimientosUsuarioHandler.add(usuariaNombre, accion, frmNombre);
            }
            else
            {
                accion = "Cerro";
                movimientosUsuarioHandler movimientosUsuarioHandler = new movimientosUsuarioHandler();
                movimientosUsuarioHandler.add(usuariaNombre, accion, frmNombre);
                
            }
            
        }

        public void FrmAbierto(object sender, EventArgs e)
        {
            Logs.LoggearActividadUsuario(usuario, this.Name, true);
            Logs.ActividadUsuarioEvent -= ActividadUsuarioEventHandlerFuncion;
        }

        public void FrmCerrado(object sender, EventArgs e)
        {
            Logs.LoggearActividadUsuario(usuario, this.Name, false);
            Logs.ActividadUsuarioEvent -= ActividadUsuarioEventHandlerFuncion;
        }
    }
}