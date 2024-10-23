using System;

namespace septintauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite pirma skaiciu");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("iveskite antra skiaciu");
            int B = int.Parse(Console.ReadLine());


            if (X > B)
            {

                Console.WriteLine(" pirmas saicius yra disenis uz antra ");

            }
           else if (B>X )
            {
                Console.WriteLine("antras skaiciu yra didesnis uz pirma");
            }
        }

    }
}






