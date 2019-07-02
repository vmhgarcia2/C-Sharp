//dada una cadena de texto comprobar si es palíndromo o no
using System;

namespace _18_Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una palabra para comprobar si es un palíndromo: ");
            string palabra=Console.ReadLine();            
            Console.Write(palabra + (esPalindromo(palabra)?" es un palíndromo":" no es un palíndromo"));
        }

        static bool esPalindromo(string palabra){
            if(palabra.Length>2){
                if(palabra.Substring(0,1)==palabra.Substring(palabra.Length-1,1))
                {                     
                    return esPalindromo(palabra.Substring(1,palabra.Length-2));
                }
                else { 
                    return false;
                }
            }
            else {
                return palabra.Substring(0,1)==palabra.Substring(palabra.Length-1,1);
            }
        }
    }
}
