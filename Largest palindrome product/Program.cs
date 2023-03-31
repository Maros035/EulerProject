namespace EulerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadefinujem si premenne
            int maxPalindrome = 0, sucin, i = 0, j = 0;

            //generujem mnozinu i = <999, 100> a znizujem o 1
            for (i = 100; i <= 999; i++)
            {
                //generujem druhu mnozinu j = <999, 100> a znizujem o 1
                for (j = 100; j <= 999; j++)
                {
                    sucin = i * j;

                    //je cislo polyndrom?
                    if (IsPalindrome(sucin) && maxPalindrome < sucin) //funkcia
                    {
                        maxPalindrome = sucin;
                    }
                }
            }
            Console.WriteLine(maxPalindrome);
        }
        static bool IsPalindrome(int num)
        {   //konvertujem cislo na text
            string textNum = num.ToString();
            //ickom kontrolujem textNum do polovice a porovnavam s druhou polovicou
            for (int i = 0; i < textNum.Length / 2; i++)
            {
                //druha polovica ktoru porovnavam s hodnotoi i v prvom for-ku
                if (textNum[i] != textNum[textNum.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}