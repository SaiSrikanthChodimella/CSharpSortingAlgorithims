using BenchmarkDotNet.Running;
using SortingAlgorithms;


namespace SortingAlgorithims
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var randomNumbersArray = new RandomArrayGenerator();
            //var _unSortedArray = randomNumbersArray.GenerateArrayOfRandomNumbers(500_000);

            //var sortedArray = ParallelMergeSort.SortArrayParallelMergeSort(_unSortedArray);


            BenchmarkRunner.Run<BenchMarkAlgorithims>();
        }
    }
}
