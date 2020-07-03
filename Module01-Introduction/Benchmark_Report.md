``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.5.20279.10
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT


```
|                   Method |           Job |       Runtime |  n |               Mean |           Error |          StdDev | Ratio | RatioSD | Code Size |
|------------------------- |-------------- |-------------- |--- |-------------------:|----------------:|----------------:|------:|--------:|----------:|
|                **Recursive** | **.NET Core 3.1** | **.NET Core 3.1** |  **1** |          **0.2948 ns** |       **0.0379 ns** |       **0.0531 ns** |  **1.00** |    **0.00** |      **76 B** |
| RecursiveWithMemoization | .NET Core 3.1 | .NET Core 3.1 |  1 |          8.9911 ns |       0.1986 ns |       0.2364 ns | 31.82 |    5.68 |     274 B |
|                Iterative | .NET Core 3.1 | .NET Core 3.1 |  1 |          0.4691 ns |       0.0081 ns |       0.0068 ns |  1.69 |    0.31 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                Recursive | .NET Core 5.0 | .NET Core 5.0 |  1 |          0.5334 ns |       0.0440 ns |       0.0672 ns |  1.00 |    0.00 |      76 B |
| RecursiveWithMemoization | .NET Core 5.0 | .NET Core 5.0 |  1 |          8.8591 ns |       0.2079 ns |       0.2776 ns | 17.02 |    2.07 |     264 B |
|                Iterative | .NET Core 5.0 | .NET Core 5.0 |  1 |          0.8141 ns |       0.0171 ns |       0.0160 ns |  1.54 |    0.22 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                **Recursive** | **.NET Core 3.1** | **.NET Core 3.1** | **15** |      **2,557.1638 ns** |      **25.9609 ns** |      **23.0137 ns** | **1.000** |    **0.00** |      **76 B** |
| RecursiveWithMemoization | .NET Core 3.1 | .NET Core 3.1 | 15 |        113.3445 ns |       2.2904 ns |       3.4977 ns | 0.044 |    0.00 |     274 B |
|                Iterative | .NET Core 3.1 | .NET Core 3.1 | 15 |          4.9054 ns |       0.0287 ns |       0.0268 ns | 0.002 |    0.00 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                Recursive | .NET Core 5.0 | .NET Core 5.0 | 15 |      2,025.4248 ns |      33.4135 ns |      31.2550 ns | 1.000 |    0.00 |      76 B |
| RecursiveWithMemoization | .NET Core 5.0 | .NET Core 5.0 | 15 |        110.8097 ns |       1.9084 ns |       1.6918 ns | 0.055 |    0.00 |     264 B |
|                Iterative | .NET Core 5.0 | .NET Core 5.0 | 15 |          7.7546 ns |       0.1671 ns |       0.1395 ns | 0.004 |    0.00 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                **Recursive** | **.NET Core 3.1** | **.NET Core 3.1** |  **3** |          **5.3044 ns** |       **0.0357 ns** |       **0.0298 ns** |  **1.00** |    **0.00** |      **76 B** |
| RecursiveWithMemoization | .NET Core 3.1 | .NET Core 3.1 |  3 |         23.5613 ns |       0.4996 ns |       1.1277 ns |  4.25 |    0.10 |     274 B |
|                Iterative | .NET Core 3.1 | .NET Core 3.1 |  3 |          0.8158 ns |       0.0150 ns |       0.0133 ns |  0.15 |    0.00 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                Recursive | .NET Core 5.0 | .NET Core 5.0 |  3 |          4.4473 ns |       0.1165 ns |       0.1341 ns |  1.00 |    0.00 |      76 B |
| RecursiveWithMemoization | .NET Core 5.0 | .NET Core 5.0 |  3 |         22.9634 ns |       0.4463 ns |       0.8048 ns |  5.16 |    0.27 |     264 B |
|                Iterative | .NET Core 5.0 | .NET Core 5.0 |  3 |          0.8268 ns |       0.0103 ns |       0.0096 ns |  0.18 |    0.01 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                **Recursive** | **.NET Core 3.1** | **.NET Core 3.1** | **35** | **38,278,879.0816 ns** | **321,284.1644 ns** | **284,810.0432 ns** | **1.000** |    **0.00** |      **76 B** |
| RecursiveWithMemoization | .NET Core 3.1 | .NET Core 3.1 | 35 |        261.1725 ns |       3.9956 ns |       3.3365 ns | 0.000 |    0.00 |     274 B |
|                Iterative | .NET Core 3.1 | .NET Core 3.1 | 35 |         13.6680 ns |       0.0871 ns |       0.0772 ns | 0.000 |    0.00 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                Recursive | .NET Core 5.0 | .NET Core 5.0 | 35 | 38,508,584.0659 ns | 175,720.4573 ns | 146,734.5402 ns | 1.000 |    0.00 |      76 B |
| RecursiveWithMemoization | .NET Core 5.0 | .NET Core 5.0 | 35 |        261.9942 ns |       3.5312 ns |       3.1303 ns | 0.000 |    0.00 |     264 B |
|                Iterative | .NET Core 5.0 | .NET Core 5.0 | 35 |         18.3862 ns |       0.0681 ns |       0.0637 ns | 0.000 |    0.00 |      70 B |
