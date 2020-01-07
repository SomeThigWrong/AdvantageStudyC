using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvantageStudyingC.MutilThread
{

  public class AsyncAwait
  {
    public static async Task Execute()
    {
      //ommitted for brevity
      string message = await DoWorkAsync();
      Console.WriteLine(message);
      //ommitted for brevity
    }
    static string DoWork()
    {
      Thread.Sleep(5_000);
      return "Done with work!";
    }
    static async Task<string> DoWorkAsync()
    {
      return await Task.Run(() =>
      {
        Thread.Sleep(5_000);
        return "Done with work!";
      });
    }
  }
}
