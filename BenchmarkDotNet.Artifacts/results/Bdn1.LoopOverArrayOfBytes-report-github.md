``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.805 (1809/October2018Update/Redstone5)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-QNGUEG : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-NJRSAS : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

Runtime=.NET Core 3.0  

```
|                 Method |        EnvironmentVariables |    N |          Mean |       Error |      StdDev | Ratio | RatioSD |
|----------------------- |---------------------------- |----- |--------------:|------------:|------------:|------:|--------:|
|                **Foreach** | **COMPLUS_TieredCompilation=0** |   **16** |      **7.579 ns** |   **0.1612 ns** |   **0.1508 ns** |  **1.00** |    **0.00** |
|              ForSimple | COMPLUS_TieredCompilation=0 |   16 |      7.800 ns |   0.0343 ns |   0.0321 ns |  1.03 |    0.02 |
|         ForLocalCached | COMPLUS_TieredCompilation=0 |   16 |      7.560 ns |   0.0306 ns |   0.0286 ns |  1.00 |    0.02 |
| ForLocalCachedUnrolled | COMPLUS_TieredCompilation=0 |   16 |      6.274 ns |   0.0368 ns |   0.0344 ns |  0.83 |    0.02 |
|      ListForeachSimple | COMPLUS_TieredCompilation=0 |   16 |     72.314 ns |   0.2799 ns |   0.2481 ns |  9.57 |    0.17 |
|          ListForSimple | COMPLUS_TieredCompilation=0 |   16 |     14.473 ns |   0.0601 ns |   0.0562 ns |  1.91 |    0.04 |
|         ListForToArray | COMPLUS_TieredCompilation=0 |   16 |     19.912 ns |   0.0723 ns |   0.0676 ns |  2.63 |    0.05 |
|     ListForLocalCached | COMPLUS_TieredCompilation=0 |   16 |      9.468 ns |   0.0566 ns |   0.0530 ns |  1.25 |    0.02 |
|                        |                             |      |               |             |             |       |         |
|                Foreach | COMPLUS_TieredCompilation=1 |   16 |      7.512 ns |   0.0566 ns |   0.0530 ns |  1.00 |    0.00 |
|              ForSimple | COMPLUS_TieredCompilation=1 |   16 |      7.643 ns |   0.0403 ns |   0.0377 ns |  1.02 |    0.01 |
|         ForLocalCached | COMPLUS_TieredCompilation=1 |   16 |      4.227 ns |   0.0212 ns |   0.0188 ns |  0.56 |    0.00 |
| ForLocalCachedUnrolled | COMPLUS_TieredCompilation=1 |   16 |      6.513 ns |   0.0259 ns |   0.0230 ns |  0.87 |    0.01 |
|      ListForeachSimple | COMPLUS_TieredCompilation=1 |   16 |     72.721 ns |   0.3354 ns |   0.3137 ns |  9.68 |    0.07 |
|          ListForSimple | COMPLUS_TieredCompilation=1 |   16 |     14.386 ns |   0.0644 ns |   0.0537 ns |  1.91 |    0.01 |
|         ListForToArray | COMPLUS_TieredCompilation=1 |   16 |     19.287 ns |   0.0847 ns |   0.0751 ns |  2.57 |    0.02 |
|     ListForLocalCached | COMPLUS_TieredCompilation=1 |   16 |      8.111 ns |   0.0209 ns |   0.0185 ns |  1.08 |    0.01 |
|                        |                             |      |               |             |             |       |         |
|                **Foreach** | **COMPLUS_TieredCompilation=0** |  **256** |    **122.158 ns** |   **0.4204 ns** |   **0.3727 ns** |  **1.00** |    **0.00** |
|              ForSimple | COMPLUS_TieredCompilation=0 |  256 |    124.508 ns |   0.6432 ns |   0.6016 ns |  1.02 |    0.01 |
|         ForLocalCached | COMPLUS_TieredCompilation=0 |  256 |    122.788 ns |   0.6996 ns |   0.6544 ns |  1.00 |    0.01 |
| ForLocalCachedUnrolled | COMPLUS_TieredCompilation=0 |  256 |     97.927 ns |   0.1491 ns |   0.1395 ns |  0.80 |    0.00 |
|      ListForeachSimple | COMPLUS_TieredCompilation=0 |  256 |  1,121.949 ns |   5.7975 ns |   5.1393 ns |  9.18 |    0.03 |
|          ListForSimple | COMPLUS_TieredCompilation=0 |  256 |    226.714 ns |   0.7628 ns |   0.6762 ns |  1.86 |    0.01 |
|         ListForToArray | COMPLUS_TieredCompilation=0 |  256 |    154.885 ns |   0.3942 ns |   0.3291 ns |  1.27 |    0.00 |
|     ListForLocalCached | COMPLUS_TieredCompilation=0 |  256 |    123.849 ns |   0.5122 ns |   0.4541 ns |  1.01 |    0.01 |
|                        |                             |      |               |             |             |       |         |
|                Foreach | COMPLUS_TieredCompilation=1 |  256 |     91.102 ns |   0.3623 ns |   0.3389 ns |  1.00 |    0.00 |
|              ForSimple | COMPLUS_TieredCompilation=1 |  256 |    125.702 ns |   1.0610 ns |   0.9924 ns |  1.38 |    0.01 |
|         ForLocalCached | COMPLUS_TieredCompilation=1 |  256 |    122.754 ns |   0.5197 ns |   0.4607 ns |  1.35 |    0.01 |
| ForLocalCachedUnrolled | COMPLUS_TieredCompilation=1 |  256 |     96.667 ns |   0.3042 ns |   0.2697 ns |  1.06 |    0.00 |
|      ListForeachSimple | COMPLUS_TieredCompilation=1 |  256 |  1,124.368 ns |   2.9517 ns |   2.6166 ns | 12.34 |    0.05 |
|          ListForSimple | COMPLUS_TieredCompilation=1 |  256 |    227.208 ns |   0.8438 ns |   0.7893 ns |  2.49 |    0.02 |
|         ListForToArray | COMPLUS_TieredCompilation=1 |  256 |    123.888 ns |   0.5561 ns |   0.5202 ns |  1.36 |    0.01 |
|     ListForLocalCached | COMPLUS_TieredCompilation=1 |  256 |    124.525 ns |   0.4716 ns |   0.3938 ns |  1.37 |    0.01 |
|                        |                             |      |               |             |             |       |         |
|                **Foreach** | **COMPLUS_TieredCompilation=0** | **1024** |    **477.510 ns** |   **1.8290 ns** |   **1.6213 ns** |  **1.00** |    **0.00** |
|              ForSimple | COMPLUS_TieredCompilation=0 | 1024 |    479.546 ns |   1.0834 ns |   0.9604 ns |  1.00 |    0.00 |
|         ForLocalCached | COMPLUS_TieredCompilation=0 | 1024 |    477.028 ns |   2.1423 ns |   1.8991 ns |  1.00 |    0.01 |
| ForLocalCachedUnrolled | COMPLUS_TieredCompilation=0 | 1024 |    391.106 ns |   1.1371 ns |   0.9495 ns |  0.82 |    0.00 |
|      ListForeachSimple | COMPLUS_TieredCompilation=0 | 1024 |  4,487.288 ns |  25.5346 ns |  23.8851 ns |  9.39 |    0.05 |
|          ListForSimple | COMPLUS_TieredCompilation=0 | 1024 |    886.246 ns |   2.8670 ns |   2.6818 ns |  1.86 |    0.01 |
|         ListForToArray | COMPLUS_TieredCompilation=0 | 1024 |    540.045 ns |   1.7848 ns |   1.5822 ns |  1.13 |    0.00 |
|     ListForLocalCached | COMPLUS_TieredCompilation=0 | 1024 |    481.214 ns |   2.7856 ns |   2.6056 ns |  1.01 |    0.01 |
|                        |                             |      |               |             |             |       |         |
|                Foreach | COMPLUS_TieredCompilation=1 | 1024 |    350.668 ns |   1.5983 ns |   1.4169 ns |  1.00 |    0.00 |
|              ForSimple | COMPLUS_TieredCompilation=1 | 1024 |    481.130 ns |   1.4511 ns |   1.3574 ns |  1.37 |    0.01 |
|         ForLocalCached | COMPLUS_TieredCompilation=1 | 1024 |    478.842 ns |   1.0151 ns |   0.7925 ns |  1.37 |    0.01 |
| ForLocalCachedUnrolled | COMPLUS_TieredCompilation=1 | 1024 |    390.976 ns |   1.1215 ns |   1.0490 ns |  1.12 |    0.01 |
|      ListForeachSimple | COMPLUS_TieredCompilation=1 | 1024 |  4,484.722 ns |  16.8146 ns |  14.9057 ns | 12.79 |    0.08 |
|          ListForSimple | COMPLUS_TieredCompilation=1 | 1024 |    889.401 ns |   1.5397 ns |   1.2857 ns |  2.54 |    0.01 |
|         ListForToArray | COMPLUS_TieredCompilation=1 | 1024 |    414.718 ns |   2.8762 ns |   2.6904 ns |  1.18 |    0.01 |
|     ListForLocalCached | COMPLUS_TieredCompilation=1 | 1024 |    479.792 ns |   1.3273 ns |   1.1766 ns |  1.37 |    0.01 |
|                        |                             |      |               |             |             |       |         |
|                **Foreach** | **COMPLUS_TieredCompilation=0** | **4096** |  **1,898.159 ns** |   **3.6610 ns** |   **3.4245 ns** |  **1.00** |    **0.00** |
|              ForSimple | COMPLUS_TieredCompilation=0 | 4096 |  1,901.075 ns |   7.4178 ns |   6.9387 ns |  1.00 |    0.00 |
|         ForLocalCached | COMPLUS_TieredCompilation=0 | 4096 |  1,901.219 ns |   5.4119 ns |   5.0623 ns |  1.00 |    0.00 |
| ForLocalCachedUnrolled | COMPLUS_TieredCompilation=0 | 4096 |  1,550.613 ns |   6.5758 ns |   6.1510 ns |  0.82 |    0.00 |
|      ListForeachSimple | COMPLUS_TieredCompilation=0 | 4096 | 17,936.972 ns |  98.2268 ns |  82.0238 ns |  9.45 |    0.05 |
|          ListForSimple | COMPLUS_TieredCompilation=0 | 4096 |  3,539.824 ns |  16.8249 ns |  15.7380 ns |  1.86 |    0.01 |
|         ListForToArray | COMPLUS_TieredCompilation=0 | 4096 |  2,111.982 ns |   7.9225 ns |   7.4107 ns |  1.11 |    0.00 |
|     ListForLocalCached | COMPLUS_TieredCompilation=0 | 4096 |  1,902.008 ns |   6.1417 ns |   5.4444 ns |  1.00 |    0.00 |
|                        |                             |      |               |             |             |       |         |
|                Foreach | COMPLUS_TieredCompilation=1 | 4096 |  1,890.688 ns |   5.3009 ns |   4.6991 ns |  1.00 |    0.00 |
|              ForSimple | COMPLUS_TieredCompilation=1 | 4096 |  1,898.929 ns |   3.5603 ns |   2.7796 ns |  1.00 |    0.00 |
|         ForLocalCached | COMPLUS_TieredCompilation=1 | 4096 |  1,897.652 ns |   3.3323 ns |   2.9540 ns |  1.00 |    0.00 |
| ForLocalCachedUnrolled | COMPLUS_TieredCompilation=1 | 4096 |  1,545.495 ns |   3.6759 ns |   3.2586 ns |  0.82 |    0.00 |
|      ListForeachSimple | COMPLUS_TieredCompilation=1 | 4096 | 18,063.228 ns | 182.8993 ns | 171.0841 ns |  9.54 |    0.08 |
|          ListForSimple | COMPLUS_TieredCompilation=1 | 4096 |  3,546.471 ns |   8.9970 ns |   7.9756 ns |  1.88 |    0.01 |
|         ListForToArray | COMPLUS_TieredCompilation=1 | 4096 |  1,621.601 ns |  11.1671 ns |  10.4457 ns |  0.86 |    0.01 |
|     ListForLocalCached | COMPLUS_TieredCompilation=1 | 4096 |  1,900.845 ns |   5.9132 ns |   5.5312 ns |  1.01 |    0.00 |
