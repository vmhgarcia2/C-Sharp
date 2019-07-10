using NUnit.Framework;
using LibreriaMatematica;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPar()
        {
            //Arranque
            int numero=10;
            bool resultado;

            //Acción
            resultado = Operacion.EsPar(numero);


            //Aseveración
            Assert.IsTrue(resultado);
        }

        [Test]
        public void TestImpar()
        {
            //Arranque
            int numero = 13;
            bool resultado;

            //Acción
            resultado = Operacion.EsPar(numero);


            //Aseveración
            Assert.IsFalse(resultado);
        }

        [Test]
        public void TestCero()
        {
            //Arranque
            int numero = 0;
            bool resultado;

            //Acción
            resultado = Operacion.EsPar(numero);


            //Aseveración
            Assert.IsTrue(resultado);
        }

        [Test]
        public void TestEsPrimo12()
        {
            //Arranque
            int numero = 13;
            bool resultado;

            //Acción
            resultado = Operacion.EsPrimo(numero);


            //Aseveración
            Assert.IsFalse(resultado);
        }

        [Test]
        public void Test12()
        {
            //Arranque
            int numero = 12;
            bool resultado;

            //Acción
            resultado = Operacion.EsPrimo(numero);


            //Aseveración
            Assert.IsFalse(resultado);
        }


    }
}