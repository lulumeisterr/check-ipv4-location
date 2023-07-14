
using BenchmarkDotNet.Running;
using tipsPerformace.CompareStrings.BenchMarker;
using tipsPerformace.Loops.BenchMarker;

var summary = BenchmarkRunner.Run(typeof(CompareStrings).Assembly);
//var summary = BenchmarkRunner.Run(typeof(StringFunctions).Assembly);

CompareForLoops compareForLoops = new CompareForLoops();
compareForLoops.CompareForLoop();