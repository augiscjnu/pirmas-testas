using System;

namespace penktauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            int X = int.Parse(Console.ReadLine());
             double H = Math.Sqrt(X);
            if (X>0)
            {
                
                Console.WriteLine($"skaiciaus kvadratine saknis = {H}");

            }
            else
            {
                Console.WriteLine("kvadratines saknies istraukti negalima");
            }
        }

    }
}






