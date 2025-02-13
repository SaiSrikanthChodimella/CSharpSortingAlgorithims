namespace SortingAlgorithims
{
    public static class SelectionSort
    {
        public static int[] SortArraySelectionSort(int[] unsortedArray)
        {
            for (int i = 0; i < unsortedArray.Length - 1; i++)
            {
                var minIndex = i;
                for (int j = i + 1; j < unsortedArray.Length; j++)
                {
                    if (unsortedArray[j] < unsortedArray[minIndex])
                    {
                        minIndex = j;
                    }
                }
                var temp = unsortedArray[minIndex];
                unsortedArray[minIndex] = unsortedArray[i];
                unsortedArray[i] = temp;
            }

            return unsortedArray;
        }
    }
}
