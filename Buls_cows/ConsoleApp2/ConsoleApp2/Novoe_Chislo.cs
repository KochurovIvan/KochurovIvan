using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Novoe_Chislo:Igra
    {
        public int NovoeChislo()
        {
            for (int i = 0; i < 4; ++i)
            {
                x[i] = Chislo.Next(10);
            }
            return x[0] * 1000 + x[1] * 100 + x[2] * 10 + x[3];
        }

        public string Proverka_Comp()
        {
            Console.WriteLine("Введите число");
            string vvedenoe = Console.ReadLine();
            string proverka = Vvedenoe_Comp(vvedenoe);
            return proverka;
        }

        public string Vvedenoe_Comp(string vvedenoe)
        {
            if (vvedenoe.Length != 4)
            {
                string k = "";
                while (k.Length != 4)
                {
                    Console.WriteLine("Введите четырехзначное");
                    k = Console.ReadLine();
                }
                vvedenoe = k;
            }
            return (vvedenoe);
        }
    }
}
