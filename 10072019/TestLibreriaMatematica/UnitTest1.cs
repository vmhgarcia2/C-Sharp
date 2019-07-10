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
        public void TestEsPar10()
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
        public void TestEsPar13()
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
        public void TestEsPar0()
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
        public void TestEsPrimo13()
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
        public void TestEsPrimo12()
        {
            //Arranque
            int numero = 12;
            bool resultado;

            //Acci�n
            resultado = Operacion.EsPrimo(numero);


            //Aseveraci�n
            Assert.IsFalse(resultado);
        }

        [Test]
        public void TestEsPrimo0()
        {
            //Arranque
            int numero = 0;
            bool resultado;

            //Acci�n
            resultado = Operacion.EsPrimo(numero);


            //Aseveraci�n
            Assert.IsFalse(resultado);
        }

    }
}