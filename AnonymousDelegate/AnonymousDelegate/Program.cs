
using System;

namespace AnonymousDelegate
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> sumFunc = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber + secondNumber;
            };
            Func<int, int, int> DifferenceFunc = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber - secondNumber;
            };
            Func<int, int, int> MultiplyFunc = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber * secondNumber;
            };
            Func<int, int, int> DivisionFunc = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber / secondNumber;
            };


            Console.WriteLine($"Sum is {sumFunc(20, 10)}");
            Console.WriteLine($"Difference is {DifferenceFunc(20, 10)}");
            Console.WriteLine($"Product is {MultiplyFunc(20, 10)}");
            Console.WriteLine($"Quotient is {DivisionFunc(20, 10)}");
        }
        

    }
}
