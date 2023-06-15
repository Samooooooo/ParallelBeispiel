using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait01
{
  internal class Program
  {
    //static void Main(string[] args)
    //{
    //  Console.WriteLine("Main started");
    //  DoCalculation();
    //  Console.WriteLine("Main finished");
    //}
    //static void DoCalculation()
    //{
    //  Console.WriteLine("     DoCalculation started");
    //  Task<int> t1 = Task.Run(() => RandomValue());
    //  Task<int> t2 = Task.Run(() => RandomValue());

    //  int result1 = t1.Result;
    //  int result2 = t2.Result;
    //  Console.WriteLine($"{result1 + result2}");
    //  Console.WriteLine("     DoCalculation finished");
    //}
    //static int RandomValue()
    //{
    //  Console.WriteLine("       RandomValue statred");
    //  Thread.Sleep(1000);
    //  Console.WriteLine("       RandomValue finished");
    //  return new Random().Next(1000);
    //}
    static void Main(string[] args)
    {
      Console.WriteLine("Main started");
      DoCalculationAsync();
      Console.WriteLine("Main finished");

      Console.ReadKey();
    }
    static async Task DoCalculationAsync()
    {
      Console.WriteLine("     DoCalculation started: Id " + Thread.CurrentThread.ManagedThreadId);
      Task<int> t1 = Task.Run(() => RandomValue());
      Task<int> t2 = Task.Run(() => RandomValue());

      //Thread.Sleep(2000);

      int result1 = await t1;
      int result2 = await t2;

      Console.WriteLine($"{result1 + result2}");
      Console.WriteLine("     DoCalculation finished: ID=> " + Thread.CurrentThread.ManagedThreadId);
    }
    static int RandomValue()
    {
      Console.WriteLine("       RandomValue statred: ID=> " + Thread.CurrentThread.ManagedThreadId);
      Thread.Sleep(1000);
      Console.WriteLine("       RandomValue finished: ID=> " + Thread.CurrentThread.ManagedThreadId);
      return new Random().Next(1000);
    }
  }
}
