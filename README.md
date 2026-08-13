<div align="center">

# Aero.Sort;

Aero.Sort is a library for sorting algorithms


![C#](https://img.shields.io/badge/C%23-.NET%2010-512BD4?logo=csharp&logoColor=white)
![NuGet](https://img.shields.io/nuget/v/Aero.Sort?logo=nuget)
![License](https://img.shields.io/badge/license-Apache--2.0-blue)

---

</div>

## Installation

### `dotnet add package Aero.Sort --version 1.0.0`

> [!NOTE]
> The [Nuget](https://www.nuget.org/packages/Aero.Sort/1.0.0) link

## Usage

```Csharp
using Aero.Sort;

int[] array = { 5, 2, 8, 1, 3 };

array.Quick();
array.Bubble();
array.Bogo();
array.Insertion();
array.MergeSort();
array.Quick();
```

## Algorithms

| Algorithm | Best | Average | Worst | Space | Stable |
|---|---:|---:|---:|---:|:---:|
| Bubble Sort | O(n) | O(n²) | O(n²) | O(1) | Yes |
| Bogo Sort | O(n) | O(n × n!) | Unbounded | O(1) | No |
| Insertion Sort | O(n) | O(n²) | O(n²) | O(1) | Yes |
| Merge Sort | O(n log n) | O(n log n) | O(n log n) | O(n) | Yes |
| Quick Sort | O(n log n) | O(n log n) | O(n²) | O(log n)* | No |

## Requirements

.NET 10

## License

Apache 2.0
