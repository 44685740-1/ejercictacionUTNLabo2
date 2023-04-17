using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JugadorEquipo
{
    public class Equipo
    {
        private short _cantidadDeJuagdores;
        private List<Jugador> _jugadores;
        private string _nombre;


        private Equipo()
        {
            _jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadJugadores,string nombre) 
        :this()
        {
            this._nombre = nombre;  
            this._cantidadDeJuagdores = cantidadJugadores;
        }

        public static bool operator +(Equipo equipo, Jugador jugador) 
        {
            //TODO: PROBLEMA COUNT ESTA EN CERO
            if (equipo._jugadores.Count < equipo._cantidadDeJuagdores)
            {
                foreach (Jugador item in equipo._jugadores)
                {
                    if (item == jugador)
                    {
                        return false;
                    }
                }
                equipo._jugadores.Add(jugador);
                return true;
            }
            return false;
        }    
       

    }
}
