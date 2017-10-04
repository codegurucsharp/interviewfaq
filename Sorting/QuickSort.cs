using System;
using System.Collections.Generic;

namespace Sorting
{
     public class Quicksort
    {

        public void Qsort(int[] A, int start, int end)
        {
            if (start < end)
            {
                int q = partition(A, start, end);
                Qsort(A, start, q - 1);
                Qsort(A, q + 1, end);
            }
        }

        public void QsortIterativeStack(int[] A, int start, int end)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(start);
            stack.Push(end);
            while (stack.Count > 0)
            {
                end = stack.Pop();
                start = stack.Pop();
                int q = partition(A, start, end);

                if (q - 1 > start)
                {
                    stack.Push(start);
                    stack.Push(q - 1);
                }

                if (q + 1 < end)
                {
                    stack.Push(q + 1);
                    stack.Push(end);
                }
            }
        }

        public void QsortIterativeAuxArray(int[] A, int start, int end)
        {
            int top = -1;
            int[] infoStack = new int[end - start + 1];

            infoStack[++top] = start;
            infoStack[++top] = end;
            //stack.Push(start);
            //stack.Push(end);

            while (top > 0)
            {
                end = infoStack[top--];
                start = infoStack[top--];
                int q = partition(A, start, end);

                if (q - 1 > start)
                {
                    infoStack[++top] = start;
                    infoStack[++top] = q - 1;
                }

                if (q + 1 < end)
                {
                    infoStack[++top] = q + 1;
                    infoStack[++top] = end;
                }
            }
        }
        int partition(int[] A, int start, int end)
        {
            int lastElem = A[end];
            int leftPtr = start - 1;

            for (int j = start; j < end; j++)
            {
                if (A[j] < lastElem)
                {
                    Swap(ref A[j], ref A[++leftPtr]);
                }
            }

            Swap(ref A[leftPtr + 1], ref A[end]);
            return leftPtr + 1;
        }

        private static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}