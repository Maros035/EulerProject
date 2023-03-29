namespace Largest_prime_factor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong num = 30;
            ulong newNum = 0;
            ulong result = 0;

            //kontrolujem cisla delitelnosti
            for (ulong i = 2; i < num; i++) 
            {
                //delitele cisla num
                if (num % i ==0)
                {
                    bool jePrvocislo = true;

                    //kontrola prvociselnosti i-cka
                    for (ulong j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            jePrvocislo = false;
                            break;
                        }
                    }
                    //je teda prvocislo???
                    if (jePrvocislo) 
                    {
                        result = i;
                    }
                }
            }
            Console.WriteLine(newNum);
        }
    }
}
// 2, 3, 5, 7, 11, 13, 17, 19 23

// 2 --> 1x2, 2x1
// 3 --> 1x3, 3x1 (2)
// 5 --> 1x5, 5x1 (2, 3, 4)
// 7 --> 1x7, 7x1 (2, 3, 4, 5, 6, 7)