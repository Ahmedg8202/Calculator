using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Interfaces;

namespace Calculator.Classes
{
    public static class CalculatorFactor
    {
        public static ICalculator GetCalculator(string operation)
        {
            return operation switch
            {
                "+" => new Addition(),
                "-" => new Subtraction(),
                "*" => new Multiplication(),
                "/" => new Division()
            };

        }
    }
}
