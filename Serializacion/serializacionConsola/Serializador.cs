
using ServiceStack.Text.Common;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CsvHelper;
using XmlSerializer = System.Xml.Serialization.XmlSerializer;
using JsonSerializer = System.Text.Json.JsonSerializer;
using CsvWriter = CsvHelper.CsvWriter;
using CsvReader = CsvHelper.CsvReader;

namespace serializacionConsola
{
    public class Serializador<T>
    {
        public void SerializarXML(T entidad, string nombreArchivo) 
        {
            using (StreamWriter streamWriter = new StreamWriter(nombreArchivo)) 
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T)); 
                xmlSerializer.Serialize(streamWriter, entidad); 
            }
        }


        public T DeserializarXMl(string nombreArchivo)
        {
            T Objetodeserializado;

            using (StreamReader sr = new StreamReader(nombreArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                Objetodeserializado = (T?)xmlSerializer.Deserialize(sr);
            }
            return (T)Objetodeserializado;
        }


        public void SerializarJSON(T entidad, string nombreArchivo) 
        {
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(entidad, options);
            File.WriteAllText(nombreArchivo, jsonString);
        }

        public T DeserializarJSON(string nombreArchivo) 
        {
            T Objetodeserializado;  
            string jsonString = File.ReadAllText(nombreArchivo);
            Objetodeserializado = JsonSerializer.Deserialize<T>(jsonString);
            return Objetodeserializado;
        }

        public void SerializarCSV<T>(IEnumerable<T> entidad, string nombreArhcivo) 
        {
            StreamWriter streamWriter = new StreamWriter(nombreArhcivo);
            using (var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture)) 
            {
                csv.WriteRecords(entidad);
            }
            streamWriter.Close();   
        }

        public List<T> DeserializarCSV<T>(string nombreArchivo) 
        {
            List<T> Objetodeserializado;  
            StreamReader streamReader = new StreamReader(nombreArchivo);
            using (var csv = new CsvReader(streamReader,CultureInfo.InvariantCulture)) 
            {
                Objetodeserializado = csv.GetRecords<T>().ToList();  
            }
            streamReader.Close();
            return Objetodeserializado;
        }                 
        
    }
}
