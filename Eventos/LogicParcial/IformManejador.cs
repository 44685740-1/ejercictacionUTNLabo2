using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicParcial
{
    public interface IformManejador
    {
        void FormOpen();

        void FormClose();

        void OnFrmAbierto(string nombreForm);

        void OnFrmCerrado(string nombreForm);
        
    }
}
