namespace SortingAlgorithims
{
    public static class InsertionSort
    {
        public static int[] SortArrayInsertionSort(int[] unsortedArray)
        {
            for (int i = 1; i < unsortedArray.Length; i++)
            {
                var key = unsortedArray[i];
                var j = i - 1;

                while (j >= 0 && unsortedArray[j] > key)
                {
                    unsortedArray[j + 1] = unsortedArray[j];
                    j--;
                }

                unsortedArray[j + 1] = key;
            }


            return unsortedArray;
        }
    }
}
