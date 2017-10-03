using System;
namespace Sorting
{
    public static class Utilities
    {    
        public static void printArray(int[] arr, int i, int j)
        {
            Console.Write("[");

            for (int k = i; k < j; k++)
            {
                Console.Write(arr[k] + ", ");
            }

            Console.WriteLine(arr[j] + "]");
        }
    }
}