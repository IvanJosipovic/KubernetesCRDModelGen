using BenchmarkDotNet.Running;

namespace KubernetesCRDModelGen.Benchmarks;

internal class Program
{
    static void Main(string[] args)
    {
        var _ = BenchmarkRunner.Run(typeof(Program).Assembly, args: args);
    }
}
