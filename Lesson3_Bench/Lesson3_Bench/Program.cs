using System;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;


namespace Lesson3_Bench
{

    class Program
    {
		static void Main(string[] args)
        {
			BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);			
		}
	}
}
