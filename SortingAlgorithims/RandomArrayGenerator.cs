namespace SortingAlgorithims
{
    class RandomArrayGenerator
    {
        public int[] GenerateArrayOfRandomNumbers(int size)
        {
            var randomNumbersArray = new int[size];
            var random = new Random();

            for (var i=0; i<size; i++)
            {
                randomNumbersArray[i] = random.Next(0, size);
            }
            return randomNumbersArray;
        }
    }
}
