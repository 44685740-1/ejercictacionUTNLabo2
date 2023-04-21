using System.Text;

namespace PersonaEstudienteProfesor
{
    public class persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _dni;

        //properties

        public string Nombre {
            get { return _nombre;}
            set { _nombre = value; }    
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }


        public persona(string nombre, string apellido, int edad, int dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._dni = dni;
        }

        public string Mostrar() 
        {
            StringBuilder personaSB = new StringBuilder();
            personaSB.AppendLine($"nombre {this._nombre}");
            personaSB.AppendLine($"apellido {this._apellido}");
            personaSB.AppendLine($"edad {this._edad}");
            personaSB.AppendLine($"dni {this._dni}");

            return personaSB.ToString();
        }

    }
}