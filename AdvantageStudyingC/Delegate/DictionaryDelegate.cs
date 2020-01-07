using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Delegate
{
    public partial class Delegation
    {
        private delegate void Prinf();
        Dictionary<object, Prinf> prinf = new Dictionary<object, Prinf>() {
             { "Prinf1", Prinf1 },
             { "Prinf2", Prinf2 }
        };

        public void DoSomething(string key)
        {           
            prinf[key]();
        }
        public static void Prinf1()
        {
            Console.WriteLine("prinf1");
        }
        public static void Prinf2()
        {
            Console.WriteLine("prinf2");
        }
    }
}
