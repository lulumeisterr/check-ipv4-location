
using BenchmarkDotNet.Running;
using tipsPerformace.ClassVsStruct.BenchMarker;
using tipsPerformace.Loops.BenchMarker;

var summary = BenchmarkRunner.Run(typeof(ClassVsStruct).Assembly);
//var summary = BenchmarkRunner.Run(typeof(CompareStrings).Assembly);
//var summary = BenchmarkRunner.Run(typeof(StringFunctions).Assembly);

/**
CompareForLoops compareForLoops = new CompareForLoops();
compareForLoops.CompareForLoop();
*/

new ClassVsStruct().TestClass();