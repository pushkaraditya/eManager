using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
  class Program
  {
    static void Main(string[] args)
    {
      var task = SlowOperationAsync();

      for (int i = 0; i < 10; i++)
        Console.WriteLine(i);

      Console.WriteLine("Slow operation result: {0}", task.Result);
      Console.WriteLine("Main completed on thread: {0}", Thread.CurrentThread.ManagedThreadId);

      Console.ReadLine();
    }

    private static async Task<int> SlowOperationAsync()
    {
      Console.WriteLine("Slow operation started on thread Id: {0}", Thread.CurrentThread.ManagedThreadId);
      await Task.Delay(2000);
      Console.WriteLine("Slow operation completed on thread Id: {0}", Thread.CurrentThread.ManagedThreadId);

      return 42;
    }
  }
}
