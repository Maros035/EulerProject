namespace _12_Highly_divisibe_triangular_number
{
    internal class Program
    {
        //vysledok je 76576500
        static void Main(string[] args)
        {
            long triangleNum = 0, numDivisors = 0, count = 0;

            //vypisujem trojuholnikove cisla
            for (int i = 1; i > 0; i++)
            {
                triangleNum = (i * (i + 1) / 2);
                numDivisors = 0;

                //kolko ma triangleNum delitelov?
                for (int d = 1; d <= triangleNum; d++)
                {
                    if (triangleNum % d == 0)
                    {
                        numDivisors++;
                    }
                }

                if (numDivisors == 501)
                {
                    Console.WriteLine(triangleNum);
                    break;
                }
            }


            //while (numDivisors <= 500)
            //{
            //    numDivisors = 0;
            //    count++;
            //    triangleNum += count;

            //    //kolko ma triangleNum delitelov?
            //    for (int d = 1; d <= triangleNum; d++)
            //    {
            //        if (triangleNum % d == 0)
            //        {
            //            numDivisors++;
            //            Console.WriteLine(numDivisors);
            //        }
            //    }
            //}
            //Console.WriteLine(triangleNum);
        }
    }
}