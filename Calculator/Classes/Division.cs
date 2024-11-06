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
            if (firstNumber == secondNumber && firstNumber == 0)
                throw new DivideByZeroException("Undefined(NaN), Can't divid zero by zero");
            if (secondNumber == 0)
                throw new DivideByZeroException("Infinity(∞), Can't divid by zero");//NaN

            return firstNumber / secondNumber;
        }
    }
}
