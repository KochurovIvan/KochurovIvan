using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Кто будет угадывать? \n Игрок-нажмите X \n Компьютер- нажмите Y ");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Вы нажали букву Y Компьютер");
                    var A = new Igra();
                    A.Igra2();
                    Console.ReadKey();
                    break;
                case "X":
                    Console.WriteLine("Вы нажали букву X Игрок");
                    var B = new Igra();
                    B.Igra1();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }






        }
    }
}
