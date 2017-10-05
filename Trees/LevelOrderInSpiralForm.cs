using System;
using System.Collections.Generic;

namespace Trees
{
    public class LevelOrderInSpiralForm
    {
        public void ExecuteLevelOrderInSpiralForm()
        {
            //           1
            //        /     \
            //      10      39
            //     /  \    /
            //   5     12 33
            //  /  \
            // 1    2
            //  \    \
            //   7    9

            Node node7 = new Node { Data = 7 };
            Node node9 = new Node { Data = 9 };
            Node node1 = new Node { Data = 1, Right = node7 };
            Node node2 = new Node { Data = 2, Right = node9 };
            Node node12 = new Node { Data = 12 };
            Node node33 = new Node { Data = 33 };

            Node node5 = new Node { Data = 5, Right = node2, Left = node1 };
            Node node39 = new Node { Data = 39, Left = node33 };
            Node node10 = new Node { Data = 10, Left = node5, Right = node12 };

            Node root = new Node { Data = 1, Left = node10, Right = node39 };

            //PrintLevelOrderInSpiralFormIterative(root);
            PrintLevelOrderInSpiralRecursive(root);
        }

        public void PrintLevelOrderInSpiralFormIterative(Node n)
        {
            Stack<Node> s1 = new Stack<Node>();
            Stack<Node> s2 = new Stack<Node>();

            s1.Push(n);

            while (s1.Count > 0 || s2.Count > 0)
            {
                Node node = null;
                while (s1.Count > 0)
                {
                    node = s1.Pop();
                    System.Console.WriteLine(node.Data);
                    if (node.Right != null) s2.Push(node.Right);
                    if (node.Left != null) s2.Push(node.Left);
                }

                while (s2.Count > 0)
                {
                    node = s2.Pop();
                    System.Console.WriteLine(node.Data);
                    if (node.Left != null) s1.Push(node.Left);
                    if (node.Right != null) s1.Push(node.Right);
                }
            }
        }

        public void PrintLevelOrderInSpiralRecursive(Node n)
        {
            HeightOfTree h = new HeightOfTree();
            int height = h.GetHeightIterative(n);

            bool reverse = false;
            for (int i = 1; i <= height; i++)
            {
                reverse = !reverse;
                PrintNodesAtLevelSpiral(n, i, reverse);
            }
        }

        public void PrintNodesAtLevelSpiral(Node n, int i, bool reverse)
        {
            if(n == null) return;
            if (i == 1)
            {
                System.Console.WriteLine(n.Data); return;
            }

            if (!reverse)
            {
                PrintNodesAtLevelSpiral(n.Left,i-1,reverse);
                PrintNodesAtLevelSpiral(n.Right,i-1,reverse);
            }
            else
            {
                PrintNodesAtLevelSpiral(n.Right,i-1,reverse);
                PrintNodesAtLevelSpiral(n.Left,i-1,reverse);
            }
        }
    }
}