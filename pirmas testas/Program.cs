using System;

namespace pirmastestas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            int X = int.Parse(Console.ReadLine());

            if (X > 0)
            {
                Console.WriteLine("skaicius yra tiegiamas");

            }
            else
            {
                Console.WriteLine("skaicius yra ne tiegiamas");
            }
        }

    }
}






