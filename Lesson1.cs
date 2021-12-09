using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    internal class Lesson1 {
        public Lesson1()
        {
            while (true)
            {
                Console.WriteLine("Enter a task number:");
                Console.WriteLine("1. Task1. Check if the number is prime");
                Console.WriteLine("2. Task2. Find Fibonacci number");

                int tasknumber = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (tasknumber - 1)
                {
                    case 0:
                        Lesson1Task1 task1 = new Lesson1Task1();
                        task1.getNumber();
                        task1.checkIsPrimePositiveTest();
                        task1.checkIsPrimeNegativeTest();
                        break;
                    case 1:
                        Lesson1Task2 task2 = new Lesson1Task2();
                        int number = task2.getNumber();
                        Console.WriteLine("Fibonacci number using recurcive method: " + task2.GetFibonacciRec(number)+ "\n");
                        Console.WriteLine("Fibonacci number using loop method: " + task2.GetFibonacci(number) + "\n");
                        
                        break;
                    default: 
                        break;
                }
            }

        }
    }
    
}
