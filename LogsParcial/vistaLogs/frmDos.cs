using LogicaParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistaLogs
{
    public partial class frmDos : Form,ImanejadorEventosFrm
    {
        string usuario;
        public frmDos()
        {
            InitializeComponent();
            this.usuario = "Ahuitz";
            this.Name = "frmDos";
            this.Load += FrmAbierto;
            this.FormClosed += FrmCerrado;
            Logs.ActividadUsuarioEvent += ActividadUsuarioEventHandlerFuncion;
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
