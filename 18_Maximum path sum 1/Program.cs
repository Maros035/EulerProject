using System;
using System.Collections.Generic;
namespace _18_Maximum_path_sum_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = @"75
                            95 64
                            17 47 82
                            18 35 87 10
                            20 04 82 47 65
                            19 01 23 75 03 34
                            88 02 77 73 07 63 67
                            99 65 04 28 06 16 70 92
                            41 41 26 56 83 40 80 70 33
                            41 48 72 33 47 32 37 16 94 29
                            53 71 44 65 25 43 91 52 97 51 14
                            70 11 33 28 77 73 17 78 39 68 17 57
                            91 71 52 38 17 14 91 43 58 50 27 29 48
                            63 66 04 68 89 53 67 30 73 16 69 87 40 31
                            04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";

            //cisla ukladam do jednorozmernej array
            //znaky \n a \r vymenim za medzeru, nasledne som cisla rozdelil podla medzier a metodou where som odfiltroval prazdne policka v liste
            List<string> temp = data.Replace('\n', ' ').Replace('\r', ' ').Split(' ').Where(x => x != "").ToList();    
            List<int> numbers = temp.Select(int.Parse).ToList();        //dalej som List<string> konvertoval na List<int>

            //iterujem po cislach od konca nahor
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (GetRow(i) == 15)    //ak sa nachadzam na riadku 15, continue
                {
                    continue;
                }

                //zistujem ktore susedne cislo na nizsom riadku je vacsie
                int biggerNumBelow = CalculateTriangle(i, numbers);

                //prirataj k atualnemu cislu vacsieho suseda z nizsieho riadku
                numbers[i] += biggerNumBelow;
            }

            //vypis vysledok
            Console.WriteLine(numbers[0]);
        }
        static int CalculateTriangle(int index, List<int> numbers)
        {
            //vypocitaj polohu susedov na nizsom riadku a daj mi ich hodnoty
            int leftNum = numbers [index + GetRow(index)];
            int rightNum = numbers [index + GetRow(index) + 1];

            //porovnaj susedov na nizsom riadku a daj mi vacsie z nich
            int biggerNumber = Math.Max(leftNum, rightNum);

            //vrat mi to vacsie cislo
            return biggerNumber;

        }
        static int GetRow(int index)
        {
            //ratam v ktorom riadku sa dane cislo nachadza
            int i = 1;

            //bez do nekonecna
            while (true)
            {
                //od indexu aktualneho cisla odratavam cislo riadku (i) od prveho hore
                index -= i;

                //ak je index po odcitani riadka (i) 0 alebo menej, 
                if (index < 0)
                {
                    //vrat mi poradove cislo riadka v ktorom sa nachadza aktualne cislo
                    return i;
                }

                //navys i
                i++;
            }
        }
    }
}