namespace Smallest_multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 1, smallest = 0;

            //x reprezentuje najmensie cislo delitelne cislami od 1 do 20, ktore budem prepisovat
            while (x > 0)
            {
                //najprv skusam delit 1 a potom idem na riadku 24 o jedno vyssie az po 20
                y = 1;
                //opakujem kym je x delitelne y-om bezo zvysku A kym je y-on mensi alebo rovny 20
                while ((x % y == 0) && (y <= 20))
                {
                    //ak sa y-on v podmienke while dopracuje az na hodnotu 20, znamena to,
                    //ze som nasiel hladane cislo x a zapisem ho ako smallest a ukoncim cyklus
                    if (y == 20)
                    {
                        smallest = x;
                        break;
                    }
                    y++;
                }
                x++;

                if (smallest > 0)
                {
                    break;
                }
            }
            Console.WriteLine(smallest);
        }
    }
}