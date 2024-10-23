using System;

namespace ketvirtauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite saco amziu");
            int X = int.Parse(Console.ReadLine());

            if (X>= 18)
            {
                Console.WriteLine("jus galite balsuoti");

            }
            else
            {
                Console.WriteLine("jus negalite balsuoti");
            }
        }

    }
}






