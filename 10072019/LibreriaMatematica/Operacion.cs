using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMatematica
{
    public class Operacion
    {
        public static bool EsPar(int numero)
        {
            return (numero % 2 == 0);
        }

        //Una función que nos determine si el número es Primo o No siempre en número positivos 
        //y en el rango de Enteros.Para ello iremos calculando el resto de los números anteriores 
        //e iremos sumando en un contador las veces que es 0 si el resultado del contador = 2
        //es primo en caso contrario no.
        public static bool EsPrimo(int numero)
        {
            int resto=0;

            for(int i = 1; i <= numero; i++)
            {
                resto = resto + (numero % i);
            }

            return resto==2;
        }

    }
}
