using System;

namespace dviliktauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("meniu");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Burgeris  kaina 5 Eur ");
            int G = 5;
            Console.WriteLine();
            Console.WriteLine("2. Pica   kaina  7 Eur");
            int J = 7;
            Console.WriteLine();
            Console.WriteLine("3. Kava   kaina   2 Eur");
            int L = 2;
            Console.WriteLine();
            Console.WriteLine("4. Kebabas  kaina  6 Eur");
            int O = 6;
            Console.WriteLine();
            Console.WriteLine("5. Arbata   kaina   1.5 Eur");
            double U = 1.5;
            Console.WriteLine();
            string S = (Console.ReadLine());
            Console.WriteLine("ar norite papildomai siuro? (t arba n) (+1 Eur) ");
            string E = (Console.ReadLine());
                switch (S)
                {
                    case "1":
                        Console.WriteLine($"is viso {G} Eur");
                        break;

                    case "2":
                        Console.WriteLine($"is viso {J} Eur");
                        break;
                    case "3":
                        Console.WriteLine($"is viso {L} Eur");
                        break;
                    case "4":
                        Console.WriteLine($"is viso {O} Eur");
                        break;
                    case "5":
                        Console.WriteLine($"is viso {U} Eur");
                        break;

                }




            }
        }

    }
}












