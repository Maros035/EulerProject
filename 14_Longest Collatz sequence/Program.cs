namespace _14_Longest_Collatz_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biggestInput = 0;
            int longestChain = 0;
            //int i = 1;

            for (int i = 1; i < 1000000; i++)
            {
                if (Collatz(i) > longestChain)
                {
                    biggestInput = i;
                    longestChain = Collatz(i);
                }
                Console.WriteLine(i);
            }

            //while (i < 1000000)
            //{
            //    if (Collatz(i) > longestChain)
            //    {
            //        biggestInput = i;
            //        longestChain = Collatz(i);
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}
            Console.WriteLine("Biggest input = " + biggestInput);
            Console.WriteLine("longest chain = " + longestChain);

        }
        static int Collatz(int input)
        {
            int count = 0;

            while (input != 1)
            {
                if (input % 2 == 0)
                {
                    input /= 2;
                }
                else input = 3 * input + 1;

                count++;
            }
            return count;
        }
    }
}