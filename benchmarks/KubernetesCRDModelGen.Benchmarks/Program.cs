using BenchmarkDotNet.Running;

namespace KubernetesCRDModelGen.Benchmarks;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmark>();
    }
}
