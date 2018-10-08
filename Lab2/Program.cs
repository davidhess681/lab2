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
            // The whole process is put in a while loop. This way the user can continue using the program for as long as needed.

            bool cont = true;

            while (cont)
            {
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                Console.WriteLine("");
                Console.WriteLine("Enter Length:");

                // Since user input is a string, we must parse it into a more usable data type.

                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width:");

                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height:");

                double height = double.Parse(Console.ReadLine());

                // We declare the calculations as variables before displaying the answer to the user.

                double perimeter = 2 * length + 2 * width;
                double area = length * width;
                double volume = area * height;

                Console.WriteLine("");
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);
                Console.WriteLine("");

                // If at the end the user does not want to continue, cont is changed to false which closes the program.

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

