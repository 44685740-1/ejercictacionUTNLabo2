using animales;
namespace PolimorfismoEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //animal animal = new animal();
            Gato gato = new Gato();
            Perro perro = new Perro();

            //animal.Saludar();
            //perro.Saludar();
            //gato.Saludar();
            List<animal> animales = new List<animal>();
            //animales.Add(animal);
            animales.Add(perro);
            animales.Add(gato);

            foreach (animal item in animales)
            {
                item.Saludar(); 
            }
        }
    }
}