using System;
using System.Collections;
using System.Collections.Generic;

namespace PilasyColas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cola - FIFO
            Queue <int> cola = new Queue<int>();
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                cola.Enqueue(i);
            }

            while (cola.Count > 0){
                suma += cola.Dequeue();
            }

            Console.WriteLine(suma);

            //Pila - LIFO
            Stack<int> pila = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                pila.Push(i);
            }
            while (pila.Count > 0)
            {
                Console.Write(pila.Pop() + " ");
            }

        }
    }
}
