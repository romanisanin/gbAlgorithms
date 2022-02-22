using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    /// <summary>
    /// Binary Tree. Insert, remove, search, print.
    /// </summary>
    internal class Lesson4Task1 : ITask, ITree
    {
        public TreeNode Root { get; set; }

        public string Description => "Task 1. Binary Tree. Insert, remove, search, print.";

        static readonly int count = 10;

        /// <summary>
        /// Add Tree Node
        /// </summary>
        /// <param name="value">Tree Node value</param>
        public void AddItem(int value)
        {
            var newTreeNode = new TreeNode(value);

            if (Root == null)
            {
                Root = newTreeNode;
                return;
            }

            InsertRec(Root, newTreeNode);
        }

        /// <summary>
        /// Remove Tree Node by value
        /// </summary>
        /// <param name="value">Tree Node value</param>
        public void RemoveItem(int value)
        {
            RemoveUtil(Root, value);
        }

        /// <summary>
        /// Find Tree Node by value
        /// </summary>
        /// <param name="value">Tree Node value</param>
        /// <returns></returns>
        public TreeNode GetNodeByValue(int value)
        {
            return FindTreeNode(Root, value);
        }

        private TreeNode FindTreeNode(TreeNode root, int value)
        {
            if (root?.Value == value)
                return root;

            if (root != null)
            {

                if (value < root.Value)
                {
                    var result = FindTreeNode(root.LeftChild, value);
                    if (result != null)
                        return result;
                }
                else
                {
                    var result = FindTreeNode(root.RightChild, value);
                    if (result != null)
                        return result;
                }
            }

            return null;
        }

        public void PrintTree()
        {
            PrintTreeUtil(Root, 0);
        }
        /// <summary>
        /// Breadth-First Search
        /// </summary>
        public void BFS ()
        {
            Console.WriteLine("Breadth-First Search:");
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(Root);
            while (q.Count > 0)
            {
                TreeNode current = q.Dequeue();
                if (current == null)
                    continue;
                q.Enqueue(current.LeftChild);
                q.Enqueue(current.RightChild);

                Console.Write(current.Value + " ");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Deep-First Search
        /// </summary>
        public void DFS()
        {
            Console.WriteLine("Deep-First Search:");
            DFSUtil(Root);
            Console.WriteLine("\n");
        }

        private void DFSUtil(TreeNode root)
        {
            if (root != null)
            {
                Console.Write(root.Value+ " ");
                DFSUtil(root.LeftChild);
                DFSUtil(root.RightChild);
            }
        }

        private void PrintTreeUtil(TreeNode root, int space)
        {
            if (root == null) return;

            space += count;

            PrintTreeUtil(root.RightChild, space);
            Console.Write("\n");

            for (int i = count; i < space; i++)
                Console.Write(" ");

            Console.Write(root.Value + "\n");

            PrintTreeUtil(root.LeftChild, space);
        }
        private void InsertRec(TreeNode root, TreeNode newTreeNode)
        {
            if (newTreeNode.Value < root.Value)
            {
                if (root.LeftChild == null)
                    root.LeftChild = newTreeNode;
                else
                    InsertRec(root.LeftChild, newTreeNode);
            }
            else
            {
                if (root.RightChild == null)
                    root.RightChild = newTreeNode;
                else
                    InsertRec(root.RightChild, newTreeNode);
            }
        }

        private TreeNode RemoveUtil(TreeNode root, int value)
        {
            if (root?.Value == value)
            {
                root = null;
            }

            if (root != null)
            {
                if (value < root.Value)
                {
                    root.LeftChild = RemoveUtil(root.LeftChild, value);
                }
                else
                {
                    root.RightChild = RemoveUtil(root.RightChild, value);
                }
            }

            return root;
        }
    }
}
