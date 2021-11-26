using System;

namespace ISBN
{

    class Program
    {
        

        public static string ISBN10(long n)
        {

        long[] cifras = new long[10];
        long[] mult = new long[10];

            int i = 9;
            int b = 1;
            long suma = 0;

            while (n != 0)
        {
            long a;
            a = n % 10;
            n = n / 10;
            cifras[i] = a;
            mult[i] = a * b;
            suma = suma + mult[i];
            i--;
            b++;  
        }

            suma = suma % 11;

            if (suma == 0)
            {
                return "ISBN válido";
            }
            
        return "ISBN inválido";
        }

        public static string ISBN13(long n)
        {

            long[] cifras = new long[13];
            long[] mult = new long[13];

            int i = 12;
            int b = 1;
            long suma = 0;
            bool par = false;

            while (n != 0)
            {
                long a;
                a = n % 10;
                n = n / 10;
                cifras[i] = a;
                if(par == false)
                {
                    mult[i] = a * 1;
                    par = true;
                }
                else if (par == true)
                {
                    mult[i] = a * 3;
                    par = false;
                }

                suma = suma + mult[i];
                i--;
                b++;
            }

             suma = suma % 10;

            if (suma == 0)
            {
                return "ISBN válido";
            }
            

            return "ISBN inválido";
        }

    }
}
