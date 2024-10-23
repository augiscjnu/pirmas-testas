using System;

namespace antrauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            int X = int.Parse(Console.ReadLine());

            if (X % 2 == 0)
            {
                Console.WriteLine("skaicius yra lyginis");

            }
            else
            {
                Console.WriteLine("skaicius yra ne lyginis");
            }
        }

    }
}






