using NUnit.Framework;
using Banco;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_getBalance()
        {
            //Arranque
            Cuenta c = new Cuenta();
            double resultado;
            c.SaldoActual = 12.1;

            //Acción
            resultado = c.getBalance();

            //Aseveración
            Assert.IsNotNull(resultado);
        }


        [Test]
        public void Test_deposit1()
        {
            //Arranque
            Cuenta c = new Cuenta();

            //Acción
            c.deposit(1.1);

            //Aseveración
            Assert.AreEqual(1.1, c.SaldoActual);
        }

        [Test]
        public void Test_deposit2()
        {
            //Arranque
            Cuenta c = new Cuenta();
            c.SaldoActual = 12.2;

            //Acción
            c.deposit(1.1);

            //Aseveración
            Assert.AreEqual(13.3, c.SaldoActual);
        }


        [Test]
        public void Test_retirarFondos1()
        {
            //Arranque
            Cuenta c = new Cuenta();
            c.SaldoActual = 12;

            //Acción
            c.withdraw(1.1);

            //Aseveración
            Assert.AreEqual(10.9, c.SaldoActual);
        }

        [Test]
        public void Test_retirar0()
        {
            //Arranque
            Cuenta c = new Cuenta();
            c.SaldoActual = 12;

            //Acción
            c.withdraw(0);

            //Aseveración
            Assert.AreEqual(12, c.SaldoActual);
        }

        [Test]
        public void Test_ToString()
        {
            //Arranque
            Cuenta c = new Cuenta();
            string s;
            c.SaldoActual = 12;

            //Acción
            s = c.ToString();

            //Aseveración
            Assert.AreEqual("12", s);
        }
    }
}