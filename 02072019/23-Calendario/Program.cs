//(extra) dado el número de dias del mes y el dia de la semana en que empieza el mes  dibuja un calendario de ese mes
using System;

namespace _23_Calendario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce los dias del mes: ");
            int dias=Convert.ToInt16(Console.ReadLine());
            Console.Write("Introduce el dia de la semana en que empieza el mes (con número): ");
            int inicio=Convert.ToInt16(Console.ReadLine())-1;

            int columnas=7;
            int filas=(dias+inicio)/columnas;
            int numDia=1;
            
            if((dias+inicio)%columnas!=0) {
                filas++;
            }
            string[,] calendario=new string[filas,columnas];
            for(int i=0;i<filas;i++){
                for(int j=0;j<columnas;j++){
                    if((i==0 && j<inicio) || numDia>dias) {calendario[i,j]="  ";}
                    else{
                        calendario[i,j]=Convert.ToString(numDia);
                        numDia++;
                    }
                }
            }    
            for(int i=0;i<filas;i++){
                for(int j=0;j<columnas;j++){
                    Console.Write(calendario[i,j].Length==1?" " + calendario[i,j] + " ":calendario[i,j] + " ");
                }
                Console.WriteLine("");
            }          
        }
    }
}
