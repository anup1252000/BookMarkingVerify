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
    public class AdditionBenchmark
    {
        [Params(1, 100)]
        public int A { get; set; }

        [Params(1, 100)]
        public int B { get; set; }

        private Maths maths;

        public AdditionBenchmark()
        {
            maths = new Maths();
        }

        [Benchmark(Baseline = true)]
        public void Addition()
        {
            maths.Addition(A, B);
        }

        [Benchmark]
        public void AdditionTryCatch()
        {
            maths.AdditionTryCatch(A, B);
        }
    }

}
