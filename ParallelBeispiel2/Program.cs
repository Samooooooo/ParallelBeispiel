using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelBeispiel2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      SynchronLoops(100);
      stopwatch.Stop();
      Console.WriteLine($"Synchron: {stopwatch.ElapsedMilliseconds}");
      stopwatch.Reset();
      stopwatch.Start();
      ParallelLoops(100);
      stopwatch.Stop();
      Console.WriteLine($"Parallel: {stopwatch.ElapsedMilliseconds}");
    }
    static void SynchronLoops(int loops)
    {
      double[] array = new double[loops];
      for (int i = 0; i < loops; i++)
      {
        array[i] = Math.Pow(i, 0.333) * (Math.Sqrt(Math.Sin(i)));
      }
    }
    static void ParallelLoops(int loops)
    {
      double[] array = new double[loops];
      Parallel.For(0, loops, (i) =>
      {
        Thread.Sleep(10);
        array[i] = Math.Pow(i, 0.333) * (Math.Sqrt(Math.Sin(i)));
      });
    }
  }
}
