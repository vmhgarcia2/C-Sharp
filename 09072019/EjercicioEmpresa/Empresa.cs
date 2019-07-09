using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

//La clase empresa tendrá como mínimo dos atributos: nombre de tipo String y anyodefundacion de tipo string.
namespace EjercicioEmpresa
{
    [Serializable]
    class Empresa
    {
        private string nombre="";
        private string anyodefundacion;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Anyodefundacion
        {
            get => anyodefundacion;
            set => anyodefundacion = value;
        }

        public static void serializar(Empresa empresa,string directorio)
        {
            IFormatter formatter = new BinaryFormatter();
            try
            {
                Stream stream = new FileStream(directorio, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, empresa);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede encontrar la empresa");
            }
        }
        public static Empresa deserializar(string ruta)
        {
            Empresa empresa=new Empresa();
            try { 
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                empresa = (Empresa)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede encontrar la empresa");
            }
            return empresa;
        }
    }
}
