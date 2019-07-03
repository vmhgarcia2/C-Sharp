using System;
using System.Reflection;

namespace Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculos coche=new Vehiculos();
            System.Console.WriteLine(coche.getColor());
            System.Console.WriteLine(coche.getNumRuedas());
            Vehiculos cocheVerde=new Vehiculos("verde",4);
            System.Console.WriteLine(cocheVerde.getColor());
            System.Console.WriteLine(cocheVerde.getNumRuedas());
            Console.WriteLine(coche.compararNumBastidor("123456789ABCDEFGH"));
        }
    }
}
