using System;
using System.Collections.Generic;

namespace Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> diccionario = new Dictionary<string, string>();
            ConsoleKeyInfo opcion;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("=====");
                Console.WriteLine("1. Introducir palabra y definición");
                Console.WriteLine("2. Buscar palabra");
                Console.WriteLine("3. Salir");
                Console.WriteLine("");
                bool insertada;
                bool encontrada;
                opcion = Console.ReadKey();
                switch (opcion.KeyChar)
                {
                    case '1':
                        do
                        {
                            insertada = IntroducePalabra(diccionario);
                        }
                        while (insertada);
                        break;
                    case '2':
                        encontrada = bPalabra(diccionario);
                        break;
                    case '3':
                        break;
                    default:
                        Console.WriteLine("No has introducido una opción correcta. Vuelve a intentarlo.");
                        Console.WriteLine("");
                        break; 
                }
            }
            while (opcion.KeyChar!= '3');

        }
        public static bool IntroducePalabra(Dictionary<string, string> d)
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
                try {
                    d.Add(palabra.ToLower(), definicion);
                }
                catch(ArgumentException)
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

    
        public static bool bPalabra(Dictionary<string, string> d)
        {
            string palabra;
            string valor;
            Console.Write("Introduce palabra:");
            palabra = Console.ReadLine();
            if (palabra.Length > 0)
            {
                bool encotrado = d.TryGetValue(palabra.ToLower(), out valor);
                Console.Write("Definición de " + palabra + ": ");
                Console.Write(valor);
                Console.WriteLine("");
                return true;
            }
            else
            {
                Console.WriteLine("");
                return false;
            }
        }
    }
}