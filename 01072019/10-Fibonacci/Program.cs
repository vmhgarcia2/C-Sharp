//Cree un programa que a partir de un entero calcule su serie Fibonacci
using System;

namespace _10_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length>0){
                int limite=Convert.ToInt16(args[0]);
                int numeroActual=0;
                int numeroAnterior=1;
                int aux=0;
                Console.WriteLine(0);
                do { 
                    aux=numeroActual;
                    numeroActual=numeroAnterior;
                    numeroAnterior=aux+numeroActual;
                    Console.WriteLine(numeroActual);
                } while(numeroAnterior<limite);
            }
            else{
                Console.WriteLine("Tienes que introducir un número entero");
            }
        }
    }
}
