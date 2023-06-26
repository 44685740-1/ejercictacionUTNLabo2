using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaParcial
{
    public interface ImanejadorEventosFrm
    {
        void ActividadUsuarioEventHandlerFuncion(string usuariaNombre, string frmNombre, bool estaAbierto);
        void FrmAbierto(object sender, EventArgs e);
        void FrmCerrado(object sender, EventArgs e);
    }
}
