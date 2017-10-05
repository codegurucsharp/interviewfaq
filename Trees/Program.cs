using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            // HeightOfTree height = new HeightOfTree();
            // height.GetHeightOfTree();

            // LevelOrderTraversal levelOrder = new LevelOrderTraversal();
            // levelOrder.ExecuteLevelOrderTraversal();
            
            ReverseLevelOrderTraversal revLevelOrder = new ReverseLevelOrderTraversal();
            revLevelOrder.ExecuteReverseLevelOrderTraversal();
            
            Console.ReadLine();
        }
    }
}
