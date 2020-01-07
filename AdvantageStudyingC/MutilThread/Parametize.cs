﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AdvantageStudyingC.MutilThread
{
    public class Parametize
    {
        static void Add(object data)
        {
            if (data is AddParams)
            {
                Console.WriteLine("ID of thread in Add(): {0}",
                Thread.CurrentThread.ManagedThreadId);
                AddParams ap = (AddParams)data;
                Console.WriteLine("{0} + {1} is {2}",
                ap.a, ap.b, ap.a + ap.b);
            }
        }
        public static void Execute()
        {
            Console.WriteLine("***** Adding with Thread objects *****");
            Console.WriteLine("ID of thread in Main(): {0}",
            Thread.CurrentThread.ManagedThreadId);
            // Make an AddParams object to pass to the secondary thread.
            AddParams ap = new AddParams(10, 10);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);
            // Force a wait to let other thread finish.
            Thread.Sleep(5);
            Console.ReadLine();
        }
    }
    class AddParams
    {
        public int a, b;
        public AddParams(int numb1, int numb2)
        {
            a = numb1;
            b = numb2;
        }
    }
}
