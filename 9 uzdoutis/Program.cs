using System;
using System.Diagnostics.CodeAnalysis;

namespace devintauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite pirma skaiciu");
            int pirma = int.Parse(Console.ReadLine());

            Console.WriteLine("iveskite antra skaiciu");
            int antra = int.Parse(Console.ReadLine());

            Console.WriteLine("iveskite trecia  skaiciu");
            int trecia = int.Parse(Console.ReadLine());

            int vidurkis = (pirma + antra + trecia) / 3;
            Console.WriteLine($"vidurkis {vidurkis}");

            if (vidurkis >= 5)
                Console.WriteLine("patenkinamas");
            else
            {
                Console.WriteLine(" nepatenkinimas ");
            }



        }
    }
}