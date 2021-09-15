using System;

namespace ifai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite savo amziu");
            var age = Convert.ToInt32(Console.ReadLine());

            if (age >= 20)
            {
                Console.WriteLine("sveiki prisijunge");
            }
            else
            {
                Console.WriteLine("paauk biski");
            }
        }
    }
}
