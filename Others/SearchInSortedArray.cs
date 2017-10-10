using System;

namespace Others
{
    public class SearchInSortedArray
    {
        public void ExecuteSearchInSortedArray()
        {
            int[] arr = new int[] { 5, 6, 7, 8, 9, 0, 1, 2, 3, 4,10 };

            // Assumes ascending order sorted array
            int ret = SearchArray(arr,0,arr.Length-1, 9);
            System.Console.WriteLine(ret);
        }

        public int SearchArray(int[] arr, int low, int high, int findthis)
        {
            if(low>high) return-1;
            int mid = (low + high) / 2;
            if (arr[mid] == findthis) return mid;

            // left maybe a sorted array
            if (arr[low] < arr[mid])
            {
                // as left is sorted, you can check if the number lies in it or not, if does, search
                if (findthis >= arr[low] && findthis <= arr[mid])
                    return SearchArray(arr, low, mid - 1, findthis);

                //otherwise search on the right side.
                return SearchArray(arr,mid+1,high,findthis);
            }
            else
            {
                //right is a sorted array, as left was not
                //if number lies in the right
                if (arr[mid] < arr[high] && findthis >= arr[mid] && findthis <= arr[high])
                    return SearchArray(arr, mid + 1, high, findthis);
                else
                    return SearchArray(arr, low, mid - 1, findthis);
            }
        }
    }
}