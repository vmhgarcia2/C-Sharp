using System;

namespace _5_romanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=Convert.ToInt32(args[0]);
            string numeroRomano="";
            //Millares
            if(Convert.ToInt32(numero)/1000>0){
                //Console.WriteLine(Convert.ToInt32(numero)/1000);
                switch(Convert.ToInt32(numero)/1000){
                    case 1:
                    case 2:
                    case 3:
                    case 4: 
                        numeroRomano=(numeroRomano.PadRight(Convert.ToInt32(numero)/1000,'M'));
                        break;
                }
            }
            //Centenas
            numero=numero%1000;            
            if(Convert.ToInt32(numero)/100>0){
                //Console.WriteLine(Convert.ToInt32(numero)/100);
                switch(Convert.ToInt32(numero)/100){
                    case 1:
                    case 2:
                    case 3:
                        numeroRomano=numeroRomano.PadRight((Convert.ToInt32(numero)/100+numeroRomano.Length),'C');
                        break;
                    case 4: 
                        numeroRomano=numeroRomano+"CD";
                        break;
                    case 5:
                        numeroRomano=numeroRomano+'D';
                        break;
                    case 6:
                    case 7:
                    case 8:
                        numeroRomano=numeroRomano+'D';
                        numeroRomano=numeroRomano.PadRight((((Convert.ToInt32(numero)/100)-5)+numeroRomano.Length),'C');
                        break;
                    case 9:                        
                        numeroRomano=numeroRomano+"CM";
                        break;
                }
                 //Decenas
                numero=numero%100;            
                if(Convert.ToInt32(numero)/10>0){
                    switch(Convert.ToInt32(numero)/10){
                        case 1:
                        case 2:
                        case 3:
                            numeroRomano=numeroRomano.PadRight((Convert.ToInt32(numero)/10+numeroRomano.Length),'X');
                            break;
                        case 4: 
                            numeroRomano=numeroRomano+"XL";
                            break;
                        case 5:
                            numeroRomano=numeroRomano+'L';
                            break;
                        case 6:
                        case 7:
                        case 8:
                            numeroRomano=numeroRomano+'L';
                            numeroRomano=numeroRomano.PadRight((((Convert.ToInt32(numero)/10)-5)+numeroRomano.Length),'X');
                            break;
                        case 9:                        
                            numeroRomano=numeroRomano+"XC";
                            break;
                    }
                }
                 //Unidades
                numero=numero%10;            
                if(Convert.ToInt32(numero)>0){
                    switch(Convert.ToInt32(numero)){
                        case 1:
                        case 2:
                        case 3:
                            numeroRomano=numeroRomano.PadRight((Convert.ToInt32(numero)+numeroRomano.Length),'I');
                            break;
                        case 4: 
                            numeroRomano=numeroRomano +"IV";
                            break;
                        case 5:
                            numeroRomano=numeroRomano+'V';
                            break;
                        case 6:
                        case 7:
                        case 8:                       
                            numeroRomano=numeroRomano+'V';
                            numeroRomano=numeroRomano.PadRight((((Convert.ToInt32(numero))-5)+numeroRomano.Length),'I');
                            break;
                        case 9:                        
                            numeroRomano=numeroRomano+"IX";
                            break;
                    }
                }
            Console.WriteLine("El número " + args[0] + " es " + numeroRomano + " en números romanos");
            }
        }
    }
}
