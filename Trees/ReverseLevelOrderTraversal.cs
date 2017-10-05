using System;
using System.Collections.Generic;

namespace Trees
{
    public class ReverseLevelOrderTraversal
    {
        public void ExecuteReverseLevelOrderTraversal()
        {
            //           1
            //        /     \
            //      10      39
            //     /  \    /
            //   5     12 33
            //     \
            //      2

            Node node2 = new Node { Data = 2 };
            Node node12 = new Node { Data = 12 };
            Node node33 = new Node { Data = 33 };

            Node node5 = new Node { Data = 5, Right = node2 };
            Node node39 = new Node { Data = 39, Left = node33 };
            Node node10 = new Node { Data = 10, Left = node5, Right = node12 };

            Node root = new Node { Data = 1, Left = node10, Right = node39 };

            //Console.WriteLine("Height of tree using recursion: {0}", GetHeightRecursive(root));
            PrintReverseLevelOrderTraversalIterative(root);
            // PrintReverseLevelOrderRecursive(root);
        }

        public void PrintReverseLevelOrderTraversalIterative(Node node)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            Stack<Node> stack = new Stack<Node>();

            while (true)
            {
                if (queue.Count == 0) break;
                Node currentNode = queue.Dequeue();
                // Notice instead of printing we are just keeping in a queue, 
                // this queue is then just emptied in the end.
                stack.Push(currentNode);
                if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
                if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
            }

            // empty the queue and print out everything
            while (stack.Count > 0)
            {
                System.Console.WriteLine(stack.Pop().Data);
            }
        }

        public void PrintReverseLevelOrderRecursive(Node node)
        {
            HeightOfTree h = new HeightOfTree();
            int height = h.GetHeightIterative(node);

            for (int i = height; i > 0; i--)
            {
                Console.Write(">");
                PrintNodesAtLevel(node, i);
                Console.WriteLine();
            }
        }

        public void PrintNodesAtLevel(Node n, int i)
        {
            if (n == null || i < 1) return;

            if (i == 1) System.Console.Write(n.Data + " ");
            else
            {
                PrintNodesAtLevel(n.Right, i - 1);
                PrintNodesAtLevel(n.Left, i - 1);
            }
        }
    }
}