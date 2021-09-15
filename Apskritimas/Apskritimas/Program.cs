using System;


namespace Apskritimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivesk apskritimo spinduli:");
            double radius = Convert.ToDouble(Console.ReadLine());

            double c = 2 * radius * Math.PI;
            double s = Math.PI * radius * radius;
            Console.WriteLine($"Apskirtimo ilgis yra: {c}");
            Console.WriteLine($"Apskirtimo plotas yra: {s}");
        }
    }
}
