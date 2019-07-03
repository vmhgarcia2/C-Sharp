
//dado un numero introducido por el usuario devovler si es primo o no
using System;

namespace _17_esPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length>0) {
                int numero=Convert.ToInt16(args[0]);
                Console.Write("El número " + (esPrimo(numero)?"es primo":"no es primo"));
            }
        }

        static bool esPrimo(int numero){            
            for(int i=2;i<numero;i++){
                if(numero%i==0){
                    return false;
                }
            }
            return true;
        }
    }
}
