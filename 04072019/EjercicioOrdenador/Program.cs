using System;

namespace EjercicioOrdenador
{
    class Program
    {
        static void Main(string[] args)
        {
            Ordenador ordenador=new Ordenador(new Ram(10),new Procesador(40,"amd386"),
            "GHA333",new AlmacenamientoHDD(1,1,2));
            ordenador.getMemoria().setPosicionMemoria(2,8);
            System.Console.WriteLine(ordenador.getMemoria().getPosicionMemoria(2));
            System.Console.WriteLine(ordenador.getProcesador().getVelocidad());
            System.Console.WriteLine(ordenador.getProcesador().getModelo());
        }
    }
}
