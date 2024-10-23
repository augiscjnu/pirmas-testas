using System;
using System.ComponentModel.Design;

namespace desimtauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            int X = int.Parse(Console.ReadLine());


            if (X > 0 && (X % 2 == 0))
                Console.WriteLine("skaicius yra lyginis ir tiegiamas");

            else if (X < 0 || (X % == 0))
                Console.WriteLine("skaicius nera tiegiamas");

            else if ((X % 2 != 0) || X <0 )
                Console.WriteLine("skaicius nera lyginis");


            }
        }

    }







