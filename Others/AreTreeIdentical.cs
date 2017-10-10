using System;

namespace Others
{
    public class AreTreesIdentical
    {
        public void ExecuteAreTreesIdentical()
        {
            Node node7 = new Node { Data = 7 };
            Node node9 = new Node { Data = 9 };
            Node node1 = new Node { Data = 1, Right = node7 };
            Node node2 = new Node { Data = 2, Right = node9 };
            Node node12 = new Node { Data = 12 };
            Node node33 = new Node { Data = 33 };

            Node node5 = new Node { Data = 5, Right = node2, Left = node1 };
            Node node39 = new Node { Data = 39, Left = node33 };
            Node node10 = new Node { Data = 10, Left = node5, Right = node12 };

            Node root1 = new Node { Data = 1, Left = node10, Right = node39 };

            Node node7_2 = new Node { Data = 7 };
            Node node9_2 = new Node { Data = 9 };
            Node node1_2 = new Node { Data = 1, Right = node7_2 };
            Node node2_2 = new Node { Data = 2, Right = node9_2 };
            Node node12_2 = new Node { Data = 12 };
            Node node33_2 = new Node { Data = 33 };

            Node node5_2 = new Node { Data = 5, Right = node2_2, Left = node1_2 };
            Node node39_2 = new Node { Data = 39, Left = node33_2 };
            Node node10_2 = new Node { Data = 10, Left = node5_2, Right = node12_2 };

            Node root2 = new Node { Data = 1, Left = node10_2, Right = node39_2 };

            System.Console.WriteLine(AreTreesIdenticalCheck(root1, root2));
        }

        public bool AreTreesIdenticalCheck(Node one, Node two)
        {
            if (one == null && two == null) return true;
            if (one == null || two == null) return false;

            if (one.Data == two.Data)
            {
                return AreTreesIdenticalCheck(one.Left, two.Left) && AreTreesIdenticalCheck(one.Right, two.Right);
            }

            return false;
        }


    }
}