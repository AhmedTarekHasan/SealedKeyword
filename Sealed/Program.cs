using BenchmarkDotNet.Running;
using Sealed.Classes;

namespace Sealed
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmarking>();
            Console.ReadLine();
        }
    }
}