using NUnit.Framework;

namespace Prueba_ISBN
{
    public class Tests
    {

        /*
        Caso1: ISBN 1234567891234 -> ISBN v�lido | ISBN de 13 d�gitos
        Caso2: ISBN 0716703440 -> ISBN v�lido | ISBN de 10 d�gitos
        Caso3: ISBN 123456789 -> ISBN inv�lido | ISBN menor de 10 d�gitos
        Caso4: ISBN 123456789012 -> ISBN inv�lido | ISBN mayor de 10 d�gitos pero menor de 13 d�gitos
        */


        [Test]
        public void Caso1()
        {
            long value = 0716703440;
            string expected = "ISBN v�lido";
            string result = ISBN.Program.ISBN10(value);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Caso2()
        {
            long value = 9780716703440;
            string expected = "ISBN v�lido";
            string result = ISBN.Program.ISBN13(value);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Caso3()
        {
            long value = 123456789;
            string expected = "ISBN inv�lido";
            string result = ISBN.Program.ISBN10(value);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Caso4()
        {
            long value = 123456789012;
            string expected = "ISBN inv�lido";
            string result = ISBN.Program.ISBN10(value);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Caso5()
        {
            long value = 54;
            string expected = "45";
            string result = ISBN.Program.ISBN10(value);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Caso6()
        {
            long value = 0716703440;
            string expected = "0";
            string result = ISBN.Program.ISBN10(value);
            Assert.AreEqual(expected, result);
        }

    }
}