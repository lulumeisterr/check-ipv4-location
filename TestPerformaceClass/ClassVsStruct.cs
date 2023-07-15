using BenchmarkDotNet.Attributes;
using tips_optimization_csharp.model;

namespace tipsPerformace.ClassVsStruct.BenchMarker 
{
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(BenchmarkDotNet.Mathematics.NumeralSystem.Arabic)]
    public class ClassVsStruct
    {
        public List<string> Names 
        {
            get {
                return new tipsPerformace.Loops.BenchMarker.CompareForLoops().getNames();
            }
        }
        
        [Benchmark()]
        public void TestClass() 
        {
            var classes = Names.Select(x => new PersonClass { Name = x });
        }

        [Benchmark()]
        public void TestStructs() 
        {
            var classes = Names.Select(x => new PersonClass { Name = x });
        }
    }
}