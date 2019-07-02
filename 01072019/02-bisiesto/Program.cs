using System;

namespace _2_bisiesto
{
    class Program
    {
        static void Main(string[] args)
        {            
            int anyo=Convert.ToInt16(args[0]);
            if(esBisiesto(anyo)) { 
                Console.WriteLine("El año es bisiesto");
            }
            else {                
                Console.WriteLine("El año no es bisiesto"); 
            }
         }

         static bool esBisiesto(int anyo){
            return anyo%400==0 || (anyo%4==0 && anyo%100!=0);
         }
    }
}


//Al mismo nivel
