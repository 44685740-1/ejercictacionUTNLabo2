using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromulaUno
{
    public class Competencia
    {
        private short _cantidadCompetidores;
        private short _cantdiadVueltas;
        private List<AutoF1> _competidores;

        //solo en este constructor privado inicializo la lista
        private Competencia() 
        {
            this._competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) 
        :this()
        {
            this._cantdiadVueltas = cantidadVueltas;
            this._cantidadCompetidores = cantidadCompetidores;
        }

        public string Mostrar() 
        {
            StringBuilder competenciaSB = new StringBuilder();
            competenciaSB.AppendLine($"cantidad de competidores {this._cantidadCompetidores}");
            competenciaSB.AppendLine($"cantidad de vueltas {this._cantdiadVueltas}");
            competenciaSB.AppendLine($"competidores {this._competidores}");

            return competenciaSB.ToString();
        }

        public static bool operator ==(Competencia competenciaA, AutoF1 autoB) 
        {
            foreach (AutoF1 item in competenciaA._competidores)
            {
                if (autoB == item)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia competenciaA, AutoF1 autoB)
        {
            foreach (AutoF1 item in competenciaA._competidores)
            {
                if (autoB == item)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator +(Competencia competenciaA, AutoF1 autoB)
        {
            if (competenciaA._competidores.Count < competenciaA._cantidadCompetidores && competenciaA != autoB)
            {
                competenciaA._competidores.Add(autoB);
                autoB.enCompetencia = true;
                autoB.vueltasRestantes = competenciaA._cantdiadVueltas;
                Random rdn = new Random();
                autoB.CantidadCombustible = (short)rdn.Next(15,100);
                return true;
            }
            return false;
        }


        public static bool operator -(Competencia competenciaA, AutoF1 autoB)
        {
            if (competenciaA == autoB)
            {
                competenciaA._competidores.Remove(autoB);
                return true;
            }
            return false;
        }
    }
}
