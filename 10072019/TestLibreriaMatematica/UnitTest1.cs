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

            //Acción
            resultado = Operacion.EsPar(numero);


            //Aseveración
            Assert.IsTrue(resultado);
        }

        [Test]
        public void TestEsPar13()
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
        public void TestEsPar0()
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
        public void TestEsPrimo13()
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
        public void TestEsPrimo12()
        {
            //Arranque
            int numero = 12;
            bool resultado;

            //Acción
            resultado = Operacion.EsPrimo(numero);


            //Aseveración
            Assert.IsFalse(resultado);
        }

        [Test]
        public void TestEsPrimo0()
        {
            //Arranque
            int numero = 0;
            bool resultado;

            //Acción
            resultado = Operacion.EsPrimo(numero);


            //Aseveración
            Assert.IsFalse(resultado);
        }

    }
}