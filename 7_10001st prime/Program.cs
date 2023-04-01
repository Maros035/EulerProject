using System;

namespace _10001st_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong x = 2, count = 0;
            //toto znamena ze chcem aby while bezal do nekonecna
            //pouziva sa ked chcem while ukoncit vo vnutri
            while (true)
            {
                if (jePrvocislo(x) == true)
                {
                    count++;//poradove cislo najdeneho prvocisla
                }

                if (count == 10001)//ak som nasiel 10001. prvocislo tak skonci while
                {
                    break;
                }
                x++;
            }
            Console.WriteLine(x);//vypis mi 10001. prvocislo
        }
        static bool jePrvocislo(ulong num)
        {
            ulong i = 0;

            bool jePrvocislo = true;

            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    jePrvocislo = false;
                    break;

                }
            }
            return jePrvocislo;
        }
    }
}