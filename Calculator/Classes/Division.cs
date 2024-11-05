using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Interfaces;

namespace Calculator.Classes
{
    internal class Division : ICalculator
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
                throw new DivideByZeroException("Can't divid by zero");

            return firstNumber / secondNumber;
        }
    }
}
