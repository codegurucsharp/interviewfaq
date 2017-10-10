using System;

namespace Others
{
    public class BinTreeLeftRightView
    {
        int maxLevel;
        public void ExecuteBinTreeLeftRightView()
        {
            //           21
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
            Node node21 = new Node { Data = 21, Left = node10, Right = node39 };

            System.Console.WriteLine("Left view for the tree:");
            LeftView(node21);
            System.Console.WriteLine("Right view for the tree:");
            RightView(node21);
        }

        private void LeftView(Node node, int level)
        {
            if (node == null) return;

            if (level > maxLevel)
            {
                System.Console.WriteLine(node.Data);
                maxLevel = level;
            }

            LeftView(node.Left, level + 1);
            LeftView(node.Right, level + 1);
        }

        private void LeftView(Node node)
        {
            maxLevel = 0;
            LeftView(node, 1);
        }


        private void RightView(Node node, int level)
        {
            if (node == null) return;

            if (level > maxLevel)
            {
                System.Console.WriteLine(node.Data);
                maxLevel = level;
            }

            RightView(node.Right, level + 1);
            RightView(node.Left, level + 1);
        }

        private void RightView(Node node)
        {
            maxLevel = 0;
            RightView(node, 1);
        }
    }
}