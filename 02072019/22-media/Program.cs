//Permite al usuario introducir 10 notas ( sin utilizar los argumentos) y calcula la media
using System;

namespace _3_media
{
    class Program
    {
        static void Main(string[] args)
        {
            int fin=10;
            double[] numeros=new double[fin];
            for (int i=0;i<fin;i++){
                Console.Write("Introduce 10 números (" +  (i+1)  + " de " + fin + "): ");
                numeros[i]=Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine(media(numeros));
        }

        static double media(double[] args){
            double suma=0;
            foreach(double valor in args){
                suma+=valor;
            }
            return suma/args.Length;
        }
    }
}
