using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
                Console.WriteLine("******************");
                Console.WriteLine("* MENU PRINCIPAL *");
                Console.WriteLine("******************");
                Console.WriteLine("1. Crear nueva empresa");
                Console.WriteLine("2. Crear empleado");
                Console.WriteLine("3. Añadir empleado a empresa existente");
                Console.WriteLine("4. Listado de empresas");
                Console.WriteLine("5. Listado de empleados");
                Console.WriteLine("6. Informacion de una empresa en particular");
                Console.WriteLine("7. Información de un empleado en particular");
                Console.WriteLine("8. Salir");
                Console.WriteLine("");
                Console.Write("Indica una opción para continuar: ");
                tecla = (Console.ReadKey());
                Console.WriteLine("");
                switch (tecla.KeyChar)
                {
                    case '1':
                        Console.WriteLine("");
                        CrearEmpresa();
                        Console.WriteLine("");
                        break;
                    case '2':
                        Console.WriteLine("");
                        CrearEmpleado();
                        Console.WriteLine("");
                        break;
                    case '3':
                        Console.WriteLine("");
                        AnyadirEmpleado();
                        Console.WriteLine("");
                        break;
                    case '4':
                        Console.WriteLine("");
                        ListarEmpresas();
                        Console.WriteLine("");
                        Console.WriteLine("Pulsa cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case '5':
                        Console.WriteLine("");
                        ListarEmpleados();
                        Console.WriteLine("");
                        Console.WriteLine("Pulsa cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case '6':
                        Console.WriteLine("");
                        DatosEmpresa();
                        Console.WriteLine("");
                        Console.WriteLine("Pulsa cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case '7':
                        Console.WriteLine("");
                        DatosEmpleado();
                        Console.WriteLine("");
                        Console.WriteLine("Pulsa cualquier tecla para continuar");
                        Console.ReadKey();
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
            if (!Directory.Exists(directorio + "empleadosSinEmpresa"))
            {
                Directory.CreateDirectory(directorio + "empleadosSinEmpresa");
            }
        }
        public static void CrearEmpresa()
        {
            bool encontrada = false;
            Empresa empresa = new Empresa();
            Console.Write("Introduce el nombre de la empresa: ");
            empresa.Nombre = Console.ReadLine();
            foreach (string dir in Directory.GetDirectories(directorio))
            {
                if(dir.Split(directorio)[1].ToLower()==empresa.Nombre.ToLower())
                {
                    encontrada = true;
                }
            }
            if (encontrada)
            {
                Console.WriteLine("");
                Console.WriteLine("Ya existe una empresa con ese nombre");
                CrearEmpresa();
            }
            else
            {
                Console.Write("Introduce año en que se fundó {0}: ", empresa.Nombre);
                empresa.Anyodefundacion = Console.ReadLine();
                Directory.CreateDirectory(directorio + empresa.Nombre);
                Empresa.serializar(empresa, directorio + empresa.Nombre + "/datosEmpresa");
            }
        }
        
        public static void AnyadirEmpleado()
        {
            int hay = Directory.GetFiles(directorio + "empleadosSinEmpresa/").Length;
            if (hay > 0)
            {
                Empleado empleado = new Empleado();
                Console.WriteLine("Indica el nombre de la empresa donde quieres añadir el empleado: ");
                ListarEmpresas();
                empleado.Empresa = Console.ReadLine();

                Empresa empresa = Empresa.deserializar(directorio + empleado.Empresa + "/datosEmpresa");
                Console.WriteLine();
                if (empresa.Nombre.Length > 0)
                {
                    ListarEmpleadosSinEmpresa();
                    Console.WriteLine("");
                    Console.Write("Indica el nombre y apellidos del empleado que quieres añadir a la empresa: ");
                    string emp = Console.ReadLine();
                    empleado = Empleado.deserializar(directorio + "empleadosSinEmpresa/" + emp.Replace(" ", ""));
                    if (empleado.Nombre.Length > 0)
                    {
                        Console.Write("Indica la fecha del contrato: ");
                        empleado.FechaContrato = Console.ReadLine();
                        empleado.Empresa = empresa.Nombre;
                        Empleado.serializar(empleado, directorio + empresa.Nombre + "/" + empleado.Nombre + empleado.Apellidos);
                        File.Delete(directorio + "empleadosSinEmpresa/" + emp.Replace(" ", ""));
                    }

                }
                else
                {
                    AnyadirEmpleado();
                }
            }
            else
            {
                Console.WriteLine("No hay empleados sin empresa");
            }
        }
        public static void ListarEmpresas()
        {
            Empresa empresa;
            Console.WriteLine("********************");
            Console.WriteLine("* LISTADO EMPRESAS *");
            Console.WriteLine("********************");
            foreach (string d in Directory.GetDirectories(directorio))
            {
                if (d.Split(directorio)[1] != "empleadosSinEmpresa")
                {
                    empresa = Empresa.deserializar(d + "/datosEmpresa");
                    Console.WriteLine("- " + empresa.Nombre);
                }
            }
        }
        public static void DatosEmpresa()
        {
            Empresa empresa = new Empresa();
            Console.WriteLine("Indica el nombre de la empresa de la que quieres obtener los datos: ");
            ListarEmpresas();
            Console.WriteLine("");
            empresa.Nombre = Console.ReadLine();
            Console.WriteLine("***********************");
            Console.WriteLine("* DATOS DE LA EMPRESA *");
            Console.WriteLine("***********************");
            empresa = Empresa.deserializar(directorio + empresa.Nombre + "/datosEmpresa");
            if (empresa.Nombre.Length > 0)
            {
                Console.WriteLine("Empresa: " + empresa.Nombre);
                Console.WriteLine("Año fundación: " + empresa.Anyodefundacion);
            }
        }

        public static void DatosEmpleado()
        {
            Empleado empleado = new Empleado();
            Console.WriteLine("Indica el nombre del empleado del que quieres obtener los datos: ");
            ListarEmpleados();
            Console.WriteLine("");
            empleado.Nombre = Console.ReadLine();
            Console.WriteLine("**********************");
            Console.WriteLine("* DATOS DEL EMPLEADO *");
            Console.WriteLine("**********************");
            foreach (string f in Directory.GetDirectories(directorio))
            {
                foreach (string s in Directory.GetFiles(f))
                {
                    if (empleado.Nombre.Replace(" ","")==s.Split(f + "\\")[1])
                    {
                        empleado = Empleado.deserializar(s);
                        Console.WriteLine("Empleado: " + empleado.Nombre + " " + empleado.Apellidos);
                        Console.WriteLine("Empresa: " + empleado.Empresa);
                        Console.WriteLine("Fecha de nacimiento: " + empleado.FechaNacimiento);
                        Console.WriteLine("Fecha de contrato: " + empleado.FechaContrato);
                    }
                }
            }
        }
        public static void CrearEmpleado()
        {
            Empleado empleado = new Empleado();
            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine("* DATOS DEL EMPLEADO *");
            Console.WriteLine("**********************");
            Console.Write("Nombre: ");
            empleado.Nombre = Console.ReadLine();
            Console.Write("Apellidos: ");
            empleado.Apellidos = Console.ReadLine();
            Console.Write("Fecha de nacimiento: ");
            empleado.FechaNacimiento = Console.ReadLine();
            Empleado.serializar(empleado, directorio + "empleadosSinEmpresa/" + empleado.Nombre + empleado.Apellidos);
        }
        public static void ListarEmpleados()
        {
            SortedDictionary<string, string> diccionario = new SortedDictionary<string, string>();
            Console.WriteLine("********************");
            Console.WriteLine("* LISTADO EMPLEADOS *");
            Console.WriteLine("********************");
            foreach (string dir in Directory.GetDirectories(directorio))
            {
                foreach(string f in Directory.GetFiles(dir))
                {
                    if (f.Split("\\")[1] != "datosEmpresa")
                    {
                        Empleado e = Empleado.deserializar(f);
                        diccionario.Add(e.Nombre + e.Apellidos, e.Nombre + " " + e.Apellidos);
                    }
                }
            }
            foreach (var st in diccionario)
            {
                Console.WriteLine(st.Value);
            }
        }

        public static void ListarEmpleadosSinEmpresa()
        {
            SortedDictionary<string, string> diccionario = new SortedDictionary<string, string>();
            Console.WriteLine("********************");
            Console.WriteLine("* LISTADO EMPLEADOS *");
            Console.WriteLine("********************");
            foreach (string f in Directory.GetFiles(directorio + "empleadosSinEmpresa/"))
            {
                if (f.Split("empleadosSinEmpresa/")[1] != "datosEmpresa")
                {
                    Empleado e = Empleado.deserializar(f);
                    diccionario.Add(e.Nombre + e.Apellidos, e.Nombre + " " + e.Apellidos);
                }
            }
            foreach (var st in diccionario)
            {
                Console.WriteLine(st.Value);
            }
        }

    }
}
