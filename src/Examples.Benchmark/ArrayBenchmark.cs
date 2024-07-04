using BenchmarkDotNet.Attributes;

namespace Examples.Benchmark;

public class ArrayBenchmark
{
    private int[] arr1 = [1, 2, 3];
    private int[] arr2 = [1, 2, 3];

    [Benchmark]
    public int[] Concat()
    {
        return arr1.Concat(arr2).ToArray();
    }

    [Benchmark]
    public int[] ConcatWithSpread()
    {
        return [.. arr1, .. arr2];
    }

    [Benchmark]
    public int[] Concat1000()
    {
        IEnumerable<int> temp = Array.Empty<int>();

        for (int i = 0; i < 1000; i++)
        {
            temp = temp.Concat(arr1);
        }

        return temp.ToArray();
    }

    [Benchmark]
    public int[] ConcatWithSpread1000()
    {
        int[] temp = [];

        for (int i = 0; i < 1000; i++)
        {
            temp = [.. temp, .. arr1];
        }

        return temp;
    }

    [Benchmark]
    public int[] ConcatWithList1000()
    {
        List<int> temp = new List<int>();

        for (int i = 0; i < 1000; i++)
        {
            temp.AddRange(arr1);
        }

        return temp.ToArray();
    }
}