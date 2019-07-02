//dibuja un cuadrado por consola con las dimensiones que introduzca el usuario ( filas y columnas)
using System;

namespace _19_Cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce la anchura del cuadrado: ");
            int filas=Convert.ToInt16(Console.ReadLine());
            Console.Write("Introduce la altura del cuadrado: ");
            int columnas=Convert.ToInt16(Console.ReadLine());
            string[,] cuadrado=new string[filas,columnas];
            int i=0;
            int j=0;
            for(i=0;i<filas;i++){
                for(j=0;j<columnas;j++){
                    if(i==0 || i==filas-1){cuadrado[i,j]="* ";}
                    if(j==0){
                        cuadrado[i,j]="* ";
                    }
                    else {
                        if(j==columnas-1){
                            cuadrado[i,j]="*";
                        }
                        else{
                            if(cuadrado[i,j]!="* ") {
                                cuadrado[i,j]="* ";
                            }
                        }
                    }
                }
            }
            for(i=0;i<filas;i++){
                for(j=0;j<columnas;j++){
                    Console.Write(cuadrado[i,j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
