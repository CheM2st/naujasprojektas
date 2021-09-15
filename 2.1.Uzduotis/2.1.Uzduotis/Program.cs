using System;

namespace _2._1.Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Noredami isgerti, irasykite skaiciu nuo 1 iki 4, jei nieko - irasykite 5");
            int irasytasSkaicius = Convert.ToInt32(Console.ReadLine());
            if (irasytasSkaicius == 1)
            {
                Console.WriteLine("Jus pasirinkote limonada");
            }
            else if (irasytasSkaicius == 2)
            {
                Console.WriteLine("Jus pasirinkote arbata");
            }
            else if (irasytasSkaicius == 3)
            {
                Console.WriteLine("Jus pasirinkote kakava");
            }
            else if (irasytasSkaicius == 4)
            {
                Console.WriteLine("Jus pasirinkote kava");
            }
            else if (irasytasSkaicius == 5)
            {
                Console.WriteLine("Jus nieko nepasirinkote ");
            }
            else
            {
                Console.WriteLine("blogai ivestas pasirinkimas");
            }
            }
        }
    }