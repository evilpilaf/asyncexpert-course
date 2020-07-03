using System.Collections.Generic;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Jobs;

namespace Dotnetos.AsyncExpert.Homework.Module01.Benchmark
{
    [DisassemblyDiagnoser(exportCombinedDisassemblyReport: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(RuntimeMoniker.NetCoreApp50)]
    public class FibonacciCalc
    {
        // HOMEWORK:
        // 1. Write implementations for RecursiveWithMemoization and Iterative solutions
        // 2. Add MemoryDiagnoser to the benchmark
        // 3. Run with release configuration and compare results
        // 4. Open disassembler report and compare machine code
        //
        // You can use the discussion panel to compare your results with other students

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(Data))]
        public ulong Recursive(ulong n)
        {
            if (n == 1 || n == 2) return 1;
            return Recursive(n - 2) + Recursive(n - 1);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong RecursiveWithMemoization(ulong n)
        {
            var fibValues = new ulong?[n * 2];
            fibValues[0] = 0;
            fibValues[1] = 1;
            return RecursiveWithMemorization(n, fibValues);
        }

        private ulong RecursiveWithMemorization(ulong n, ulong?[] memory)
        {
            var val = memory[n];
            if (!val.HasValue)
            {
                val = RecursiveWithMemorization(n - 1, memory) + RecursiveWithMemorization(n - 2, memory);
                memory[n] = val;
            }
            return val.Value;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong Iterative(ulong n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;

            ulong a = 0;
            ulong b = 1;
            ulong c = 0;

            for (ulong i = 2; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }

        public IEnumerable<ulong> Data()
        {
            yield return 1;
            yield return 3;
            yield return 15;
            yield return 35;
        }
    }
}
