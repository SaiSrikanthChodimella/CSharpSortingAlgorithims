namespace SortingAlgorithims
{
    public static class BubbleSort
    {
        public static int[] SortArrayBubbleSort(int[] unSortedArray)
        {
            for (int i = 0; i < unSortedArray.Length - 1; i++)
            {
                for (int j = 0; j < unSortedArray.Length - 1; j++)
                {
                    if (unSortedArray[j] > unSortedArray[j + 1])
                    {
                        var temp = unSortedArray[j + 1];
                        unSortedArray[j + 1] = unSortedArray[j];
                        unSortedArray[j] = temp;
                    }
                }
            }

            return unSortedArray;
        }
    }
}
