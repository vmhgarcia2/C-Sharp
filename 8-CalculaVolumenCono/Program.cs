//Realizar un programa que nos pida el radio y la altura y nos calcule el volumen de un cono.
//El volumen V de un cono con radio r es un tercio del área de la base B por la altura h .
using System;

namespace _8_CalculaRadioCono
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length==2){
                double radio=Convert.ToDouble(args[0]);
                double altura=Convert.ToDouble(args[1]);
                const double pi=3.14;
                double volumen=(pi*radio*radio*altura)/3;
                Console.WriteLine("El volumen de un cono de radio " + radio + " y altura " + altura + " es: " + volumen);
            }
            else{
                Console.WriteLine("Tienes que introducir el radio y la altura para poder calcular el volumen");
            }

        }

    }
}
