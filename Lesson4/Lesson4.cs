using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    public class Lesson4 : Lesson
    {

        Lesson4Task1 Task1 = new Lesson4Task1();
        public Lesson4()
        {
            Description = "Lesson 4. Trees. Hash Tables";
            Tasks = new List<ITask>();

            Tasks.Add(Task1);
        }

        public override void RunTask(int taskNumber)
        {
            Console.Clear();
            switch (taskNumber)
            {
                case 0:
                    Task1.AddItem(4);
                    Task1.AddItem(2);
                    Task1.AddItem(5);
                    Task1.AddItem(1);
                    Task1.AddItem(8);
                    Task1.AddItem(6);
                    Task1.AddItem(3);
                    Task1.PrintTree();
                    Console.WriteLine("_____________________________________________");
                    var foundNode = Task1.GetNodeByValue(15);
                    Console.WriteLine($"Searched number = 15. Found: {foundNode?.Value ?? 0}");
                    foundNode = Task1.GetNodeByValue(6);
                    Console.WriteLine($"Searched number = 6. Found: {foundNode?.Value ?? 0}");
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine("Removing 1");
                    Task1.RemoveItem(1);
                    Task1.PrintTree();
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine("Removing 5");
                    Task1.RemoveItem(5);
                    Task1.PrintTree();
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine("Removing 10");
                    Task1.RemoveItem(5);
                    Task1.PrintTree();
                    break;

                default:
                    break;
            }

            Console.WriteLine("Press any button to return to the main menu.");
            Console.ReadKey();

        }
    }
}
