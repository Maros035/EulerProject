﻿namespace EulerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong num = 600851475143;
            ulong newNum = 0;
            ulong result = 0;

            //kontrolujem cisla od 2 do num
            for (ulong i = 2; i < num; i++)
            {
                //cele delitele cisla cisla num
                if (num % i == 0)
                {
                    newNum = i;

                    bool jePrvocislo = true;
                    //kontrola prvociselnosti i-cka
                    for (ulong j = 2; j < newNum; j++)
                    {
                        if (newNum % j == 0)
                        {
                            jePrvocislo = false;
                            break;
                        }
                    }
                    //je teda prvocislo???
                    if (jePrvocislo)
                    {
                        result = newNum;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}