namespace LogicaParcial
{
    public class Logs
    {
        public delegate void ActividadUsuarioEventHandler(string usuarioNombre, string frmNombre, bool estaAbierto);
        public static event ActividadUsuarioEventHandler ActividadUsuarioEvent;

        public static void LoggearActividadUsuario(string usuarioNombre, string frmNombre, bool estaAbierto)
        {
            ActividadUsuarioEvent?.Invoke(usuarioNombre, frmNombre, estaAbierto);      
        }
    }
}