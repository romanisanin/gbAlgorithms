using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    /// <summary>
    /// Implement fuction to calculate Fibonacci number 
    /// </summary>
    public class Lesson1Task2 : Task
    {
        public int Number { get; set; }
        public Lesson1Task2()
        {
            Description = "Task 2. Find Fibonacci number";
            Number = 0;
        }

        public int GetFibonacciRec(int number)
        {
            if (number == 0 || number == 1) { return number; }
            return GetFibonacciRec(number - 1) + GetFibonacciRec(number - 2);
        }

        public int GetFibonacci(int number)
        {
            Number = number;
            int[] Fib = new int[Number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= Number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[Number];
        }

        public int getNumber()
        {
            Console.WriteLine("Enter the number to find Fibonacci number:");
            int number = Int32.Parse(Console.ReadLine());
            return number;
        }
    }
}
