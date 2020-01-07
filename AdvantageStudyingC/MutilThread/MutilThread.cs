using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AdvantageStudyingC.MutilThread
{
    public class MutipleThread
    {
        static void ExtractExecutingThread()
        {
            // Get the thread currently
            // executing this method.
            Thread currThread = Thread.CurrentThread;
        }
        static void ExtractAppDomainHostingThread()
        {
            // Obtain the AppDomain hosting the current thread.
            AppDomain ad = Thread.GetDomain();
        }
        public  void Execute()
        {
            ExtractExecutingThread();
            ExtractAppDomainHostingThread();

        }
    }
}
