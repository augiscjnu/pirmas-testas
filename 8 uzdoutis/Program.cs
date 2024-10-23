using System;

namespace astuntauzdoutis 
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
        int X = int.Parse(Console.ReadLine());

        Random B = new Random ();
            int C = B.Next(1, 11);

           
        


            if (X == C)
            {

                Console.WriteLine(" jus laimejote priza ");

            }
            else
            {
                Console.WriteLine("deja jusu skaicius nesutapo");
            }
        }

    }
}






