//Cree un programa que invierta el número que se pide el usuario por ejemplo si el usuario introduce 4561 el programa debe devolver 1654
using System;

namespace _13_InvertirCifra
{
    class Program
    {
        static void Main(string[] args)
        {
            long numero=Convert.ToInt64(args[0]);
            long numero2=0;
            string total="";
            for(int i=args[0].Length-1;i>=0;i--){
                numero2=numero%10;
                total=total+Convert.ToString(numero2);
                numero=numero/10;
                numero2=numero;
            }
            Console.WriteLine(total);
        }
    }
}
