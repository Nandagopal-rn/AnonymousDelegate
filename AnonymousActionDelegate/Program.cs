using System;

namespace AnonymousActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> sumAction = delegate (int firstNumber, int secondNumber)
            {
                Console.WriteLine($"Sum is {firstNumber + secondNumber}");
            };
            Action<int, int> differenceAction = delegate (int firstNumber, int secondNumber)
            {
                Console.WriteLine($"Difference is {firstNumber - secondNumber}");
            };
            Action<int, int> MultiplyAction = delegate (int firstNumber, int secondNumber)
            {
                Console.WriteLine($"Product is {firstNumber * secondNumber}");
            };
            Action<int, int> DivisionAction = delegate (int firstNumber, int secondNumber)
            {
                Console.WriteLine($"Quotient is {firstNumber / secondNumber}");
            };

            sumAction(20, 20);
            differenceAction(20, 20);
            MultiplyAction(20, 20);
            DivisionAction(20, 20);
        }
    }
}
