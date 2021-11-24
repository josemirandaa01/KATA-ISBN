using NUnit.Framework;

namespace Prueba_ISBN
{
    public class Tests
    {

        /*
        Caso1: ISBN 1234567891234 -> ISBN válido | ISBN de 13 dígitos
        Caso2: ISBN 1234567890 -> ISBN válido | ISBN de 10 dígitos
        Caso3: ISBN 123456789 -> ISBN inválido | ISBN menor de 10 dígitos
        Caso4: ISBN 123456789012 -> ISBN inválido | ISBN mayor de 10 dígitos pero menor de 13 dígitos
        */

        [Test]
        public void Caso1()
        {
            long value = 1234567891234;
            string expected = "ISBN válido";
            string result = ISBN.Program.ISBN(value);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Caso2()
        {
            long value = 1234567890;
            string expected = "ISBN válido";
            string result = ISBN.Program.ISBN(value);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Caso3()
        {
            long value = 123456789;
            string expected = "ISBN inválido";
            string result = ISBN.Program.ISBN(value);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Caso4()
        {
            long value = 123456789012;
            string expected = "ISBN inválido";
            string result = ISBN.Program.ISBN(value);
            Assert.AreEqual(expected, result);
        }
    }
}