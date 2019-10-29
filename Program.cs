using Bdn1;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System.Linq;

namespace ListBenchmarks
{
    class Program
    {
        private const string JitTieredCompilation = "COMPLUS_TieredCompilation";

        static void Main(string[] args)
        {
            var config = 
                DefaultConfig.Instance
                    .With(Job.Default.With(CoreRuntime.Core30).WithEnvironmentVariable(JitTieredCompilation, "0"))
                    .With(Job.Default.With(CoreRuntime.Core30).WithEnvironmentVariable(JitTieredCompilation, "1"));

            BenchmarkSwitcher
                .FromAssembly(typeof(Program).Assembly)
                .Run(args, config);
        }
    }
}
