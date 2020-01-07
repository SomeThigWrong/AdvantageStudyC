using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Delegate
{
    public delegate void MyGenericDeligate<T>(T arg);
    public class GenericDelegate
    {
        public static void GenericDelegateExecute()
        {
            Console.WriteLine("***** Generic Delegates *****\n");
            // Register targets.
            MyGenericDeligate<string> strTarget = new MyGenericDeligate<string>(StringTarget);
            MyGenericDeligate<int> intTarget = new MyGenericDeligate<int>(IntTarget);
        }

        static void StringTarget(string arg)
        {
            Console.WriteLine("arg in uppercase is : {0} ", arg.ToUpper());
        }
        static void IntTarget(int arg)
        {
            Console.WriteLine("arg in uppercase is : {0} ", arg);
        }

    }


}
