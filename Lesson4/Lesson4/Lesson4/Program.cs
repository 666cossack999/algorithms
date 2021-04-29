using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
           var reuslt = BenchmarkRunner.Run<MyBenchClass>();

            Console.WriteLine("Здарова______________________");
            Console.WriteLine(reuslt.Table);
            
        }
    }
}
