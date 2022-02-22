using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    public class Lesson2Task1 : ITask, ILinkedList
    {
        public Node head { get; set; }
        public string Description => "Task 1. Doubly Linked List";

        public void PrintLinkedList()
        {
            var last = head;
            Console.Write(last.Value + " ");
            while (last.NextNode != null)
            {
                last = last.NextNode;
                Console.Write(last.Value + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// returns number of elements in the list
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            int counter = 0;
            if (head != null)
            {
                counter++;
            }
            else
            {
                return counter;
            }

            var last = head;

            while (last.NextNode != null)
            {
                last = last.NextNode;
                counter++;
            }
            return counter;
        }

        /// <summary>
        /// adds a new list element
        /// </summary>
        /// <param name="value"></param>
        public void AddNode(int value)
        {
            var newNode = new Node(value);

            var lastNode = head;

            newNode.NextNode = null;

            if (head == null)
            {
                newNode.PrevNode = null;
                head = newNode;
                return;
            }

            while (lastNode.NextNode != null)
                lastNode = lastNode.NextNode;

            lastNode.NextNode = newNode;

            newNode.PrevNode = lastNode;
        }

        /// <summary>
        /// Adds a new list element after n-element
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node(value);

            var lastNode = node;

            newNode.NextNode = null;

            if (lastNode.NextNode != null)
                newNode.NextNode = lastNode.NextNode;

            newNode.PrevNode = lastNode;
            lastNode.NextNode = newNode;
        }

        /// <summary>
        /// deletes element by number 
        /// </summary>
        /// <param name="index"></param>
        public void RemoveNode(int index)
        {
            var lastNode = head;
            int counter = 1;
            while (counter != index)
            {
                lastNode = lastNode.NextNode;
                counter++;
            }
            RemoveNode(lastNode);
        }

        /// <summary>
        /// deletes the specified element
        /// </summary>
        /// <param name="node"></param>
        public void RemoveNode(Node node)
        {
            var lastNode = node.PrevNode;
            lastNode.NextNode = null;
            node.PrevNode = null;

            if (node.NextNode != null)
            {
                lastNode.NextNode = node.NextNode;
                node.NextNode.PrevNode = lastNode;
                node.NextNode = null;
            }
        }

        /// <summary>
        /// Finds element by the value 
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public Node FindNode(int searchValue)
        {
            var lastNode = head;

            while (lastNode.Value != searchValue)
            {
                if (lastNode.NextNode == null)
                {
                    return null;
                }
                lastNode = lastNode.NextNode;

            }

            return lastNode;
        }

    }
}
