using System;
using System.Collections.Generic;

namespace Trees
{
    public class LevelOrderTraversal
    {
        public void ExecuteLevelOrderTraversal()
        {
            //           1
            //        /     \
            //      10      39
            //     /  \    /
            //   5     12 33
            //     \
            //      2

            Node node2 = new Node { Data=2 };
            Node node12 = new Node{Data=12};
            Node node33 = new Node { Data=33};

            Node node5 = new Node{Data = 5, Right = node2};
            Node node39 = new Node{Data = 39, Left=node33};
            Node node10 = new Node{Data = 10, Left = node5, Right = node12};
            
            Node root = new Node{ Data = 1, Left = node10 , Right = node39};

            //Console.WriteLine("Height of tree using recursion: {0}", GetHeightRecursive(root));
            //PrintLevelOrderTraversalIterative(root);
            //PrintLevelOrderTraversalIterative2(root);
            PrintLevelOrderRecursive(root);
        }

        public void PrintLevelOrderTraversalIterative2(Node node)
        {
            // the only difference between this method and other is that in this one you can print each level seperately
            // the other does not care of levels it just prints in-order which simplifies code and decreases one inner loop.

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            
            while(true)
            {
                int queueItemcount = queue.Count;
                if(queueItemcount==0) return;
                Console.Write("\n>");
                while(queueItemcount>0)
                {
                    Node currentNode = queue.Dequeue();
                    System.Console.Write(currentNode.Data + " ");

                    if(currentNode.Left!=null) queue.Enqueue(currentNode.Left);
                    if(currentNode.Right!=null) queue.Enqueue(currentNode.Right);
                    queueItemcount--;
                }
            }
        }

        public void PrintLevelOrderTraversalIterative(Node node)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            
            while(true)
            {
                if(queue.Count==0) return;
                Node currentNode = queue.Dequeue();
                Console.Write(currentNode.Data + " ");
                if(currentNode.Left!=null) queue.Enqueue(currentNode.Left);
                if(currentNode.Right!=null) queue.Enqueue(currentNode.Right);
            }
        }

        public void PrintLevelOrderRecursive(Node node)
        {
            HeightOfTree h = new HeightOfTree();
            int height = h.GetHeightIterative(node);

            for (int i = 1; i <= height; i++)
            {
                Console.Write(">");
                PrintNodesAtLevel(node,i);
                Console.WriteLine();
            }
        }

        public void PrintNodesAtLevel(Node n, int i)
        {
            if(n==null || i<1) return;

            if(i == 1) System.Console.Write(n.Data+" ");
            else
                {
                    PrintNodesAtLevel(n.Left,i-1);
                    PrintNodesAtLevel(n.Right,i-1);
                }

        }
    }
}