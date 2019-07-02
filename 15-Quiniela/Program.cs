//Escribe un programa que muestre tres apuestas de la quiniela en tres columnas para los 14 partidos y el pleno al quince (15 filas)
using System;

namespace _15_Quiniela
{
    class Program
    {
        static void Main(string[] args)
        {
            String partido;
            String[] partidos=new String[15];
            int i=0;
            do{
                System.Console.WriteLine("Introduce un partido (T para terminar):");
                partido=System.Console.ReadLine();
                if(partido!="T"){partidos[i]=partido;}
                i++;
            } while(partido!="T");
            
            for(i=0;i<15;i++){
                if((partidos[i])!=null){
                    Console.WriteLine(partidos[i].PadRight(20,' ') + " 1 X 2" );
                }
                else{
                    partidos[i]="Equipo1-Equipo2";
                    Console.WriteLine(partidos[i].PadRight(20,' ') + " 1 X 2" );
                }
            }
        }
    }
}
