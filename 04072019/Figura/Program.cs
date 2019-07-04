using System;

namespace Figura
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimetro=5;
            double area=6;
            double b=4;
            double h=3;
            double lado1=6;
            double lado2=3;
            //Forma r=new Rectangulo(2,3);
            //Se puede crear un array de formas que contengan rectangulos,triangulos,círculos
            Forma r=new Rectangulo(perimetro,area);
            Forma c=new Cuadrado(lado1);
            Forma t=new Triangulo(b,h,lado1,lado2);
            //t.dibujar();
            r.dibujar();
            //System.Console.WriteLine(t);

        }
    }
}
