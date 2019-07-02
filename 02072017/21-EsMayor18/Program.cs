//Dado un array de edades mostrar por pantalla si todas son mayores de 18 o no.
using System;

namespace _21_EsMayor18
{
    class Program
    {
            static void Main(string[] args)
        {
            int[] edades=new int[]{19,21,23,3,53};
            int i=0;
            for(i=0;i<edades.Length;i++){
                if(edades[i]<18){
                    Console.WriteLine("Todos los números del array no son mayores de 18");
                    i=(edades.Length+1);
                }
            }
            if(i==edades.Length){
                Console.WriteLine("Todos los números del array son mayores de 18");
            }
        }
    }
}
