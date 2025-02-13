namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static int[] SortArrayMergeSort(int[] unsortedArray)
        {
            if (unsortedArray is null || unsortedArray.Length <= 1)
            {
                return unsortedArray;
            }

            int[] tempArray = new int[unsortedArray.Length];
            MergeSortRecursion(unsortedArray, tempArray, 0, unsortedArray.Length - 1);
            return unsortedArray;
        }

        private static void MergeSortRecursion(int[] array, int[] tempArray, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                // Recursively sort the two halves
                MergeSortRecursion(array, tempArray, left, middle);
                MergeSortRecursion(array, tempArray, middle + 1, right);
                // Merge the sorted halves
                Merge(array, tempArray, left, middle, right);
            }
        }

        private static void Merge(int[] array, int[] tempArray, int left, int middle, int right)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;

            // Copy data to temp arrays
            Array.Copy(array, left, tempArray, left, leftSize);
            Array.Copy(array, middle + 1, tempArray, middle + 1, rightSize);

            int i = left;
            int j = middle + 1;
            int k = left;

            // Merge the temp arrays back into the main array
            while (i <= middle && j <= right)
            {
                array[k++] = tempArray[i] <= tempArray[j] ? tempArray[i++] : tempArray[j++];
            }

            // Copy remaining elements from the left half
            while (i <= middle)
            {
                array[k++] = tempArray[i++];
            }

            // Copy remaining elements from the right half
            while (j <= right)
            {
                array[k++] = tempArray[j++];
            }
        }
    }
}