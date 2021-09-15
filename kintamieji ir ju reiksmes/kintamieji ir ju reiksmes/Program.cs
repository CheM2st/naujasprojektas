using System;

namespace kintamieji_ir_ju_reiksmes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            var firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            var secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu");
            var thirdNumber = Convert.ToDouble(Console.ReadLine());

            if (firstNumber > secondNumber && firstNumber < 100)
            {
                Console.WriteLine("pirmas skaicius didesnis uz antra skaiciu ir mazesnis uz 100");
            }
            if (secondNumber > 0 && secondNumber > firstNumber)
            {
                Console.WriteLine("antras skaicius didesnis uz nuli ir mazesnis uz pirma skaiciu");
            }
            if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > 0)
            {
                Console.WriteLine("pirmas skaicius didesnis uz antra skaiciu, uz trecia skaicius ir yra teigiamas");
            }
            if (thirdNumber >= 5 && thirdNumber <= 10 || thirdNumber > firstNumber || thirdNumber > secondNumber)
            {
                Console.WriteLine("pirmas skaicius yra tarp 5 ir 10 arba yra didesnis uz pirma arba didesnis uz antra");
            }
        }
    }
}
