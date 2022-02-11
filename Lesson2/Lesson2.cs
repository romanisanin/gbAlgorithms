using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    public class Lesson2 : Lesson
    {

        Lesson2Task1 Task1 = new Lesson2Task1();
        public Lesson2()
        {
            Description = "Lesson 2. Array, List, Search";
            Tasks = new List<ITask>();

            Tasks.Add(Task1);
        }

        public override void RunTask(int taskNumber)
        {
            Console.Clear();
            switch (taskNumber)
            {
                case 0:
                    Console.WriteLine("Initial State");
                    Console.WriteLine($"Number of Nodes: {Task1.GetCount()}\n");

                    Console.WriteLine("Add a node");
                    Task1.AddNode(1);
                    Task1.PrintLinkedList();
                    Console.WriteLine($"Number of Nodes: {Task1.GetCount()}\n");

                    Console.WriteLine("Add a node");
                    Task1.AddNode(2);
                    Task1.PrintLinkedList();
                    Console.WriteLine($"Number of Nodes: {Task1.GetCount()}\n");

                    Console.WriteLine("Add a node between 1 and 2 nodes");
                    Task1.AddNodeAfter(Task1.head.NextNode, 3);
                    Task1.PrintLinkedList();
                    Console.WriteLine($"Number of Nodes: {Task1.GetCount()}\n");

                    Console.WriteLine("Remove the node added on the last step");
                    Task1.RemoveNode(Task1.head.NextNode);
                    Task1.PrintLinkedList();
                    Console.WriteLine($"Number of Nodes: {Task1.GetCount()}\n");

                    Console.WriteLine("Remove the second node");
                    Task1.RemoveNode(Task1.head.NextNode);
                    Task1.PrintLinkedList();
                    Console.WriteLine($"Number of Nodes: {Task1.GetCount()}\n");

                    Console.WriteLine("Add a node");
                    Task1.AddNode(4);
                    Task1.PrintLinkedList();
                    Console.WriteLine($"Number of Nodes: {Task1.GetCount()}\n");

                    Console.WriteLine("Find a node by value");
                    var foundNode = Task1.FindNode(10);
                    Console.WriteLine($"Searched number = 10. Found: {foundNode?.Value ?? 0}");
                    foundNode = Task1.FindNode(4);
                    Console.WriteLine($"Searched number = 4. Found: {foundNode?.Value}/n");

                    Console.WriteLine("Add a node after the head node");
                    Task1.AddNodeAfter(Task1.head.NextNode, 5);
                    Task1.PrintLinkedList();
                    Console.WriteLine($"Number of Nodes: {Task1.GetCount()}\n");

                    Console.WriteLine("Remove the second node");
                    Task1.RemoveNode(2);
                    Task1.PrintLinkedList();
                    Console.WriteLine($"Number of Nodes: {Task1.GetCount()}\n");

                    break;
                default:
                    break;
            }

            Console.WriteLine("Press any button to return to the main menu.");
            Console.ReadKey();

        }
    }
}
