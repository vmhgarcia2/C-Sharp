
//Escribe un programa que pida 20 números enteros. 
//Estos números se deben introducir en un array de 4 filas por 5 columnas. 
//El programa mostrará las sumas parciales de filas y columnas igual que si de una hoja de cálculo se tratara. 
//La suma total debe aparecer en la esquina inferior derecha.
using System;

namespace _16_ArrayNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas=2;
            int columnas=2;
            int[,] matriz=new int[filas,columnas];
            int[,] matrizSuma=new int[1,columnas];
            int k=1;
            int sumafilas=0;
            int sumacolumnas=0;
            int sumatotal=0;
            int i=0;
            int j=0;

            for(i=0;i<columnas;i++){
                matrizSuma[0,i]=0;
            }
            for(i=0;i<filas;i++){
                for(j=0;j<columnas;j++){
                    Console.Write("Introduce el número " + k++ + " de " + filas*columnas + ": ");
                    matriz[i,j]=Convert.ToInt16(Console.ReadLine());
                }
            }

            for(i=0;i<filas;i++){
                for(j=0;j<columnas;j++){
                        Console.Write(matriz[i,j] + "   ");
                        sumafilas+=matriz[i,j];
                }
                Console.WriteLine(sumafilas + "   ");
                sumafilas=0;
            }

            for(j=0;j<columnas;j++){
                for(i=0;i<filas;i++){
                        sumacolumnas+=matriz[i,j];
                }
                sumatotal+=sumacolumnas;
                Console.Write(sumacolumnas + "   ");
                sumacolumnas=0;
            }
            Console.Write(sumatotal);
        }
    }
}
