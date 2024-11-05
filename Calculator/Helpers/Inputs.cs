using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Helpers
{
    public static class Inputs
    {
        public static double inputNumber(string firstOrSecondNumber)
        {
            Console.Write($"Enter the {firstOrSecondNumber} Number:");

            double number;
            while (!Double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write($"Invalid input\nEnter the {firstOrSecondNumber} number:");
            }
            return number;
        }
        public static string inputOperation()
        {
            Console.Write("Choose Operation (+, -, *, /): ");
            string operation = Console.ReadLine().Trim();

            while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Invalid input. Please choose a valid operation.");
                Console.Write("Choose Operation (+, -, *, /): ");
                operation = Console.ReadLine().Trim();
            }

            return operation;
        }
    }
}
