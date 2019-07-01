using System;

namespace _3_media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(media(args));
        }

        static float media(string[] args){
            float suma=0;
            foreach(string valor in args){
                suma+=Convert.ToInt32(valor);
            }
            return suma/args.Length;
        }
    }
}
