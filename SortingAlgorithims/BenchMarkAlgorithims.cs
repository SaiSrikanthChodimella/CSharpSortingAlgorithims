using BenchmarkDotNet.Attributes;
using SortingAlgorithms;

namespace SortingAlgorithims
{
    public class BenchMarkAlgorithims
    {
        private int[] _unSortedArray;

        [Params(10000, 50000, 100_000)]
        public int arraysize;

        [GlobalSetup]
        public void Setup()
        {
            var randomNumbersArray = new RandomArrayGenerator();
            _unSortedArray = randomNumbersArray.GenerateArrayOfRandomNumbers(arraysize);
        }

        [Benchmark]
        public int[] BubbleSortBenchMark()
        {
            var unSortedArray = _unSortedArray.ToArray();
            return BubbleSort.SortArrayBubbleSort(unSortedArray);
        }

        [Benchmark]
        public int[] SelectionSortBenchMark()
        {
            var unSortedArray = _unSortedArray.ToArray();
            return SelectionSort.SortArraySelectionSort(unSortedArray);
        }

        [Benchmark]
        public int[] QuickSortBenchMark()
        {
            var unSortedArray = _unSortedArray.ToArray();
            return QuickSort.SortArrayQuickSort(unSortedArray);
        }

        [Benchmark]
        public int[] InsertionSortBenchMark()
        {
            var unSortedArray = _unSortedArray.ToArray();
            return InsertionSort.SortArrayInsertionSort(_unSortedArray);
        }

        [Benchmark]
        public int[] MergeSortBenchMark()
        {
            var unSortedArray = _unSortedArray.ToArray();
            return MergeSort.SortArrayMergeSort(_unSortedArray);
        }

        [Benchmark]
        public int[] ParallelMergeSortBenchMark()
        {
            var unSortedArray = _unSortedArray.ToArray();
            return ParallelMergeSort.SortArrayParallelMergeSort(_unSortedArray);
        }
    }
}
