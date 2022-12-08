
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
            Func<int, int, int> differenceFunc = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber - secondNumber;
            };
            Func<int, int, int> multiplyFunc = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber * secondNumber;
            };
            Func<int, int, int> divisionFunc = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber / secondNumber;
            };


            Console.WriteLine($"Sum is {sumFunc(20, 10)}");
            Console.WriteLine($"Difference is {differenceFunc(20, 10)}");
            Console.WriteLine($"Product is {multiplyFunc(20, 10)}");
            Console.WriteLine($"Quotient is {divisionFunc(20, 10)}");
        }
        

    }
}
