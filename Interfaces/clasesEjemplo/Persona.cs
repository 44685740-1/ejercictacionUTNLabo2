namespace clasesEjemplo
{
    public class Persona:IMensaje
    {
        private string _nombre;
        private string _mail;
        private int _edad;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public int Edad { get => _edad; set => _edad = value; }

        public Persona(string nombre, string mail, int edad)
        {
            _nombre = nombre;
            _mail = mail;
            _edad = edad;
        }

        
        public string EscribirMensaje()
        {
            return "soy persona";
        }

        

    }
}