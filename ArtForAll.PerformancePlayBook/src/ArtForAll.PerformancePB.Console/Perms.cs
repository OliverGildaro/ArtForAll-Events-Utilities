using ArtForAll.PerformancePB.Code;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace ArtForAll.PerformancePB.Console;

[ShortRunJob]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
public class Perms
{
    string permsFilePath = @"D:\repositories\ArtForAll-Events-Utilities\ArtForAll.PerformancePlayBook\permsfile.txt";

    [GlobalSetup]
    public void Setup()
    {
        FilePermissionsChecker.LoadACL();
    }

    [Benchmark]
    public void QuickAndDirty()
    {
        var x = FilePermissionsChecker.CheckPermissionQD(permsFilePath);
    }

    [Benchmark]
    public void ProperCheck()
    {
        var x = FilePermissionsChecker.CheckPermission(permsFilePath);
    }

    [Benchmark]
    public void FileACLCheck()
    {
        var x = FilePermissionsChecker.CheckPermissionFC(permsFilePath);
    }
}
