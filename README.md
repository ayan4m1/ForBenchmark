```
BenchmarkDotNet=v0.13.4, OS=Windows 11 (10.0.22000.1455/21H2)
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.102
  [Host]   : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2

Job=.NET 7.0  Runtime=.NET 7.0  

|   Method |  Items |           Mean |          Error |         StdDev |
|--------- |------- |---------------:|---------------:|---------------:|
|     Linq |     10 |      70.669 ns |      1.4172 ns |      2.2479 ns |
|  ForEach |     10 |       3.077 ns |      0.0934 ns |      0.1310 ns |
| ForIndex |     10 |       3.023 ns |      0.0906 ns |      0.1113 ns |
|     Linq |    100 |     543.216 ns |     10.8841 ns |     20.9700 ns |
|  ForEach |    100 |      40.535 ns |      0.8390 ns |      0.9988 ns |
| ForIndex |    100 |      40.272 ns |      0.6458 ns |      0.6041 ns |
|     Linq |   1000 |   5,531.571 ns |    107.9064 ns |    171.1511 ns |
|  ForEach |   1000 |     348.876 ns |      6.9875 ns |      6.5361 ns |
| ForIndex |   1000 |     344.546 ns |      6.9113 ns |      7.3951 ns |
|     Linq |  10000 |  51,496.763 ns |  1,023.1228 ns |  1,791.9171 ns |
|  ForEach |  10000 |   3,405.757 ns |     67.8085 ns |     90.5224 ns |
| ForIndex |  10000 |   3,359.972 ns |     38.7173 ns |     34.3219 ns |
|     Linq | 100000 | 522,652.730 ns | 10,344.8754 ns | 18,916.1896 ns |
|  ForEach | 100000 |  34,125.226 ns |    660.7287 ns |    678.5197 ns |
| ForIndex | 100000 |  33,853.445 ns |    518.2012 ns |    484.7257 ns |
```