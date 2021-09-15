using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("koks vardas?");
                string name = Console.ReadLine();
            Console.WriteLine("kokia pavarde?");
            string surname = Console.ReadLine();
            Console.WriteLine("kiek  metu?");
            string age = Console.ReadLine();
            Console.WriteLine(name + " " + surname + " " + age);
            // Console.WriteLine($"{name} {surname} {age}");
            // var - kintamasis viskam :)) ; 
            // var age = Covert.To.Int64 Console.ReadLine(); (jei norim konvertuot)
        }
    }
}
