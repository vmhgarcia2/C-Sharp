using System;

namespace _4_piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recibe simbolo y un número y dibuja una piramide
            string simbolo="";
            for(int i=0;i<Convert.ToInt16(args[0]);i++) {
                for(int j=0;j<=i;j++) {
                    simbolo=simbolo  + args[1];
                }
                Console.WriteLine(simbolo);
                simbolo="";
            }
            for(int i=Convert.ToInt16(args[0])-1;i>=0;i--) {
                for(int j=0;j<=i;j++) {
                    simbolo=simbolo  + args[1];
                }
                Console.WriteLine(simbolo);
                simbolo="";
            }

            Console.WriteLine("Otra forma");
            Console.WriteLine("----------");
            for(int i=1;i<=Convert.ToInt16(args[0]);i++) {
                simbolo=simbolo.PadRight(i,Convert.ToChar(args[1]));
                Console.WriteLine(simbolo);
                simbolo="";
            }

            for(int i=Convert.ToInt16(args[0]);i>=0;i--) {
                simbolo=simbolo.PadRight(i,Convert.ToChar(args[1]));
                Console.WriteLine(simbolo);
                simbolo="";
            }
        }
    }
}
