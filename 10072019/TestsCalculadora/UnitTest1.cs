using NUnit.Framework;
using Calculadora;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arranque-Arrange
            int a = 1;
            int b = 2;

            //Accion - Act
            int suma = Matematicas.Sumar(a, b);

            //Aseveracion - Assert
            Assert.AreEqual(a + b,suma);
        }
    }
}