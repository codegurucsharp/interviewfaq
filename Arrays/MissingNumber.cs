using System;
namespace Arrays
{
    public class MissingNumberImpl
    {
        public int GetMissingNumber(int[] A)    
        {
            int maxLength = A.Length;
            int sum = maxLength * (maxLength+1)/2;

            for (int i = 0; i < maxLength; i++)
            {
                sum = sum-A[i];
            }

            return sum;
        }

        public int GetMissingNumberavoidIntOverflow(int[] A)    
        {
            int maxLength = A.Length;
            int sum = 0;
            for (int i = 0; i < maxLength; i++)
            {
                sum += (i+1)-A[i];
            }

            return sum;
        }

        public int GetMissingNumberUsingXOR(int[] A)    
        {
            int maxLength = A.Length;
            int xorArry = A[0];
            int xorInts = 1;

            for (int i = 1; i < maxLength; i++)
            {
                xorArry = xorArry ^ A[i];
            }

            for (int i = 2; i <= maxLength; i++)
            {
                xorInts = xorInts ^ i;
            }

            return xorArry ^ xorInts;
        }
    }
}