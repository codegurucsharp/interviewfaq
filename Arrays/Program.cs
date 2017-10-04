using System;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MissingNumberImpl impl = new MissingNumberImpl();

            int[] A = new []{1, 2, 4, 6, 3, 7, 8, 0};
            Console.WriteLine("The missing number is summation: {0}",impl.GetMissingNumber(A));
            Console.WriteLine("The missing number is adding and substracting simultaneously: {0}",impl.GetMissingNumberavoidIntOverflow(A));
            Console.WriteLine("The missing number is XOR: {0}",impl.GetMissingNumberUsingXOR(A));
            Console.ReadLine();
        }
    }
}
