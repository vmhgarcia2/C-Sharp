using System;
using System.IO;

//Queremos construir una aplicación que permita almacenar la información relevante sobre empresas y sus empleados:
//La clase empresa tendrá como mínimo dos atributos: nombre de tipo String y anyodefundacion de tipo string.
//La clase empleado tendrá como mínimo cuatro atributos: nombre de tipo String, apellidos de tipo String, fechanacimiento de tipo String y fechaContrato de tipo String 
//El programa mostrará un menu que tendrá las siguientes opciones:
//Crear nueva empresa.
//Añadir empleado a empresa existente.
//Listado de empresas.
//Informacion de una empresa en particular.
//Crear empleado.
//Listado de empleados.
//Información de un empleado en particular.
//Salir.Se deberá implementar todo la funcionalidad en las clases para que la aplicación sea funciona.


namespace EjercicioEmpresa
{
    class Program
    {
        const string directorio = "C:/tests/EjercicioEmpresa/";
        static void Main(string[] args)
        {
            comprobarDirectorio(directorio);
            ConsoleKeyInfo tecla;
            do
            {
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("==============");
                Console.WriteLine("1. Crear nueva empresa");
                Console.WriteLine("2. Añadir empleado a empresa existente");
                Console.WriteLine("3. Listado de empresas");
                Console.WriteLine("4. Informacion de una empresa en particualar");
                Console.WriteLine("5. Crear empleado");
                Console.WriteLine("6. Listado de empleados");
                Console.WriteLine("7. Información de un empleado en particular");
                Console.WriteLine("8. Salir");
                tecla = (Console.ReadKey());
                switch (tecla.KeyChar)
                {
                    case '1':
                        AñadirEmpresa();
                        Console.WriteLine("");
                        break;
                    case '2':
                        break;
                    case '3':
                        ListarEmpresas();
                        Console.WriteLine("");
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                }
                Console.WriteLine("");
            }
            while (tecla.KeyChar != '8');
        }

        public static void comprobarDirectorio(string directorio)
        {
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
        }
        public static void AñadirEmpresa()
        {
            Empresa empresa = new Empresa();
            Console.Write("Introduce el nombre de la empresa: ");
            empresa.Nombre = Console.ReadLine();
            Console.Write("Introduce año en que se fundó {0}: ", empresa.Nombre);
            empresa.Anyodefundacion = Console.ReadLine();
            Directory.CreateDirectory(directorio +  empresa.Nombre);
            Empresa.serializar(empresa, directorio + empresa.Nombre + "/" + "datosEmpresa");
        }
        public static void ListarEmpresas()
        {
            Empresa empresa;
            Console.WriteLine("LISTADO EMPRESAS");
            Console.WriteLine("=================");
            foreach (string d in Directory.GetDirectories(directorio))
            {
                empresa = Empresa.deserializar(d + "/datosEmpresa");
                Console.WriteLine("Empresa: " + empresa.Nombre);
                Console.WriteLine("Año fundación: " + empresa.Anyodefundacion);
            }
        }
    }
}
