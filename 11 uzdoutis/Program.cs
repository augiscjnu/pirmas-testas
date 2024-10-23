using System;
using System.ComponentModel.Design;

namespace venuoliktauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite valandini atlyginima");
            double X = double.Parse(Console.ReadLine());

            Console.WriteLine("iveskite dirbtu valandu skaiciu per savaite");
            int G =int.Parse (Console.ReadLine());

            

            if(G > 40) 
            {
                double F = G - 40;
                double H = F * 1.5;
                double K = H * X;
                
                Console.WriteLine($" visr {K}");
            
            }
            else if(G<40)
            {

                double A = X * G;
                Console.WriteLine($"savaitinis {A}");

            }
            else if()





        }

        }
    }









