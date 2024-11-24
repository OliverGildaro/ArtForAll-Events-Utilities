using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace ArtForAll.PerformancePB.Console
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class StringComparison
    {
        string testString = "Whether tis nobler in the mind to Suffer the slings and arrows";

        [Benchmark()]
        public void EqualityComparison()
        {
            var compare = testString == "Whether tis nobler in the mind to suffer the slings and arrows";
        }

        [Benchmark()]
        public void EqualsComparison()
        {
            var compare = testString.Equals("Whether tis nobler in the mind to suffer the slings and arrows");
        }

        [Benchmark]
        public void StringCompareComparison()
        {
            var compare = string.Compare(testString, "Whether tis nobler in the mind to suffer the slings and arrows", false);
        }

        [Benchmark()]
        public void EqualityCaseSensitiveComparison()
        {
            var compare = testString.ToUpper() == "Whether tis nobler in the mind to suffer the slings and arrows".ToUpper();
        }

        [Benchmark()]
        public void EqualsCaseSensitiveComparison()
        {
            var compare = testString.ToUpper().Equals("Whether tis nobler in the mind to suffer the slings and arrows".ToUpper());
        }

        [Benchmark]
        public void StringCaseSensitiveCompareComparison()
        {
            var compare = string.Compare(testString, "Whether tis nobler in the mind to suffer the slings and arrows", true);
        }
    }
}
