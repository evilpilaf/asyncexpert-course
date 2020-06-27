``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.329 (2004/?/20H1)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.5.20279.10
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT


```
|                   Method |           Job |       Runtime |  n |               Mean |           Error |          StdDev | Ratio | RatioSD | Code Size |
|------------------------- |-------------- |-------------- |--- |-------------------:|----------------:|----------------:|------:|--------:|----------:|
|                **Recursive** | **.NET Core 3.1** | **.NET Core 3.1** |  **1** |          **0.5577 ns** |       **0.0265 ns** |       **0.0235 ns** |  **1.00** |    **0.00** |      **76 B** |
| RecursiveWithMemoization | .NET Core 3.1 | .NET Core 3.1 |  1 |          1.2627 ns |       0.0560 ns |       0.0996 ns |  2.30 |    0.25 |     160 B |
|                Iterative | .NET Core 3.1 | .NET Core 3.1 |  1 |          0.4841 ns |       0.0191 ns |       0.0178 ns |  0.87 |    0.05 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                Recursive | .NET Core 5.0 | .NET Core 5.0 |  1 |          0.5411 ns |       0.0436 ns |       0.0551 ns |  1.00 |    0.00 |      76 B |
| RecursiveWithMemoization | .NET Core 5.0 | .NET Core 5.0 |  1 |          1.2359 ns |       0.0544 ns |       0.0582 ns |  2.30 |    0.26 |     160 B |
|                Iterative | .NET Core 5.0 | .NET Core 5.0 |  1 |          0.5241 ns |       0.0217 ns |       0.0192 ns |  0.96 |    0.10 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                **Recursive** | **.NET Core 3.1** | **.NET Core 3.1** | **15** |      **2,580.6428 ns** |      **42.6245 ns** |      **39.8710 ns** | **1.000** |    **0.00** |      **76 B** |
| RecursiveWithMemoization | .NET Core 3.1 | .NET Core 3.1 | 15 |          1.2009 ns |       0.0554 ns |       0.0701 ns | 0.000 |    0.00 |     160 B |
|                Iterative | .NET Core 3.1 | .NET Core 3.1 | 15 |          4.6032 ns |       0.0505 ns |       0.0473 ns | 0.002 |    0.00 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                Recursive | .NET Core 5.0 | .NET Core 5.0 | 15 |      2,301.6808 ns |      24.2897 ns |      20.2830 ns | 1.000 |    0.00 |      76 B |
| RecursiveWithMemoization | .NET Core 5.0 | .NET Core 5.0 | 15 |          1.1881 ns |       0.0492 ns |       0.0483 ns | 0.001 |    0.00 |     160 B |
|                Iterative | .NET Core 5.0 | .NET Core 5.0 | 15 |          4.4033 ns |       0.0398 ns |       0.0372 ns | 0.002 |    0.00 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                **Recursive** | **.NET Core 3.1** | **.NET Core 3.1** |  **3** |          **5.4537 ns** |       **0.0643 ns** |       **0.0601 ns** |  **1.00** |    **0.00** |      **76 B** |
| RecursiveWithMemoization | .NET Core 3.1 | .NET Core 3.1 |  3 |          1.1544 ns |       0.0547 ns |       0.0585 ns |  0.21 |    0.01 |     160 B |
|                Iterative | .NET Core 3.1 | .NET Core 3.1 |  3 |          0.7766 ns |       0.0167 ns |       0.0156 ns |  0.14 |    0.00 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                Recursive | .NET Core 5.0 | .NET Core 5.0 |  3 |          5.0081 ns |       0.0455 ns |       0.0426 ns |  1.00 |    0.00 |      76 B |
| RecursiveWithMemoization | .NET Core 5.0 | .NET Core 5.0 |  3 |          1.8882 ns |       0.0474 ns |       0.0420 ns |  0.38 |    0.01 |     160 B |
|                Iterative | .NET Core 5.0 | .NET Core 5.0 |  3 |          0.7717 ns |       0.0398 ns |       0.0372 ns |  0.15 |    0.01 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                **Recursive** | **.NET Core 3.1** | **.NET Core 3.1** | **35** | **38,684,054.3956 ns** | **328,124.3067 ns** | **290,873.6512 ns** | **1.000** |    **0.00** |      **76 B** |
| RecursiveWithMemoization | .NET Core 3.1 | .NET Core 3.1 | 35 |          1.1476 ns |       0.0518 ns |       0.0485 ns | 0.000 |    0.00 |     160 B |
|                Iterative | .NET Core 3.1 | .NET Core 3.1 | 35 |         11.7099 ns |       0.1050 ns |       0.0820 ns | 0.000 |    0.00 |      70 B |
|                          |               |               |    |                    |                 |                 |       |         |           |
|                Recursive | .NET Core 5.0 | .NET Core 5.0 | 35 | 33,945,511.9048 ns | 451,977.5884 ns | 400,666.3595 ns | 1.000 |    0.00 |      76 B |
| RecursiveWithMemoization | .NET Core 5.0 | .NET Core 5.0 | 35 |          1.1847 ns |       0.0482 ns |       0.0473 ns | 0.000 |    0.00 |     160 B |
|                Iterative | .NET Core 5.0 | .NET Core 5.0 | 35 |         11.1904 ns |       0.0844 ns |       0.0705 ns | 0.000 |    0.00 |      70 B |
