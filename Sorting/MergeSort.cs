using System;

namespace Sorting
{
    public class MergeSortImpl
    {
       public void MergeSort(int[] A, int p, int q)
       {
            if (p < q)
            {
                int mid = (p + q) / 2;

                MergeSort(A, p, mid);
                MergeSort(A, mid + 1, q);
                Merge(A, p, mid, q);
            }
        }

        public void MergeSort2(int[] A, int p, int q)
        {
            if (p < q)
            {
                int mid = (p + q) / 2;

                MergeSort(A, p, mid);
                MergeSort(A, mid + 1, q);
                Merge2(A, p, mid, q);
            }
        }

        private void Merge2(int[] A, int p, int mid, int q)
        {
            // This method is where we use the lenth to restrict till when to complare, needs to seperate whiles in the end to copy the left over arrays as is.
            int n = mid - p + 1;
            int m = q - mid;

            int[] lsorted = new int[n];
            int[] rsorted = new int[m];


            for (int l = 0; l < n; l++)
            {
                lsorted[l] = A[p + l];
            }

            for (int l = 0; l < m; l++)
            {
                rsorted[l] = A[mid + l + 1];
            }

            int i = 0, j = 0, k = p;

            while (i < n && j < m)
            {
                if (lsorted[i] < rsorted[j])
                {
                    A[k++] = lsorted[i++];
                }
                else
                {
                    A[k++] = rsorted[j++];
                }
            }

            while (i < n)
            {
                A[k++] = lsorted[i++];
            }

            while (j < m)
            {
                A[k++] = rsorted[j++];
            }
        }

        public void Merge(int[] A, int p, int mid, int q)
        {            
            // This method is like Coreman method making the last element as Max value and copying left & right to seperate arrays
            int n = mid - p + 1;
            int m = q - mid;

            int[] lsorted = new int[n + 1];
            int[] rsorted = new int[m + 1];

            lsorted[n] = int.MaxValue;
            rsorted[m] = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                lsorted[i] = A[p + i];
            }

            for (int i = 0; i < m; i++)
            {
                rsorted[i] = A[mid + i + 1];
            }

            int i1 = 0, j1 = 0, k = p;

            while (k <= q)
            {
                if (lsorted[i1] < rsorted[j1])
                {
                    A[k++] = lsorted[i1++];
                }
                else
                {
                    A[k++] = rsorted[j1++];
                }
            }
        }
    }
}