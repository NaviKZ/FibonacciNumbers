using System;

namespace FibonacciNumbers
{
    internal class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите индекс числа Фибоначчи:");
            int fibonacciNumberIndex = Convert.ToInt32(Console.ReadLine());

            int previousFibonacciNumber = 0;
            int currentFibonacciNumber = 1;

            if (fibonacciNumberIndex == 0)
            {
                currentFibonacciNumber = 0;
            }
            else if (fibonacciNumberIndex == 1)
            {
                currentFibonacciNumber = 1;
            }
            else for (int i = 2; i <= fibonacciNumberIndex; ++i)
                {
                    int sum = previousFibonacciNumber + currentFibonacciNumber;
                    previousFibonacciNumber = currentFibonacciNumber;
                    currentFibonacciNumber = sum;
                }

            Console.WriteLine("Число Фибоначчи: " + currentFibonacciNumber);
            Console.ReadKey();
        }
    }
}