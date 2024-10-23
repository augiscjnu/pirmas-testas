using System;

namespace tryliktauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite automobilio tipa");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Sedanas     pradine kaina 150 Eur ");
            Console.WriteLine();
            Console.WriteLine("2. Hacbekas     pradine kaina 100 Eur");
            Console.WriteLine();
            Console.WriteLine("3. SUV          pradine kaina 200 EUR");
            Console.WriteLine();
            Console.WriteLine("4. Universalas  pradine kaina 175 Eur");
            Console.WriteLine();
            string O = (Console.ReadLine());

            switch (O)
            {
                case "1":
                    int A = 150;
                    break;

                case "2":
                    int B = 100;
                    break;
                case "3":
                    int C = 200;
                    break;
                case "4":
                    int D = 175;
                    break;
              



            }

            Console.WriteLine("Ar norite gauti apsauga nuo vagystes? (+50 Eur) (tai/ne) ");
            string E = Console.ReadLine();
            if (E.Contains("taip"))
            {
                                   
                Console.WriteLine($"galutine draudimo kaina {50} ");

            }
             else
            {
                Console.WriteLine("galutine draudimo kaina");
            }       
            

        } 
       
        


    }
}






