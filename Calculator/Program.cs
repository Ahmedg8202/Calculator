using Calculator.Classes;
using Calculator.Helpers;
using Calculator.Interfaces;

namespace Calculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true) {

                double firstNumber = Inputs.inputNumber("first");

                string operation = Inputs.inputOperation();

                double secondNumber = Inputs.inputNumber("second");

                ICalculator calculator = CalculatorFactor.GetCalculator(operation);

                try
                {
                    Console.WriteLine(calculator.Calculate(firstNumber, secondNumber));
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write("Press 1 To do another operation or any char to exit: ");
                if(!int.TryParse(Console.ReadLine(),out int exists) || exists != 1)
                {
                    break;
                }
            }
        }
        

    }
}
