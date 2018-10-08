using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;

            while (cont)
            {
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                Console.WriteLine("");
                Console.WriteLine("Enter Length:");

                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width:");

                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height:");

                double height = double.Parse(Console.ReadLine());

                double perimeter = 2 * length + 2 * width;
                double area = length * width;
                double volume = area * height;

                Console.WriteLine("");
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);
                Console.WriteLine("");
                Console.WriteLine("Continue? (y/n)");

                if (Console.ReadLine() == "n")
                {
                    cont = false;
                }
                Console.WriteLine("");

                

            }
        }
        
    }
}

