using BenchmarkDotNet.Running;
using System;

namespace PerformanceTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SearchTeamPerformance>();
            Console.Read();
        }
    }
}
