using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logsAbrirCerrasFrm
{
    public interface Imanejador
    {
        //metodos para los formularios que no son el principal
        void ChildForm2_FormClosed(object sender, FormClosedEventArgs e);

        void OnFormOpened(string formName);

        void OnFormClosed(string formName);
    }
}
