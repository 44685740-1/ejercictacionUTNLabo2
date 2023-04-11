using System.Text;

namespace Veterinaria
{
    public class Cliente
    {
        //declaro los atributos privados
        private string _Domicilio;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private Mascota _mascota;

        public Cliente(string domicilio, string nombre, string apellido, string telefono)
        {
            this._nombre = nombre;
            this._apellido = apellido;  
            this._telefono = telefono;
            this._Domicilio = domicilio;
        }   

        //todos los get al estilo c#, solo lectura es una forma de encapsular
        public string Domicilio { get { return _Domicilio; } }
        public string Nombre { get { return _nombre; } }    
        public string Apellido { get { return _apellido; } }
        public string telefono { get { return _telefono; } }

        public Mascota Mascota { get { return _mascota;} set { _mascota = value;} }
        
        public string MostrarCliente() 
        {
            StringBuilder clienteSB = new StringBuilder();

            clienteSB.AppendLine($"nombre {this.Nombre}");
            clienteSB.AppendLine($"apellido {this.Apellido}");
            clienteSB.AppendLine($"telefono {this.telefono}");
            clienteSB.AppendLine($"domicilio {this.Domicilio}");
            clienteSB.AppendLine($"{this.Mascota.MostrarMascota()}");
            return clienteSB.ToString();    
        }


    }
}