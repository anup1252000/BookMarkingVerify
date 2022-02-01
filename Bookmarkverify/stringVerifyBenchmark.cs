using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmarkverify
{
    [MemoryDiagnoser]
    [NativeMemoryProfiler]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class StringVerifyBenchmark
    {

        

        [Benchmark(Baseline = true)]
        public void SubStringVerify()
        {
            for (int i = 0; i < 100; i++)
            {
                var verify = new StringVerify();
                verify.GetStringSubString();
            }
        }

        [Benchmark]
        public void SpanVerify()
        {
            for (int i = 0; i < 100; i++)
            {
                var verify = new StringVerify();
                verify.GetStringSpan();
            }
        }
    }
}
