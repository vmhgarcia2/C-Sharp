using System;
using System.IO; //Para poder manejar ficheros

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para poder poner las barras "\" habría que poner la "@" delante del 
            //if(Directory.Exists("C:/tests/"))
            //{
            //    Console.WriteLine("El directorio existe");
            //}
            //else
            //{
            //    Console.WriteLine("No existe");
            //    Directory.CreateDirectory("C:/tests/");
            //}

            
            //string[] directorios = Directory.GetDirectories("C:/");
            //foreach(string d in directorios)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine(d);
            //    try
            //    {
            //        string[] ficheros = Directory.GetFiles(d);
            //        foreach (string f in ficheros)
            //        {
            //            Console.WriteLine("           ---> " + f);

            //        }
            //    }
            //    catch (UnauthorizedAccessException e)
            //    {
            //    }
            //    catch (DirectoryNotFoundException e)
            //    {
            //    }
            //    catch (IOException e)
            //    {
            //    }
            //}

            mostrarDirectoriosyArchivos(@"C:\data\"); 
            mostrarDirectoriosyArchivos(@"C:\ProgramData");
        }

        public static void controlErrores(Exception e)
        {
            if (e != null)
            {
                Console.Write("Ha ocurrido el siguiente error:");
                Console.WriteLine(e.GetType().Name);

            }
        }

        //Recursividad
        public static void mostrarDirectoriosyArchivos(string directorio)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(directorio))
                {
                    Console.WriteLine(d);
                    try
                    {
                        foreach (string f in Directory.GetFiles(d))
                        {
                            Console.WriteLine("           ---> " + f);
                        }
                    }
                    catch (Exception e)
                    {
                        controlErrores(e);
                    }
                    mostrarDirectoriosyArchivos(d);
                }
            }
            catch (Exception e)
            {
                controlErrores(e);
            }
        }
    }


}
