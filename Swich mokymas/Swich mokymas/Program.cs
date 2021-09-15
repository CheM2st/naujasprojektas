using System;

namespace Switch_mokymas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 10");
            var grade = Console.ReadLine();

            switch(grade)
            {
                case "10":
                    Console.WriteLine("Puikiai");
                    break;
                case "9":
                    Console.WriteLine("labai gerai");
                    break;
                case "8":
                    Console.WriteLine(" gerai");
                    break;
                default:
                    Console.WriteLine("jus neislaiket");
                    break;
            }
        }
    }
}
