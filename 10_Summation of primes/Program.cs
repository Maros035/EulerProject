namespace _10_Summation_of_primes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint limit = 2000000;
            ulong sum = 0;

            //vytvorim si array s "limit" riadkami, ktore su defaultne false
            bool[] array = new bool [limit];

            //kontrolujem prvocislenost od 2 do "limit"
            for (uint i = 2; i < limit; i++)
            {
                //ak je na indexe i false, co defaultne je...
                if (array [i] == false)
                {
                    //tak si urobim podmnozinu j ktora... 
                    for (uint j = 2 * i; j < limit; j += i)
                    {
                        //oznaci nasobky prvocisla i na true
                        array[j] = true;
                    }
                    //ak je array na indexe i false, tak mi ho pripocita do sum
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}