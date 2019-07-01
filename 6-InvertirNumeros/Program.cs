//Leer 10 datos numéricos y mostrarlos en orden inverso
using System;

namespace _6_InvertirNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length!=10){
                Console.WriteLine("Has de introducir 10 números, has puesto " + args.Length);
            }
            else
            {
                for(int i=9;i>=0;i--){
                    Console.WriteLine(args[i]);
                }
            }
        }
    }
}
