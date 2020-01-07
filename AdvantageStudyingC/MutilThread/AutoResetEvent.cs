using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AdvantageStudyingC.MutilThread
{
    class AddParams2
    {
        public int a, b;
        public AddParams2(int numb1, int numb2)
        {
            a = numb1;
            b = numb2;
        }
    }

    public class AutoResetEvent2
    {
        private static AutoResetEvent waitHandle = new AutoResetEvent(false);
        static void Add(object data)
        {
            if (data is AddParams2)
            {
                Console.WriteLine("ID of thread in Add(): {0}",
                Thread.CurrentThread.ManagedThreadId);
                AddParams2 ap = (AddParams2)data;
                Console.WriteLine("{0} + {1} is {2}",
                ap.a, ap.b, ap.a + ap.b);
                // Tell other thread we are done.
                waitHandle.Set();
            }
        }
        public static void Execute()
        {
            Console.WriteLine("***** Adding with Thread objects *****");
            Console.WriteLine("ID of thread in Main(): {0}",
            Thread.CurrentThread.ManagedThreadId);
            AddParams2 ap = new AddParams2(10, 10);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);
            // Wait here until you are notified!
            waitHandle.WaitOne();
            Console.WriteLine("Other thread is done!");
            Console.ReadLine();
        }
    }
    
}
