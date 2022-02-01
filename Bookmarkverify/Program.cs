using BenchmarkDotNet.Running;
using Bookmarkverify;

//BenchmarkRunner.Run<AdditionBenchmark>();
//BenchmarkRunner.Run<AsyncAwaitVerifyBenchmark>();
BenchmarkRunner.Run<StringVerifyBenchmark>();
//var stream = new MemoryStream();
//var writer = new StreamWriter(stream);
//writer.Write("äbc");
//writer.Flush();
//stream.Position = 0;
Console.ReadLine();
