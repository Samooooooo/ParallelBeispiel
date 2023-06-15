using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelBeispiel
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Parallel.Invoke
        (
        ()=>Method1("-"),
        ()=>Method1("|"),
        ()=>Method1("*"),
        ()=>Method1(" ")
        );
    }
    static void Method1(string s)
    {
      for (int i = 0; i < 500; i++)
      {
        Console.Write(s);
        //Thread.Sleep(10);
      }
    }
  }
}
