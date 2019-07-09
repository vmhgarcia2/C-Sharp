using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
//La clase empleado tendrá como mínimo cuatro atributos: 
//nombre de tipo String, apellidos de tipo String, fechanacimiento de tipo String y fechaContrato de tipo String 
namespace EjercicioEmpresa
{
    [Serializable]
    class Empleado
    {
        private string nombre="";
        private string apellidos;
        private string fechaNacimiento;
        private string fechaContrato;
        private string empresa;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellidos
        {
            get => apellidos;
            set => apellidos = value;
        }
        public string FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        public string FechaContrato
        {
            get => fechaContrato;
            set => fechaContrato = value;
        }
        public string Empresa
        {
            get => empresa;
            set => empresa = value;
        }

        public static void serializar(Empleado empleado, string directorio)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(directorio, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, empleado);
                stream.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("No se puede crear el empleado");
            }
        }
        public static Empleado deserializar(string ruta)
        {
            Empleado empleado=new Empleado();
            IFormatter formatter = new BinaryFormatter();
            try
            {
                Stream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                empleado = (Empleado)formatter.Deserialize(stream);
                stream.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("No se puede localizar al empleado");
            }
            return empleado;
        }
    }
}
