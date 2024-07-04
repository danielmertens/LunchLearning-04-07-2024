using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Examples.Benchmark;

public class FirstBenchmark
{
    private int[] arr = [1, 2, 3];

    [Benchmark]
    public int LinqFirst()
    {
        return arr.First();
    }

    [Benchmark]
    public int PatternSelectFirst()
    {
        if (arr is [var first, ..])
        {
            return first;
        }

        throw new Exception();    
    }

    [Benchmark]
    public int IfLenghtFirst()
    {
        return arr[0];
    }
}
