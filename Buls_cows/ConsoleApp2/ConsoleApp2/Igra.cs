using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Igra
    {
        protected Random Chislo = new Random(); // для Novoe_Chislo
        protected int[] x = new int[4];

        public void Igra1()
        {

            int Poputka = 0;
            var input1 = new Novoe_Chislo();
            string Novoe = (input1.NovoeChislo()).ToString();
            Console.WriteLine(Novoe);

            while (Poputka != 1000)
            {
                if (Poputka == 0)
                {
                    var input = new Vvod();
                    string Vvedenoe = input.Proverka();
                    var input3 = new Sravnenie();
                    input3.sravnenie(Novoe, Vvedenoe);
                }
                else
                {
                    var input = new Vvod();
                    string Vvedenoe = input.Proverka();
                    var input3 = new Sravnenie();
                    input3.sravnenie(Novoe, Vvedenoe);
                    if (input3.sravnenie(Novoe, Vvedenoe) == 8)
                    {
                        Console.WriteLine("Победа!!!");
                        Poputka = 999;
                    }
                }
                ++Poputka;
            }
        }
        public void Igra2()
        {
            var input = new Novoe_Chislo();
            string Vvedenoe = input.Proverka_Comp();

            var input1 = new Proverka_Comp1();
            string Chislo = input1.ProverkaComp1(Vvedenoe).ToString();
            /*Console.WriteLine( Chislo);*/
            Console.WriteLine("Комп узнал ваше загаданное число={0}", Chislo);

        }
    }
}
