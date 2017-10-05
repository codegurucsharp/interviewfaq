using System;
using System.Collections.Generic;

namespace Trees
{
    public class HeightOfTree
    {
//           1
//        /     \
//      10      39
//     /
//   5
//     \
//      2

        public void GetHeightOfTree()
        {
            Node node2 = new Node { Data=2 };
            Node node5 = new Node{Data = 5, Right = node2};
            Node node39 = new Node{Data = 39};
            Node node10 = new Node{Data = 10, Left = node5};
            
            Node root = new Node{ Data = 1, Left = node10 , Right = node39};

            //Console.WriteLine("Height of tree using recursion: {0}", GetHeightRecursive(root));
            Console.WriteLine("Height of tree using iterative queue method: {0}", GetHeightIterative(root));
        }

        public int GetHeightRecursive(Node node)
        {
            if(node==null)
            {
                return 0;
            }

            int leftHeight = GetHeightRecursive(node.Left);
            int rightHeight = GetHeightRecursive(node.Right);

            return leftHeight>rightHeight?leftHeight+1:rightHeight+1;            
        }

        public int GetHeightIterative(Node node)
        {
        // Create a queue.
        // Push root into the queue.
        // height = 0
        // Loop
        // 	nodeCount = size of queue
                
        //         // If number of nodes at this level is 0, return height
        // 	if nodeCount is 0
        // 		return Height;
        // 	else
        // 		increase Height

        //         // Remove nodes of this level and add nodes of 
        //         // next level
        // 	while (nodeCount > 0)
        // 		pop node from front
        // 		push its children to queue
        // 		decrease nodeCount
        //        // At this point, queue has nodes of next level

              Queue<Node> queue = new Queue<Node>();
              int depth =0;
              queue.Enqueue(node);
              int nodeCount = 0;

              while (true)
              {
                  nodeCount = queue.Count;
                  if(nodeCount ==0) return depth;
                  depth++;

                  while (nodeCount>0)
                  {
                      Node currentNode = queue.Dequeue();

                      if(currentNode.Left!=null) queue.Enqueue(currentNode.Left);
                      if(currentNode.Right!=null) queue.Enqueue(currentNode.Right);
                      nodeCount--;
                  }
              }
        }
    }

    public class Node{

        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}