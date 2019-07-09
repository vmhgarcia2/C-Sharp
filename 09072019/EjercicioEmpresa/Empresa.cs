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
        private string nombre;
        private string anyodefundacion;
        private List<Empleado> listaEmpleados;

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
        public List<Empleado> ListaEmpleados
        {
            get => listaEmpleados;
            set => listaEmpleados = value;
        }

        public static void serializar(Empresa empresa,string directorio)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(directorio, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, empresa);
            stream.Close();
        }
        public static Empresa deserializar(string ruta)
        {
            Empresa empresa;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            empresa = (Empresa)formatter.Deserialize(stream);
            stream.Close();
            return empresa;
        }
    }
}
