using System;

namespace _20_Factorial_digit_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>() { 1 };

            //ratam 100!
            for (int i = 1; i <= 100; i++)
            {
                //i postupme nasobim do Listu result
                result = Multiply(result, MakeDigitList(i));
            }

            //vypis sumu hodnot v Liste result
            Console.WriteLine(result.Sum());
        }

        static List<int> MakeDigitList(int x)   //i vo forku v Main mi prepis do listu
        {
            List<int> output = new List<int>();

            int length = x.ToString().Length;   //int prevediem do stringu aby som zistil pocet cifier

            for (int i = 1; i <= length; i++)   //cifry postupne pripisujem do Listu 
            {
                output.Add(x % 10);
                x /= 10;
            }

            //kedze je moje cislo uz v liste ale naopak tak ho musim reversnut aby bolo v spravnom poradi
            return output.Reverse<int>().ToList();
        }

        static List<int> Multiply(List<int> a, List<int> b) //nasobenie pod seba
        {
            List<int> output = new List<int>();

            //vstupne Listy si reversnem aby sa s nimi lepsie pracovalo to znamena ze mozem do listu pripisovat a nemusim cisla vkladat na index 0
            a = a.Reverse<int>().ToList();
            b = b.Reverse<int>().ToList();

            for (int i = 0; i < a.Count; i++)
            {
                List<int> tmp = new List<int>();

                //od druhej iteracie cislo posuniem nulou ako pri scitani pod seba, ktore nasleduje po nasobeni pod seba
                for (int x = 0; x < i; x++)
                {
                    tmp.Add(0);
                }

                int carry = 0;
                for (int j = 0; j < b.Count; j++)
                {
                    int sum = a[i] * b[j] + carry;
                    int digit = sum % 10;
                    carry = sum / 10;
                    tmp.Add(digit);
                }

                if (carry > 0)
                {
                    tmp.Add(carry);
                }

                //vysledok prenasobenia danou cifrou nascitam do lisu output
                output = ReverseSum(output, tmp);
            }

            return output.Reverse<int>().ToList();
        }

        static List<int> ReverseSum(List<int> a, List<int> b)
        {
            //v metode Multiply pouzivam sumu na reverznute listy ale metoda Suma v sebe tiez reverzuje,
            //preto musim uprostred metody pouzit ReverseSum aby to potom funkcia Sum reversovala spravne
            return Sum(a.Reverse<int>().ToList(), b.Reverse<int>().ToList()).Reverse<int>().ToList();
        }

        static List<int> Sum(List<int> a, List<int> b)  //scitanie pod seba
        {
            List<int> output = new List<int>();

            a = a.Reverse<int>().ToList();
            b = b.Reverse<int>().ToList();

            // a.Count < b.Count ? ak je TRUE : ak je FALSE;
            List<int> longerNumber = a.Count > b.Count ? a : b;
            List<int> shortNumber = a.Count > b.Count ? b : a;

            int carry = 0;
            for (int i = 0; i < longerNumber.Count; i++)
            {
                int sum;

                // Vyriesime ak uz sme dalej ako dlzka kratkeho cisla
                if (i >= shortNumber.Count)
                {
                    sum = longerNumber[i] + carry;
                }
                // Este stale mame priestor v kratkom cisle
                else
                {
                    sum = longerNumber[i] + shortNumber[i] + carry;
                }

                int digit = sum % 10;
                carry = sum / 10;

                output.Add(digit);
            }

            if (carry > 0)
            {
                output.Add(carry);
            }

            return output.Reverse<int>().ToList();
        }
    }
}