namespace bibliotecaLogicaProblemaParcial
{
    public class Productos
    {
        private string _nombre;
        private int _precio;
        private int _cantdiad;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public int Cantdiad { get => _cantdiad; set => _cantdiad = value; }

        public Productos(string nombre, int precio, int cantdiad)
        {
            _nombre = nombre;
            _precio = precio;
            _cantdiad = cantdiad;
        }

       
    }
}