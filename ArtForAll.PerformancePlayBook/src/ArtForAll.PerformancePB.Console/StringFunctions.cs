using ArtForAll.PerformancePB.Code;
using BenchmarkDotNet.Attributes;

namespace ArtForAll.PerformancePB.Console;

public class StringFunctions
{
    [Benchmark()]
    public void SBJoin()
    {
        var result = new StringWorker().BuildStringBadly("test");
    }

    [Benchmark()]
    public void SBJoinBetter()
    {
        var result = new StringWorker().BuildStringBetter("test");
    }

    [Benchmark()]
    public void NaiveSplit()
    {
        var result = new StringWorker().NaiveSplitName("Oliver, Castro");
    }

    [Benchmark()]
    public void SplitSplit()
    {
        var result = new StringWorker().SplitSplitName("Oliver, Castro");
    }

    [Benchmark()]
    public void NaiveSpanSplit()
    {
        var result = new StringWorker().SpanSplitName("Oliver, Castro");
    }
}
