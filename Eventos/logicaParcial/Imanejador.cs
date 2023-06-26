using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaParcial
{
    public interface Imanejador
    {
        void frmcerradoNotificacion(object sender, EventArgs e);

        void OnfrmAbierto(string nombreForm);

        void OnFormCerrado(string nombreForm);
    }
}
