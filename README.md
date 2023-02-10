```
BenchmarkDotNet=v0.13.4, OS=Windows 11 (10.0.22000.1455/21H2)
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.102
[Host]   : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
.NET 7.0 : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2

Job=.NET 7.0  Runtime=.NET 7.0

|   Method |  Items |           Mean |         Error |        StdDev |
|--------- |------- |---------------:|--------------:|--------------:|
|     Linq |     10 |      67.694 ns |     1.3010 ns |     1.0864 ns |
|  ForEach |     10 |       2.844 ns |     0.0477 ns |     0.0398 ns |
| ForIndex |     10 |       5.675 ns |     0.0620 ns |     0.0518 ns |
|     Linq |    100 |     509.053 ns |     9.4843 ns |     9.7396 ns |
|  ForEach |    100 |      38.396 ns |     0.6701 ns |     0.5940 ns |
| ForIndex |    100 |      56.806 ns |     1.0952 ns |     1.0757 ns |
|     Linq |   1000 |   5,281.463 ns |   103.7809 ns |    91.9991 ns |
|  ForEach |   1000 |     337.726 ns |     6.7105 ns |     7.7278 ns |
| ForIndex |   1000 |     518.621 ns |    10.4050 ns |    10.6852 ns |
|     Linq |  10000 |  49,105.021 ns |   836.6289 ns |   782.5832 ns |
|  ForEach |  10000 |   3,283.438 ns |    36.0030 ns |    33.6772 ns |
| ForIndex |  10000 |   5,059.002 ns |    52.3648 ns |    48.9821 ns |
|     Linq | 100000 | 488,473.400 ns | 5,804.2737 ns | 5,429.3212 ns |
|  ForEach | 100000 |  32,778.777 ns |   422.1191 ns |   374.1976 ns |
| ForIndex | 100000 |  50,741.357 ns |   726.2059 ns |   606.4148 ns |
```