//Escriba un programa que calcule el tiempo de caída de un objeto determinado desde una altura dada, para ello se pide la altura en metros.
using System;

namespace _9_CalculaTiempoCaida
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length==1){
                double g=9.81;
                double altura=Convert.ToDouble(args[0]);
                double resultado= Math.Sqrt(altura/(g/2));
                Console.WriteLine("El tiempo que tarda un objeto en caer desde " + altura + " m es de " + resultado + " seg.");
            }
            else{
                Console.WriteLine("Tienes que introducir la altura");
            }
            
        }
    }
}
