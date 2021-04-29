using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
           BenchmarkRunner.Run<MyBenchClass>();            
        }
    }
}
