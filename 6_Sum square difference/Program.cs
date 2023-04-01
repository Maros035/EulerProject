using System.Globalization;

namespace _6_Sum_square_difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 1, sumOfSquares = 0, squareOfSum = 0, sumJ = 0, sum = 0;

            for (i = 1; i <= 100; i++)
            {
                sumOfSquares += Convert.ToInt32(Math.Pow(i, 2));
            }
            for (j = 1; j <= 100; j++)
            {
                sumJ += j;
                squareOfSum = Convert.ToInt32(Math.Pow(sumJ, 2));
            }
            sum = squareOfSum - sumOfSquares;
            Console.WriteLine(sum);
        }
    }
}