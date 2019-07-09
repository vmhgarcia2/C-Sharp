using System;
using System.IO;

namespace Ficheros
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = new StreamWriter(@"C:\tests\hello.txt", true);
            file.WriteLine("Helloooo");
            file.Close();
        }
    }
}
