using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipalLogs
{
    
    public class Logs
    {
        public delegate void MovementEventHandler(string movement);
        public event MovementEventHandler MovementOccurred;

        
        public void MovimientoOcurrido(string movimientio) 
        {
            StringBuilder sb = new StringBuilder(); 
            sb.Append(movimientio); 
            File.WriteAllText("movimientosUsuario.txt", sb.ToString());
        }

        public void OnMovimientoOcurrido(string movimiento) 
        {
            if (MovementOccurred != null)
            {
                MovementOccurred(movimiento);
            }
        }
    }
}
