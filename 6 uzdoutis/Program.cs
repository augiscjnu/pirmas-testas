using System;

namespace sestauzdoutis 
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            int X = int.Parse(Console.ReadLine());

            if (X>= 10 && X<= 100 )
            {

                Console.WriteLine("skaicius yra tarp 10 ir 100 imtinai ");

            }
            else
            {
                Console.WriteLine("skaicius nera yra tarp 10 ir 100 imtinai");
            }
        }

    }
}






