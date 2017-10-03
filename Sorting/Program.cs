using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] A = new[] { 9, 5, 6, 4, 8, 2, 7, 1 };
            // using Method 1
            MergeSortImpl impl = new MergeSortImpl();
            impl.MergeSort(A,0, A.Length-1);
            Utilities.printArray(A,0,A.Length-1);

            Console.WriteLine("This is the second method of sorting using MergeSort.");

            int[] B = new[] { -9, 5, -6, 4, -8, 2, -7, 1 };
            // using Method 2            
            impl.MergeSort2(B,0, B.Length-1);
            Utilities.printArray(B,0,B.Length-1);

            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
