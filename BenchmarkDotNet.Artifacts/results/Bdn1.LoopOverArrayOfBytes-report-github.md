``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.737 (1809/October2018Update/Redstone5)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-ZDRRPD : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EnvironmentVariables=COMPLUS_TieredCompilation=1  Runtime=.NET Core 3.0  

```
|             Method |  N |      Mean |    Error |   StdDev | Ratio | RatioSD |
|------------------- |--- |----------:|---------:|---------:|------:|--------:|
|            Foreach | 50 |  23.91 ns | 0.086 ns | 0.080 ns |  1.00 |    0.00 |
|          ForSimple | 50 |  25.48 ns | 0.192 ns | 0.170 ns |  1.07 |    0.01 |
|     ForLocalCached | 50 |  23.84 ns | 0.053 ns | 0.050 ns |  1.00 |    0.00 |
|  ListForeachSimple | 50 | 224.69 ns | 0.485 ns | 0.429 ns |  9.40 |    0.04 |
|      ListForSimple | 50 |  45.73 ns | 0.149 ns | 0.132 ns |  1.91 |    0.01 |
|     ListForToArray | 50 |  39.46 ns | 0.394 ns | 0.369 ns |  1.65 |    0.01 |
| ListForLocalCached | 50 |  24.20 ns | 0.178 ns | 0.149 ns |  1.01 |    0.01 |
