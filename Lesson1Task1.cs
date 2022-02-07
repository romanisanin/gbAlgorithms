using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    /// <summary>
    /// Check if the number is prime
    /// </summary>
    internal class Lesson1Task1 : Task
    {
        public int Number { get; set; }
        public Lesson1Task1()
        {
            Description = "Task1. Check if the number is prime";
            Number = 0;
        }
        private bool IsPrime(int number)
        {
            Number = number;
            int d = 0;
            int i = 2;
            while (i < Number)
            {
                if (Number % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetNumber()
        {
            Console.WriteLine("Enter the number to check if it is prime:");
            if (IsPrime(Int32.Parse(Console.ReadLine())) == true)
            {
                Console.WriteLine($"Number {Number} is prime number\n");
            }
            else
            {
                Console.WriteLine($"Number {Number} is not prime number\n");
            }
        }

        public void CheckIsPrimePositiveTest()
        {
            if (IsPrime(23) == true)
            {
                Console.WriteLine("Positive test passed\n");
            }
            else
            {
                Console.WriteLine("Positive test failed\n");
            }
        }

        public void CheckIsPrimeNegativeTest()
        {
            if (IsPrime(0) == false)
            {
                Console.WriteLine("Negative test passed\n");
            }
            else
            {
                Console.WriteLine("Negative test failed\n");
            }
        }

    }
}
