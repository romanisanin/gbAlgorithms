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
                    Task1.AddItem(25);
                    Task1.AddItem(20);
                    Task1.AddItem(10);
                    Task1.AddItem(22);
                    Task1.AddItem(5);
                    Task1.AddItem(12);
                    Task1.AddItem(1);
                    Task1.AddItem(8);
                    Task1.AddItem(15);
                    Task1.AddItem(36);
                    Task1.AddItem(30);
                    Task1.AddItem(40);
                    Task1.AddItem(28);
                    Task1.AddItem(38);
                    Task1.AddItem(48);
                    Task1.AddItem(45);
                    Task1.AddItem(50);
                    Task1.PrintTree();
                    Console.WriteLine("_____________________________________________");
                    Task1.BFS();
                    Console.WriteLine("_____________________________________________");
                    Task1.DFS();
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
                    Console.WriteLine("Removing 51");
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
