using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;

namespace Diccionario
{
    class Program
    {
        public static string lineas;
        static void Main(string[] args)
        {
            SortedDictionary<string, string> diccionario = new SortedDictionary<string, string>();
            ConsoleKeyInfo opcion;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("=====");
                Console.WriteLine("1. Introducir palabra y definición");
                Console.WriteLine("2. Buscar palabra");
                Console.WriteLine("3. Mostrar diccionario");
                Console.WriteLine("4. Salir");
                Console.WriteLine("");
                bool insertada;
                bool encontrada;
                opcion = Console.ReadKey();
                switch (opcion.KeyChar)
                {
                    case '1':
                        Console.WriteLine("");
                        do
                        {
                            insertada = IntroducePalabra(diccionario);
                        }
                        while (insertada);
                        break;
                    case '2':
                        Console.WriteLine("");
                        encontrada = bPalabra(diccionario);
                        break;
                    case '3':
                        Console.WriteLine("");
                        mostrarDiccionario(diccionario);
                        break;
                    case '4':
                        File.AppendAllText("C:/tests/diccionario.txt", lineas);
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("No has introducido una opción correcta. Vuelve a intentarlo.");
                        Console.WriteLine("");
                        break; 
                }
            }
            while (opcion.KeyChar!= '4');

        }
        public static bool IntroducePalabra(SortedDictionary<string, string> d)
        {
            string palabra;
            string definicion;
            Console.WriteLine("");
            Console.Write("Introduce palabra:");
            palabra = Console.ReadLine();
            if (palabra.Length > 0)
            {
                Console.Write("Introduce definicion:");
                definicion = Console.ReadLine();
                try
                {
                    d.Add(palabra.ToLower(), definicion.ToLower());
                    lineas = lineas + palabra.ToLower() + ";" + definicion.ToLower() + "\n";
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("No se ha podido añadir la palabra");
                    return true;
                }
                Console.WriteLine("");
                return true;
            }
            else
            {
                return false;
            }
        }

    
        public static bool bPalabra(SortedDictionary<string, string> d)
        {
            string palabra;
            string valor;
            Console.Write("Introduce palabra:");
            palabra = Console.ReadLine();
            if (palabra.Length > 0)
            {
                bool encotrado = d.TryGetValue(palabra.ToLower(), out valor);
                Console.Write("Definición de " + palabra.Substring(0, 1).ToUpper() + palabra.Substring(1, palabra.Length - 1) + ": ");
                Console.WriteLine(valor.Substring(0, 1).ToUpper() + valor.Substring(1, valor.Length - 1));
                Console.WriteLine("");
                return true;
            }
            else
            {
                Console.WriteLine("");
                return false;
            }
        }

        public static void mostrarDiccionario(SortedDictionary<string, string> d)
        {
            Console.WriteLine("");
            Console.WriteLine("DICCIONARIO COMPLETO");
            Console.WriteLine("=====================");
            //foreach (var a in d)
            //{
            //    Console.WriteLine(a.Key.Substring(0, 1).ToUpper() + a.Key.Substring(1, a.Key.Length - 1));
            //    Console.WriteLine("     Def.: " + a.Value.Substring(0, 1).ToUpper() + a.Value.Substring(1, a.Value.Length - 1));
            //}
            //string[] dicc = File.ReadAllLines("C:/tests/diccionario.txt");
            //foreach(string di in dicc)
            //{
            //    Console.WriteLine(di);
            //}
            //Console.WriteLine("");
            string linea = "";
            StreamReader sr = new StreamReader("C:/tests/diccionario.txt");
            while (sr.Peek() >= 0)
            {
                if ((char)sr.Peek() == '\n')
                {
                    sr.Read();
                    Console.WriteLine(linea);
                    linea = "";
                }
                else
                {
                    linea = linea + (char)sr.Read();
                }
            }
            sr.Close();

            Console.WriteLine("");
        }        
    }
}