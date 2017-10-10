using System;

namespace Others
{
    public class MakeMirrorBinaryTree
    {
        public void ExecuteMakeMirrorTree()
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
            InorderTraversal(root);
            MakeMirror(root);
            InorderTraversal(root);

        }

        public void MakeMirror(Node node)
        {
            if (node == null) return;

            MakeMirror(node.Left);
            MakeMirror(node.Right);

            Node tmp = node.Left;

            node.Left = node.Right;
            node.Right = tmp;
        }

        public void InorderTraversal(Node node)
        {
            if (node == null) return;
            InorderTraversal(node.Left);
            System.Console.WriteLine(node.Data);
            InorderTraversal(node.Right);
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }

        public Node Right { get; set; }
    }
}