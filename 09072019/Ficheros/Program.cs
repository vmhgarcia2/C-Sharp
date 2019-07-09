using System;
using System.IO;

namespace Ficheros
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("C:/tests/hello.txt", "hola mundo");
            File.AppendAllText("C:/tests/hello.txt", "hola mundo");
            File.AppendAllText("C:/tests/hello.txt", "hola mundo");
        }
    }
}
