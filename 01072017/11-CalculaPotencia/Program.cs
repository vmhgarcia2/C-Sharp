//Cree un programa que calcule la potencia de un número a partir de su base y su exponente.
using System;

namespace _11_CalculaPotencia
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length==2){
                double bas=Convert.ToDouble(args[0]);
                double exponente=Convert.ToDouble(args[1]);
                double total=bas;
                for(int i=1;i<exponente;i++){
                    total=bas*total;
                }
                Console.WriteLine(bas + "^" + exponente + " = " + total);
            }
            else{
                Console.WriteLine("Tienes que introducir un número entero");
            }
        }
    }
}
