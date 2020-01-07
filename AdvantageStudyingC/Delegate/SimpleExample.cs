using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Delegate
{
    public delegate int BinaryOp(int x, int y);
    public class SimpleDelegate
    {
        public  int Add(int x, int y) => x + y;
        public  int Substract(int x, int y) => x - y;
    }

    public class SimpleDelegateExecute
    {
        public static void execute()
        {
            SimpleDelegate simpleDelegate = new SimpleDelegate();
            BinaryOp b = new BinaryOp(simpleDelegate.Add);
            DisplayDelegateInfo(b);

        }

        public static void DisplayDelegateInfo(System.Delegate delOBjet)
        {
            foreach (System.Delegate d in delOBjet.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Method Name: {0}", d.Target);
            }
        }
    }
}
