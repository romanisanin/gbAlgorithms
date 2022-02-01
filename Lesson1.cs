using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    internal class Lesson1 : Lesson {

        Lesson1Task1 task1 = new Lesson1Task1();
        Lesson1Task2 task2 = new Lesson1Task2();
        public Lesson1()
        {
            Description = "Lesson1. Block diagrams, asymptotic complexity, recursion";
            tasks = new List<Task>();
            
            tasks.Add(task1);
            tasks.Add(task2);
        }

        public override void runTask(int taskNumber)
        {
            Console.Clear();
            switch (taskNumber)
            {
                case 0:
                    task1.getNumber();
                    task1.checkIsPrimePositiveTest();
                    task1.checkIsPrimeNegativeTest();
                    break;
                case 1:
                    int number = task2.getNumber();
                    Console.WriteLine("Fibonacci number using recurcive method: " + task2.GetFibonacciRec(number) + "\n");
                    Console.WriteLine("Fibonacci number using loop method: " + task2.GetFibonacci(number) + "\n");

                    break;
                default:
                    break;
            }
            
            Console.WriteLine("Press any button to return to the main menu.");
            System.Console.ReadKey();
            
        }
    } 
}
