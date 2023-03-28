using System.Diagnostics.CodeAnalysis;

namespace Even_Fibonacci_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong a = 0;
            ulong b = 1;
            ulong c = 0;
            ulong sum = 0;

            //Fibonacci
            for (ulong i = 0; c < 4000000; i++)
            {
                c = a + b;
                a = b;
                b = c;

            //even num
                if (c % 2 == 0)
                {
                    sum += c;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
