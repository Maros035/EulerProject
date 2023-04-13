namespace _19_Counting_Sundays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] extraDays = { 1, 3, 5, 7, 8, 10, 12 };    //31day months
            int day = 1;        //1 - 7 -> monday - sunday
            int year = 1900;    //1900 - 2000
            int month = 1;      //1 - 12 -> Jan - Dec
            int date = 1;
            int daysInMonth = 0;

            int sundays = 0;

            while (year < 2001)
            {
                if (day == 7 && date == 1 && year > 1900)
                {
                    sundays += 1;       //ratam nedele ktore su prvym dnom v mesiaci
                }

                //day
                if (day == 7)
                {
                    day = 1;            //po Nedeli sa den nastavi na Pondelok
                }
                else
                    day += 1;           //inak sa iba posunie na nasledujuci den

                //year
                if(date == 31 && month == 12)
                {
                    year += 1;          //ked je posledny datum v poslednom mesiaci, posuniem rok
                }

                //month
                if (month == 2)         //ak je Februar
                {
                    if (IsLeapYear(year))   //ak je prestupny rok
                    {
                        daysInMonth = 29;   //Februar ma 29 dni
                    }
                    else
                        daysInMonth = 28;   //ak nie je prestupny rok, Februar ma 28 dni
                }
                else if (extraDays.Contains(month)) //ak je poradove cislo mesiaca v array s mesiasmi s 31 dnami...
                {
                    daysInMonth = 31;               //...tak ma mesiac 31 dni
                }
                else
                    daysInMonth = 30;               //...inak ma mesiac iba 30 dni

                //date
                if (date == daysInMonth)    //ak je datum rovnaky ako pocet dni v mesiaci (resp. posledny den v mesiaci)...
                {
                    if (month == 12)        //...a ak je December...
                    {
                        month = 1;          //posiniem sa z Decembra zase na Januar
                    }
                    else
                        month += 1;         //inak iba navysim mesiac

                    date = 1;       //datum nastavim naspat na 1
                }
                else
                    date += 1;      //inak datum iba navysim
            }
            Console.WriteLine(sundays);

        }
        static bool IsLeapYear(int year)        //je prestupny rok?
        {
            if(year % 4 ==0)                    //ak je rok delitelny 4...
            {
                if(year % 100 ==0 && year % 400 !=0)    //ak je rokdelitelny 100 a nie je delitelny 400... 
                {
                    return false;                       //...tak nie je prestupny rok
                }
                return true;                    //...tak je prestupny rok 
            }
            return false;       //ak rok nesplna podmienku tak nie je prestupny rok
        }
    }
}