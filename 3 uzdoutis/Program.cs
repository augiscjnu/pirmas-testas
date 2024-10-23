using System;

namespace treciauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite pirma skaiciu");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("iveskite vieksma");
            string G = (Console.ReadLine());

            Console.WriteLine("iveskite antra skaiciu");
            int H = int.Parse(Console.ReadLine());

            switch (G)
            {
                case "*":
                    int A = X * H;
                    Console.WriteLine( $"sandauga = {A} ");
                    break;
                case "+":
                    int B = X + H;
                    Console.WriteLine( $"suma = {B} ");
                    break;
                case "-":
                    int C = X - H;
                    Console.WriteLine( $"skirtumas = {C} ");
                    break;
                case "/":
                    int F = X / H;
                    Console.WriteLine( $"dalyba = {F}");
                    break;
               
               





            }
             
            }
        }

    }







