using ArtForAll.PerformancePB.BeanchMark.Properties;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace ArtForAll.PerformancePB.Console
{
    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class Loops
    {
        public List<string> Names
        {
            get
            {
                return Resources._1000firstnames.Split('\n').ToList();
            }
        }

        [Benchmark]
        //With List<> this is performant
        public void ForLoop()
        {
            var names = Names;

            var length = names.Count();

            for (var i = 0; i < length; i++)
            {
                var x = names[i];
            }
        }

        [Benchmark]
        //With array this is performant
        public void ForEachLoop()
        {
            var names = Names;

            foreach (var name in names)
            {
                var x = name;
            }
        }

        //[Benchmark()]
        //public void LoopThroughNames()
        //{
        //    for (var i = 0; i < Names.Count; i++)
        //    {
        //        var x = Names[i];
        //    }
        //}

        //[Benchmark(Baseline = true)]
        //public void CachedLoop()
        //{
        //    var names = Names.ToList();

        //    foreach (var name in names)
        //    {
        //        var x = name;
        //    }
        //}
    }
}
