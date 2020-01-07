using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvantageStudyingC.MutilThread
{
  public class ParallelLinq
  {
    static CancellationTokenSource cancelToken = new CancellationTokenSource();

    //public static void Execute()
    //{
    //  Console.WriteLine("Start any key to start processing");
    //  Console.ReadKey();
    //  Console.WriteLine("Processing");
    //  Task.Factory.StartNew(() => ProcessIntData());
    //  Console.ReadLine(); 
    //}
    //static void ProcessIntData()
    //{
    //  // Get a very large array of integers.
    //  int[] source = Enumerable.Range(1, 100000000).ToArray();
    //  // Find the numbers where num % 3 == 0 is true, returned
    //  // in descending order.
    //  int[] modThreeIsZero = (from num in source
    //                          where num % 3 == 0
    //                          orderby num descending
    //                          select num).ToArray();
    //  Console.WriteLine($"Found { modThreeIsZero.Count()} numbers that match query!");
    //}
    public static void Execute()
    {      
      do
      {
        Console.WriteLine("Start any key to start processing");
        Console.ReadKey();
        Console.WriteLine("Processing");
        Task.Factory.StartNew(() => ProcessIntData());
        Console.Write("Enter Q to quit: ");
        string answer = Console.ReadLine();
        // Does user want to quit?
        if (answer.Equals("Q", StringComparison.OrdinalIgnoreCase))
        {
          cancelToken.Cancel();
          break;
        }
      } while (true);
      Console.ReadLine();
    }


    static void ProcessIntData()
    {
      // Get a very large array of integers.
      int[] source = Enumerable.Range(1, 10_000_000).ToArray();
      foreach (var item in source)
      {
        Console.WriteLine(item);
      }
      
      // Find the numbers where num % 3 == 0 is true, returned
      // in descending order.
      int[] modThreeIsZero = null;
      try
      {
        modThreeIsZero = (from num in source.AsParallel().WithCancellation(cancelToken.Token)
                          where num % 3 == 0
                          orderby num descending
                          select num).ToArray();
        Console.WriteLine();
        Console.WriteLine($"Found {modThreeIsZero.Count()} numbers that match query!");
      }
      catch (OperationCanceledException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}

