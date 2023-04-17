using System.Text;

namespace JugadorEquipo
{
    public class Jugador
    {
        private string _nombre;
        private int _dni;
        private int _partidosJuagdos;
        private float _promedioGoles;
        private int _totalGoles;

        private Jugador() 
        {
            
        }

        public Jugador(int dni, string nombre)
        {
            this._nombre = nombre;
            this._dni = dni;
        }

        public Jugador(string nombre, int dni, int partidosJuagdos, int totalGoles)
        //reutilizo codigo del constrcutor de arriba
        : this(dni,nombre)
        {
            this._partidosJuagdos = partidosJuagdos;
            this._totalGoles = totalGoles;
        }

        public float GetPromedioGoles() 
        {
            if (_partidosJuagdos == 0)
            {
                return 0;
            }
            this._promedioGoles = (float)_totalGoles / _partidosJuagdos;
            return _promedioGoles;
        }

        public string MostarDatos() 
        {
            StringBuilder jugadorSB = new StringBuilder();
            jugadorSB.AppendLine($"nombre {this._nombre}");
            jugadorSB.AppendLine($"dni {this._dni}");
            jugadorSB.AppendLine($"partidos jugados {this._partidosJuagdos}");       
            jugadorSB.AppendLine($"promedio de goles {GetPromedioGoles()}");
            jugadorSB.AppendLine($"total goles {this._totalGoles}");
            return jugadorSB.ToString();
        }

        public static bool operator ==(Jugador jugadorUno, Jugador jugadorDos) 
        {
            //validacion de que no sean null
            if (jugadorUno is not null && jugadorDos is not null )
            {
                return jugadorUno._dni == jugadorDos._dni;
            }
            return false;
           
        }

        public static bool operator !=(Jugador jugadorUno, Jugador jugadorDos)
        {
            return (jugadorUno._dni == jugadorDos._dni);
        }
    }
}