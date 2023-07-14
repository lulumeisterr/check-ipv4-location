
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace tipsPerformace.CompareStrings.BenchMarker 
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(BenchmarkDotNet.Mathematics.NumeralSystem.Arabic)]
    public class CompareStrings 
    {
        string stringComparation = "TESTE";

        [Benchmark()]
        public void CompareWithEquals() 
        {
            stringComparation.Equals("TESTE");
        }

        [Benchmark()]
        public void CompareWithEquality() 
        {
            var result = stringComparation == "TESTE";
        }

        [Benchmark()]
        public void CompareWithStringComparation() 
        {
            var result = string.Compare(stringComparation,"TESTE");
        }

    }
}