using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvantageStudyingC.MutilThread
{
    public delegate int BinaryOp(int x, int y);
    class AsyncDelegate
    {

        public async Task MyMethodAsync()
        {
            Task<int> longRunningTask = LongRunningOperationAsync();
            // independent work which doesn't need the result of LongRunningOperationAsync can be done here

            //and now we call await on the task 
            int result = await longRunningTask;
            //use the result 
            Console.WriteLine("Hello");
            Console.WriteLine(result);
           
        }

        public async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation 
        {
            await Task.Delay(1000); // 1 second delay
            return 1;
        }
        public  static void Execute()
        {
            AsyncDelegate asyncDelegate = new AsyncDelegate();
            asyncDelegate.MyMethodAsync();
            Console.WriteLine("something here");
          
        }
        static int Add(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }
        static void AddComplete(IAsyncResult iar)
        {
            Console.WriteLine("AddComplete() invoked on thread {0}.", Thread.CurrentThread.
            ManagedThreadId);
            Console.WriteLine("Your addition is complete");
           
        }
        private static void OnDataReceived(IAsyncResult result)
        {
            Console.WriteLine("My Important Variable was: {0}", result.AsyncState); // Prints 5
        }
       
    }
}