using System;

namespace _14_Arrays
{
    class Program
    {
        //Definir enum fuera de class
        enum operaciones{Sumar=1,Restar,Multiplicar};
        static void Main(string[] args)
        {     
            /* string separador="Nombre: ";   
             * string[] nombres={"David","Steven","Miriam","Nacho","Vero","Paz","Manolo","Victor"};
             * Console.WriteLine(separador + string.Join("\n"+separador ,nombres)); 
            */

            //Array 500 números del 100 al 600
            /* int desplazamiento=100;
             * int[] numeros=new int[500];
             * for(int i=0;i<500;i++){
             *     numeros[i]=i+desplazamiento;
             * }
             * Console.WriteLine(string.Join(", ",numeros)); 
             */

             //Tipos enumerados
            int a=100;
            int b=10;
            Console.WriteLine("Indica la operación a realizar con los números:" +  a + " y " + b);
            var opciones=Enum.GetValues(typeof(operaciones));
            foreach(var o in opciones){
                Console.WriteLine(Convert.ToInt16(o) + ". " + o);
            }
            
            operaciones opcion=(operaciones)Convert.ToInt16(Console.ReadLine());
            int resultado=0;
            switch (opcion){
                case operaciones.Sumar: resultado =a+b; break;
                case operaciones.Restar: resultado=a-b; break; 
                case operaciones.Multiplicar: resultado=a*b; break; 
            }
            Console.WriteLine("El resultado de " + opcion + " " + a + " y " + b + " es " + resultado);
        }
    }
}
