using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{


        class Vvod : Igra
        {
            public string Proverka()
            {
                Console.WriteLine("Введите число");
                string vvedenoe = Console.ReadLine();
                string proverka = Vvedenoe(vvedenoe);
                return proverka;
            }

            public string Vvedenoe(string vvedenoe)
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

