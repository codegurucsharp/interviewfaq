using System;

namespace Others
{
    public class SumTreeImpl
    {
        public void ExecuteSumTree()
        {
            Node node1 = new Node { Data = 1 };
            Node node2 = new Node { Data = 2 };
            Node node3 = new Node { Data = 3, Left = node1, Right = node2 };
            Node node4 = new Node { Data = 4 };
            Node node6 = new Node { Data = 61 };
            Node node10 = new Node { Data = 10, Left = node4, Right = node6 };
            Node root = new Node { Data = 26, Left = node10, Right = node3 };

            System.Console.WriteLine("The tree IsSumTree={0}", IsSumTree(root));
            System.Console.WriteLine("The tree IsSumTree={0}", IsSumTreeWithoutUsingSumMethod(root));
        }

        private bool IsSumTree(Node root)
        {
            if (root == null) return true;

            if (root.Left == null && root.Right == null) return true;
            if (Sum(root.Left) + Sum(root.Right) == root.Data
            && IsSumTree(root.Left) && IsSumTree(root.Right))
                return true;

            return false;
        }

        private bool IsSumTreeWithoutUsingSumMethod(Node root)
        {
            if (root == null) return true;

            if (root.Left == null && root.Right == null) return true;

            if (IsSumTree(root.Left) && IsSumTree(root.Right))
            {
                Node leftTree = root.Left;
                Node rightTree = root.Right;
                int ls = 0;
                int rs = 0;
                if (leftTree != null)
                {
                    if (leftTree.Left == null & leftTree.Right == null)
                    {
                        ls = leftTree.Data;
                    }
                    else
                    {
                        ls = 2 * leftTree.Data;
                    }
                }

                if (rightTree != null)
                {
                    if (rightTree.Left == null & rightTree.Right == null)
                    {
                        rs = rightTree.Data;
                    }
                    else
                    {
                        rs = 2 * rightTree.Data;
                    }
                }

                if (ls + rs == root.Data)
                    return true;

            }

            return false;
        }

        private int Sum(Node root)
        {
            if (root == null) return 0;

            return root.Data + Sum(root.Left) + Sum(root.Right);
        }
    }
}