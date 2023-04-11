using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Mascota
    {
        private string _nombreMascota;
        private string _especie;
        private DateTime _fechaNacimientoMascota;
        private string _vacunacion;

        public Mascota(string nombreMascota, string especie, DateTime fechaNacimientoMascota, string vacunacion)
        {
            this._nombreMascota = nombreMascota;
            this._especie = especie;
            this._fechaNacimientoMascota = fechaNacimientoMascota;
            this._vacunacion = vacunacion;
        }

        public string NombreMascota { get { return _nombreMascota;} }

        public string Especie { get { return _especie; } }

        public DateTime FechaNacimientoMascota { get { return _fechaNacimientoMascota;} }

        public string Vacunacion { get { return _vacunacion;} }

        public string MostrarMascota() 
        {
            StringBuilder mascotaSB = new StringBuilder();
            mascotaSB.AppendLine();
            mascotaSB.AppendLine();
            mascotaSB.AppendLine($"nombre mascota {this.NombreMascota}");
            mascotaSB.AppendLine($"especie mascota {this.Especie}");
            mascotaSB.AppendLine($"fecha nacimeinto mascota {this._fechaNacimientoMascota}");
            mascotaSB.AppendLine($"vacunacion {this.Vacunacion}");
            return mascotaSB.ToString();
        }
    }
}
