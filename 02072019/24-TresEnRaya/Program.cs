//Juego tres en raya
using System;

namespace _24_TresEnRaya
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz=new string[3,3];
            Random mat=new Random();
            matriz[0,1]="X";
            matriz[0,2]="X";
            matriz[0,3]="X";
            matriz[1,1]="O";
            matriz[1,2]="0";
            matriz[1,3]="0";
            mat.Next(matriz);
            Console.WriteLine(matriz[0,1]);
        }
    }
}
