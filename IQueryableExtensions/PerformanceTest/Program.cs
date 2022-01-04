using BenchmarkDotNet.Running;
using System;

namespace PerformanceTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var searh = new SearchTeamPerformance();
            //var result1 = searh.GetTeamsWithoutQueryableExtensions();
            //var result2 = searh.GetTeamsWithQueryableExtensions();

            var summary = BenchmarkRunner.Run<SearchTeamPerformance>();
            Console.Read();
        }
    }
}
