using System;

namespace _2._3uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite spalvos koda!");
            Console.WriteLine("Raudonos spalvos kodas: #ff0a0a");
            Console.WriteLine("Geltonos spalvos kodas: #ffe20a");
            Console.WriteLine("Žalia spalvos kodas: #008509");
            string irasytasKodas = Console.ReadLine();

            if (irasytasKodas == "#ff0a0a")
            {
                Console.WriteLine("vaziuoti draudziama");
            }
            else if (irasytasKodas == "#ffe20a")
            {
                Console.WriteLine("pasiruoskite");
            }
            else if (irasytasKodas == "#008509")
            {
                Console.WriteLine("vaziuoti galima");
            }
            else
            {
                Console.WriteLine("neatpazinta spalva");
            }
        }
    }
}
