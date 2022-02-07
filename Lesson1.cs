using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    public class Lesson1 : Lesson
    {

        Lesson1Task1 Task1 = new Lesson1Task1();
        Lesson1Task2 Task2 = new Lesson1Task2();
        public Lesson1()
        {
            Description = "Lesson1. Block diagrams, asymptotic complexity, recursion";
            Tasks = new List<Task>();

            Tasks.Add(Task1);
            Tasks.Add(Task2);
        }

        public override void RunTask(int taskNumber)
        {
            Console.Clear();
            switch (taskNumber)
            {
                case 0:
                    Task1.GetNumber();
                    Task1.CheckIsPrimePositiveTest();
                    Task1.CheckIsPrimeNegativeTest();
                    break;
                case 1:
                    int number = Task2.getNumber();
                    Console.WriteLine("Fibonacci number using recurcive method: " + Task2.GetFibonacciRec(number) + "\n");
                    Console.WriteLine("Fibonacci number using loop method: " + Task2.GetFibonacci(number) + "\n");

                    break;
                default:
                    break;
            }

            Console.WriteLine("Press any button to return to the main menu.");
            System.Console.ReadKey();

        }
    }
}
