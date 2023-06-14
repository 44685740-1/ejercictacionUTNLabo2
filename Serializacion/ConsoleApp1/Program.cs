using System.Text.Json;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class Program
    {
        public class Contador
        {
            public int i = 0;
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set;}

            public int Legajo { get; set; }

            public Persona(string nombre, string apellido, int legajo)
            {
                Nombre = nombre;
                Apellido = apellido;
                Legajo = legajo;
            }

            public Persona() : this("", "", 0) { }

            public override string ToString()
            {
                return $"{Apellido}, {Nombre}";
            }
        }

        public class Serializator<T>
        {
            private string _filename;

            public Serializator(string filename)
            {
                _filename = filename;
            }

            public T Deserializar()
            {
                object deserializado;

                using (StreamReader sr = new StreamReader(_filename))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    
                    deserializado = xmlSerializer.Deserialize(sr);
                }

                return (T)deserializado;
            }
            public void Serializar(T persona)
            {
                using (StreamWriter streamWriter = new StreamWriter(this._filename))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    
                    xmlSerializer.Serialize(streamWriter, persona);
                }
            }
        
            public void SerializarJSON(T objeto)
            {
                var options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string jsonString = JsonSerializer.Serialize(objeto, options);

                Console.WriteLine(jsonString);

                var listaDeserializada = JsonSerializer.Deserialize<T>(jsonString);

                //foreach (T obj in listaDeserializada)
                //{
                //    Console.WriteLine(obj);
                //}
            }
        }
        public static void Serializar<T>(T persona, string filename)
        {
            using (StreamWriter streamWriter = new StreamWriter(filename))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                xmlSerializer.Serialize(streamWriter, persona);
            }
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var personas = new List<Persona>();

            var persona = new Persona("Maria", "Solis", 666);
            var personaDos = new Persona("Mariela", "Juarez", 333);

            personas.Add(personaDos);
            personas.Add(persona);

            //Serializar<Persona>(persona, "persona.xml");

            //Serializar<List<Persona>>(personas, "persona.xml");

            var serializator = new Serializator<List<Persona>>("persona.xml");
            
            List<Persona> lista = serializator.Deserializar();

            foreach (var item in lista)
            {
                Console.WriteLine(item.Nombre);
            }

            serializator.SerializarJSON(personas);














            //var contador = new Contador();



            //for (int i = 0; i < 10; i++)
            //{
            //    var task1 = new Task(() =>
            //    {
            //        contador.i = 100;
            //        Console.WriteLine($"1.0 {contador.i}");
            //        SumarTask(contador);
            //        Console.WriteLine($"1.1 {contador.i}");
            //    });

            //    var task2 = new Task(() =>
            //    {

            //        contador.i = 9;
            //        SumarTask(contador, 3000);
            //        Console.WriteLine($"2 {contador.i}");
            //    });

            //    task1.Start();
            //    task2.Start();
            //    //task2.Wait();
            //    //task1.Wait();
            //    Task.WaitAll(task2, task1);
            //    //Console.WriteLine(contador.i);
            //}

            //Console.WriteLine(contador.i);
            //Console.ReadLine();
        }

        public static void SumarTask(Contador contador)
        {
            var random = new Random();
            var min = 100;
            var max = random.Next(min, 2000);
            Thread.Sleep(max);

            contador.i++;
        }

        public static void SumarTask(Contador contador, int max)
        {
            var random = new Random();
            var min = 100;
            var _max = random.Next(min, max);
            Thread.Sleep(_max);

            contador.i++;
        }
    }
}