
//Realizar un programa que no pida un unidad en kb y nos haga la conversión a MB
using System;

namespace _7_ConvertirkbaMB
{
    class Program
    {
        static void Main(string[] args)
        {
            double MB=0;
            if(args.Length>0) { 
                MB=Convert.ToDouble(args[0])/1000;
                Console.WriteLine(args[0] + " kb = " + MB + " MB" );
            }
            else{
                Console.WriteLine("Tienes que introducir un número para poder convertirlo");
            }
        }
    }
}
