namespace Largest_prime_factor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong num = 600851475143; // -> 2 * 7 * 13
            ulong newNum = 0;
            ulong result = 0;

            //kontrolujem cisla od 2 do num
            for (ulong i = 2; i <= num; i++) // -> 2..182 dokopy spravi 180 operacii
            {
                //cele delitele cisla num
                if (num % i == 0)
                {
                    newNum = i;

                    // My nevieme ci newNum je prvocislo -> povieme si okej tak nech je prvocislom
                    // a podme toto tvrdenie skusit vyvratit -> ak ho vyvratime => nieje prvocislo
                    // ak ho nevyvratime => je prvocislo
                    bool jePrvocislo = true;
                    //kontrola prvociselnosti i-cka
                    // Pokusame sa vyvratit tvrdenie ze jeProvcislo je pravda
                    for (ulong j = 2; j < newNum; j++)
                    {
                        // Nasli sme take cislo co to deli => nemoze byt prvocislo
                        if (newNum % j == 0) // 12 / 2 => 6 ale 12 % 2 => zvysok to je 0
                        {
                            jePrvocislo = false;
                            break; // V momente ked sa dostanem na riadok 31 => vypni forko a pokracuj na riadok 34
                        }
                    }
                    //je teda prvocislo???
                    if (jePrvocislo)
                    {
                        // Nasli sme 2 -> 182 / 2 -> 91 * 2
                        // Nasli sme 7 -> 91 / 7 -> 13 * 7 * 2
                        num = num / newNum; // newNum je prvocislo + deli to cislo num
                        result = newNum; // len si odlozime delitel
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
// 2, 3, 5, 7, 11, 13, 17, 19 23

// 2 --> 1x2, 2x1
// 3 --> 1x3, 3x1 (2)
// 5 --> 1x5, 5x1 (2, 3, 4)
// 7 --> 1x7, 7x1 (2, 3, 4, 5, 6, 7)