# Sorting Algorithms Benchmarking Project

This project benchmarks the performance of various sorting algorithms using **BenchmarkDotNet**. The algorithms included are:

- Bubble Sort
- Selection Sort
- Quick Sort
- Insertion Sort
- Merge Sort
- Parallel Merge Sort

The benchmarks are run on arrays of different sizes (`10,000`, `50,000`, and `100,000` elements) to compare the performance of each algorithm.

---

## Table of Contents
1. [Project Overview](#project-overview)
2. [Algorithms Included](#algorithms-included)
3. [Setup](#setup)
4. [Running the Benchmarks](#running-the-benchmarks)
5. [Results](#results)
6. [Contributing](#contributing)
7. [License](#license)

---

## Project Overview

This project is designed to compare the performance of different sorting algorithms using **BenchmarkDotNet**, a powerful .NET library for benchmarking. The goal is to understand how each algorithm performs under different input sizes and to identify the most efficient sorting method for large datasets.

---

## Algorithms Included

The following sorting algorithms are benchmarked:

1. **Bubble Sort**: A simple comparison-based algorithm with O(n²) time complexity.
2. **Selection Sort**: Another O(n²) algorithm that selects the smallest element and swaps it into place.
3. **Quick Sort**: A divide-and-conquer algorithm with O(n log n) average time complexity.
4. **Insertion Sort**: An O(n²) algorithm that builds the sorted array one element at a time.
5. **Merge Sort**: A divide-and-conquer algorithm with O(n log n) time complexity.
6. **Parallel Merge Sort**: A parallelized version of Merge Sort for improved performance on multi-core processors.

---

## Setup

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [BenchmarkDotNet](https://benchmarkdotnet.org/) (included in the project)

### Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/sorting-algorithms-benchmark.git
   ```
2. Navigate to the project directory:
   ```bash
   cd sorting-algorithms-benchmark
   ```
3. Restore the dependencies:
   ```bash
   dotnet restore
   ```

---

## Running the Benchmarks

To run the benchmarks, follow these steps:

1. Build the project in Release mode:
   ```bash
   dotnet build -c Release
   ```
2. Run the benchmarks:
   ```bash
   dotnet run -c Release
   ```

This will execute the benchmarks and display the results in the console. BenchmarkDotNet will automatically warm up the algorithms, run them multiple times, and provide detailed statistics.

---

## Results

The benchmarks will output detailed performance metrics, including:

- **Mean time**: The average time taken to sort the array.
- **Standard deviation**: The variation in execution times.

### Example Output

| Method                     | arraysize | Mean      | Error     | StdDev    |
|--------------------------- |---------- |----------:|----------:|----------:|
| ParallelMergeSortBenchMark | 10000     |  4.119 ms | 0.2061 ms | 0.5979 ms |
| ParallelMergeSortBenchMark | 50000     | 26.844 ms | 0.5339 ms | 1.2159 ms |
| ParallelMergeSortBenchMark | 100000    | 54.910 ms | 1.2842 ms | 3.5371 ms |

#### Legends
- arraysize : Value of the 'arraysize' parameter
- Mean      : Arithmetic mean of all measurements
- Error     : Half of 99.9% confidence interval
- StdDev    : Standard deviation of all measurements
- 1 ms      : 1 Millisecond (0.001 sec)

---

## Contributing

Contributions are welcome! If you'd like to add more sorting algorithms or improve the benchmarking process, follow these steps:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add your feature"
   ```
4. Push to the branch:
   ```bash
   git push origin feature/your-feature-name
   ```
5. Open a pull request.

---

## License

This project is licensed under the MIT License. See the LICENSE.md file for details.

