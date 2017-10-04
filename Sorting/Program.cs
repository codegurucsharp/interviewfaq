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

            Quicksort qsort = new Quicksort();

            int[] Q1 = new int[] { 4, 8, 16, 5, 14, 2, 31 };
            qsort.Qsort(Q1,0,Q1.Length-1);
            Console.WriteLine("Recursive QSort");

            Utilities.printArray(Q1,0,Q1.Length-1);

            int[] Q2 = new int[] { 4, 8, -16, 5, 14, -2, 31 };
            qsort.QsortIterativeAuxArray(Q2,0,Q2.Length-1);
            Console.WriteLine("Iterative QSort using aux array like stack");
            Utilities.printArray(Q2,0,Q2.Length-1);

            int[] Q3 = new int[] { 4, -8, 16, -5, 14, 2, 31 };
            qsort.QsortIterativeStack(Q3,0,Q3.Length-1);
            Console.WriteLine("Iterative QSort using stack");
            Utilities.printArray(Q3,0,Q3.Length-1);

            Console.ReadLine();
        }
    }
}
