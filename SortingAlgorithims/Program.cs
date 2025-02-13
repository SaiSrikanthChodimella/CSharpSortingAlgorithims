using BenchmarkDotNet.Running;

namespace SortingAlgorithims
{
    public class Program
    {
        static void Main(string[] args) => BenchmarkRunner.Run<BenchMarkAlgorithims>();
    }
}
