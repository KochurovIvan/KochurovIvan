using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Sravnenie:Igra
    {
        public int sravnenie(string input2, string Vvedenoe)
        {
            int k = 0;
            int b = 0;
            string l = Vvedenoe.ToString();
            char[] S = input2.ToCharArray();
            for (int i = 0; i < 4; i++)
                if (S.Contains(l[i]))
                {
                    ++k;

                    if (S[i] == l[i])
                    {
                        ++b;
                    }




                }
            Console.WriteLine("Быки:{0},Коровы:{1}", b, k);
            return (b + k);
        }
    
}
}
