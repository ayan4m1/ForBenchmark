// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace ForBenchmark
{
    [SimpleJob(RuntimeMoniker.Net70)]
    [RPlotExporter]
    public class ForLoops
    {
        private byte[] data;

        [Params(10, 100, 1000, 10000, 100000)]
        public int Items;

        [GlobalSetup]
        public void Setup()
        {
            data = new byte[Items];
            new Random(42).NextBytes(data);
        }

        [Benchmark]
        public int Linq()
        {
            return data.Aggregate(0, (next, result) => result + next);
        }

        [Benchmark]
        public int ForEach()
        {
            var sum = 0;

            foreach (var item in data)
            {
                sum += item;
            }

            return sum;
        }

        [Benchmark]
        public int ForIndex()
        {
            var sum = 0;
            var localData = data;

            for (var index = 0; index < localData.Length; index++)
            {
                var item = localData[index];
                sum += item;
            }

            return sum;
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ForLoops>();
        }
    }
}