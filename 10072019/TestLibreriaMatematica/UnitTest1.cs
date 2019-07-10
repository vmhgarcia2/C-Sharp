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

            //Acci�n
            resultado = Operacion.EsPar(numero);


            //Aseveraci�n
            Assert.IsTrue(resultado);
        }

        [Test]
        public void TestImpar()
        {
            //Arranque
            int numero = 13;
            bool resultado;

            //Acci�n
            resultado = Operacion.EsPar(numero);


            //Aseveraci�n
            Assert.IsFalse(resultado);
        }

        [Test]
        public void TestCero()
        {
            //Arranque
            int numero = 0;
            bool resultado;

            //Acci�n
            resultado = Operacion.EsPar(numero);


            //Aseveraci�n
            Assert.IsTrue(resultado);
        }

        [Test]
        public void TestEsPrimo12()
        {
            //Arranque
            int numero = 13;
            bool resultado;

            //Acci�n
            resultado = Operacion.EsPrimo(numero);


            //Aseveraci�n
            Assert.IsFalse(resultado);
        }

        [Test]
        public void Test12()
        {
            //Arranque
            int numero = 12;
            bool resultado;

            //Acci�n
            resultado = Operacion.EsPrimo(numero);


            //Aseveraci�n
            Assert.IsFalse(resultado);
        }


    }
}