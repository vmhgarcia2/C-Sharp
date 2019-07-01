using System;

namespace _5_romanos
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,2,3,4 I,II,III,IIII
            //5 V
            //6,7,8 VI,VII,VIII,VIIII
            //10 X
            int numero=Convert.ToInt32(args[0]);
            string numeroRomano="";
            if(Convert.ToInt32(numero)/1000>0){
                Console.WriteLine(Convert.ToInt32(numero)/1000);
                switch(Convert.ToInt32(numero)/1000){
                    case 1:
                    case 2:
                    case 3:
                    case 4: 
                        numeroRomano=(numeroRomano.PadRight(Convert.ToInt32(numero)/1000,'M'));
                        break;
                }
            }
            numero=numero%1000;            
            if(Convert.ToInt32(numero)/100>0){
                Console.WriteLine(Convert.ToInt32(numero)/1000);
                switch(Convert.ToInt32(numero)/1000){
                    case 1:
                    case 2:
                    case 3:
                    case 4: 
                        numeroRomano=(numeroRomano.PadRight(Convert.ToInt32(numero)/1000,'C'));
                        break;
                }
            }
            Console.WriteLine(numero);
            Console.WriteLine(numeroRomano);

            
        }
    }
}
