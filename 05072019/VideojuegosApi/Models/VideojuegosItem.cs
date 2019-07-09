using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace VideojuegosApi.Models
{
    [Serializable]
    public class VideojuegosItem
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public int anyoLanzamiento { get; set; }
        public string genero { get; set; }
        public byte edadMinima { get; set; }
        public string companyia { get; set; }

        public static void serializar(VideojuegosItem item)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:/tests/" + item.titulo, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, item);
            stream.Close();
        }
        public static VideojuegosItem deserializar(string f)
        {
            VideojuegosItem vj;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(f, FileMode.Open, FileAccess.Read);
            vj = (VideojuegosItem)formatter.Deserialize(stream);
            stream.Close();
            return vj;
        }
    }
}