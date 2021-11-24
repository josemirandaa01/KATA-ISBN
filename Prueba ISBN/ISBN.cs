using System;

namespace ISBN
{

    class Program
    {

        public static string ISBN(long n)
        {
            string cifras = "";
            int a = 5, b = 2;

            cifras = cifras + b;
            cifras = cifras + a;
            Console.WriteLine(cifras);
            

            return "ISBN válido";
        }

    }
}
