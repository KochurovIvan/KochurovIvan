using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Proverka_Comp1
    {

        public int ProverkaComp1(string input)
        {
            int k = 0;
            int k1 = 0;
            int k2 = 0;
            int k3 = 0;
            int b = 0;
            int[] nums = new int[4] { 1, 0, 0, 0 };
            var C = new Proverka_Comp1();
            while (b != 4)
            {

                int L = nums[0] * 1000 + nums[1] * 100 + nums[2] * 10 + nums[3];
                string M = L.ToString();
                char[] S = M.ToCharArray();

                while (k != 1)                      //1000
                {
                    nums[0] = S[0] & 0x0f;
                    string Chislo = (nums[0] * 1000 + nums[1] * 100 + nums[2] * 10 + nums[3]).ToString();
                    Console.WriteLine(Chislo);

                    if (S[0] == input[0])
                    {
                        Console.WriteLine(Chislo); C.ProverkaComp2(Chislo, input);
                        ++k; ++b;
                    }
                    ++S[0];


                }
                while (k1 != 1)                      //100
                {
                    nums[1] = S[1] & 0x0f;
                    string Chislo = (nums[0] * 1000 + nums[1] * 100 + nums[2] * 10 + nums[3]).ToString();
                    Console.WriteLine(Chislo);

                    if (S[1] == input[1])
                    {
                        Console.WriteLine(Chislo); C.ProverkaComp2(Chislo, input);
                        ++k1; ++b;
                    }
                    ++S[1];


                }
                while (k2 != 1)                      //10
                {
                    nums[2] = S[2] & 0x0f;
                    string Chislo = (nums[0] * 1000 + nums[1] * 100 + nums[2] * 10 + nums[3]).ToString();
                    Console.WriteLine(Chislo);

                    if (S[2] == input[2])
                    {
                        Console.WriteLine(Chislo); C.ProverkaComp2(Chislo, input);
                        ++k2; ++b;
                    }
                    ++S[2];


                }
                while (k3 != 1)                      //1
                {
                    nums[3] = S[3] & 0x0f;
                    string Chislo = (nums[0] * 1000 + nums[1] * 100 + nums[2] * 10 + nums[3]).ToString();
                    Console.WriteLine(Chislo);

                    if (S[3] == input[3])
                    {
                        Console.WriteLine(Chislo); C.ProverkaComp2(Chislo, input);
                        ++k3; ++b;
                    }
                    ++S[3];


                }

            }
            return nums[0] * 1000 + nums[1] * 100 + nums[2] * 10 + nums[3];

        }
        public void ProverkaComp2(string input2, string Vvedenoe)
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

        }
    }
}
