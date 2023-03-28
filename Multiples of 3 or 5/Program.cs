namespace Multiples_of_3_or_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                //delitelne 3
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}