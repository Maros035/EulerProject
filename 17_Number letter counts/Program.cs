using System;

namespace _17_Number_letter_counts
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            // { 6, 100, 50, 3 } => six hundred fifty three
            string wordOfNum = "";

            //for <1; 1000>                               
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 100 == 0 && i < 1000)       //riesim cele stovky
                {
                    int rest = i / 100;
                    string tempString = Dictionary(rest) + Dictionary(100); // riesim {2, 100}, {3, 100}... 
                    Console.WriteLine(tempString);
                    wordOfNum += tempString;        //priratam do stringu
                }
                else
                {
                    List<int> converted = ConvertToList(i);

                    //653 = {6, 100, 50, 3}
                    if(converted.Count > 2)
                    {
                        converted.Insert(2, 0);         //medzi 100ky a 10ky vkladam "0 == and"
                    }

                    string tempString = "";
                    foreach (int jNum in converted)
                    {
                        tempString += Dictionary(jNum);     //list vytvorenych cisel prekladam pomocou Dictionary {6, 100, 0, 50, 3}
                    }
                    Console.WriteLine(tempString);
                    wordOfNum += tempString;      //653 => "sixhundredfiftythree"
                }                   
            }
            Console.WriteLine(LetterCounter(wordOfNum));
        }
        static int LetterCounter (string wordOfNum)     //ratam pismena v zaverecnom stringu
        {
            int counter = 0;

            for (int i = 0; i < wordOfNum.Length; i++)
            {
                counter++;
            }
            return counter;
        }
        //653 = {6, 100, 50, 3}
        static List <int> ConvertToList(int num)       //cislo 653 konvertujem
        {
            // 653 => "653"
            string toString = num.ToString();       //konvertujem cislo na string

            // "653" => { '6', '5', '3' }
            char[] toCharArray = toString.ToCharArray();        //konvertujem string na array

            List<int> output = new List<int>(); // { }
            for (int i = 0; i < toCharArray.Length; i++)        //iterujem po indexoch v arrayi {6, 5, 3} odzadu 
            {
                // { '6', '5', '3' } => '3'
                char charOnIndex = toCharArray[toCharArray.Length - i - 1];     //z arraya vyberam charactery odzadu

                // '3' => "3"
                string strFromChar = charOnIndex.ToString();            //character konvertujem na string

                // "3" => 3
                int numFromStr = int.Parse(strFromChar);            //string konvertujem na int resp zo stringu ziskavam ciselnu hodnotu cez Parse

                if(numFromStr == 0)                 //ak je v arrayi v pripade celych 100viek alebo 10tok na nejakej pozicii 0...
                {
                    continue;                       //...tak to preskocim
                }

                int decadeOffset = Convert.ToInt32(Math.Pow(10, i));        //pomocou Math.Pow(10, i) premienam v liste stovky a desiatky kvoli funkcii Dictionary

                if (decadeOffset < 100)
                {
                    output.Insert(0, numFromStr * decadeOffset);        //zapisujem do listu 10tky a jednotky
                }
                else
                {
                    // 100
                    output.Insert(0, decadeOffset);                 //zapisujem do listu 100vky

                    // 6
                    output.Insert(0, numFromStr);                   //zapisujem do listu jednotky pred stovky
                }
            }
            if (output.Count >= 2 && output[output.Count - 2] == 10 && output[output.Count -1] <= 9)  //ak sa jedna o 10tky, pri ktorych je 
            {                                                                                         //na mieste desiatok 10 a na mieste jednotiek je cislo 1 az 9...
                output[output.Count - 2] += output[output.Count - 1];       //... ku 10tkam v array priratam jednotky z array
                output.RemoveAt(output.Count - 1);                          //a poziciu jednotiek v liste zrusim
            }
            // { 6, 100, 50, 3 }
            return output;
        }
        static string Dictionary(int num)
        {
            switch (num)
            {
                case 0: return "and";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                case 20: return "twenty";
                case 30: return "thirty";
                case 40: return "forty";
                case 50: return "fifty";
                case 60: return "sixty";
                case 70: return "seventy";
                case 80: return "eighty";
                case 90: return "ninety";
                case 100: return "hundred";
                case 1000: return "thousand";
                default: return "";
            }
        }
    }
}