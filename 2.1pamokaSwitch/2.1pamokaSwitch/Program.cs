using System;

namespace _2._1pamokaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Noredami isgerti, irasykite skaiciu nuo 1 iki 4, jei nieko - irasykite 5");
            var irasytasSkaicius = Console.ReadLine();
            switch (irasytasSkaicius)
            {
                case "1":
                    Console.Write("jus pasirinkote : limodanas");
                    break;
                case "2":
                    Console.Write("jus pasirinkote : arbata");
                    break;
                case "3":
                    Console.Write("jus pasirinkote :kakava");
                    break;
                case "4":
                    Console.Write("jus pasirinkote : kava");
                    break;
                case "5":
                    Console.Write("jus pasirinkote : nieko");
                    break;
                default:
                    Console.Write("blogai ivestas pasirinkimas");
                    break;
            }
        }
    }
}
