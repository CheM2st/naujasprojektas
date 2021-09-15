using System;

namespace _2._2.uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite pirma skaiciu");
            double pirmasSkaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Irasykite antra skaiciu");
            double antrasSkaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Irasykite trecia skaiciu");
            double treciasSkaicius = Convert.ToDouble(Console.ReadLine());
            if (pirmasSkaicius == 1)
            {
                double trijuSuma = pirmasSkaicius + antrasSkaicius + treciasSkaicius;
                Console.WriteLine(trijuSuma);
            }
            if (pirmasSkaicius == 2)
            {
                double pirmoTrecio = pirmasSkaicius - treciasSkaicius;
                Console.WriteLine(pirmoTrecio);
            }
            if (pirmasSkaicius == 3)
            {
                double skaiciuSandauga = antrasSkaicius * treciasSkaicius;
                Console.WriteLine(skaiciuSandauga);
            }
        }
    }
}
