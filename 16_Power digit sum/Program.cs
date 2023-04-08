namespace _16_Power_digit_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();

            int num = 2;            //cislo
            int pow = 1000;         //mocnina
            int sum = 0;            //suma cifier vysledku umocnenia

            result = Umocnenie(num, pow);   //do funkcie vkladam cislo, ktore chcem umocnit a mocninu

            for (int i = 0; i < result.Count; i++)              //vsetky hodnoty v liste...
            {
                sum += result[i];                               //nascitam do hodnoty sum
                Console.WriteLine(result[i]);                   //vypisujem jednotlive hodnoty (digity)
            }

            Console.WriteLine(sum);                             //vypisujem FINALNY VYSLEDOK

        }
        static List<int> Umocnenie(int num, int pow)
        {
            List<int> result = new List<int>();                 //zakladam list, v ktorom sa mi bude evidovat vysledne cislo
            result.Add(num);                                    //do listu vkladam vstupnu hodnotu 2

            for (int j = 1; j < pow; j++)                       //rozlozim 2 na 1000cu -> ako 2*2*2*2*2*2*2*2*2*2*2*2.............
            {
                int carry = 0;
                for (int i = result.Count - 1; i >= 0; i--)     //nasobim digity od posledneho indexu po nulty cislom num (2)
                {
                    int sum = result[i] * num + carry;          //sum = hodnota na indexe i * cislo num + carry (zvysok)
                    int digit = sum % 10;                       //digit (hodnota cisla ktore bude zapisane) = sum % 10
                    carry = sum / 10;
                    result[i] = digit;                          //cislo digit zapisem do listu result na poziciu i
                }

                if (carry > 0)                                  //ak je carry > 0 po ukonceni iteracii s nasobenim...
                {
                    result.Insert(0, carry);                    //carry sa incestne na zaciatok listu
                }
            }
            return result;
        }
    }
}