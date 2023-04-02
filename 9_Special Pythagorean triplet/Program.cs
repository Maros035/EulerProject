namespace _9_Special_Pythagorean_triplet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1, c = 0, abcSum = 1000;

            for (a = 1; a < abcSum; a++) 
            {
                for (b = a + 1; b < abcSum; b++)
                {
                    c = abcSum - (a + b);

                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine(a * b * c);
                    }
                }
            }
        }
    }
}