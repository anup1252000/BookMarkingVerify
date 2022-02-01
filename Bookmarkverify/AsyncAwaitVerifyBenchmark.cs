using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmarkverify
{
    [ThreadingDiagnoser]
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    [ConcurrencyVisualizerProfiler]
    public class AsyncAwaitVerifyBenchmark
    {
        [Benchmark(Baseline = true)]
        public async Task GetTask() {
            await new AsyncAwaitVerify().GetTaskAsync();
        }

        [Benchmark]
        public async Task GetTaskConfigureAwaitFalseAsync()
        {
            await new AsyncAwaitVerify().GetTaskAsync().ConfigureAwait(false);
        }
    }
}
