using AdvantageStudyingC.Delegate;
using AdvantageStudyingC.Static;
using System;
using static System.DateTime;
using AdvantageStudyingC.DownUpCasting;
using AdvantageStudyingC.Interface;
using AdvantageStudyingC.Collection;
using AdvantageStudyingC.Event;
using AdvantageStudyingC.LamdaExpression;
using AdvantageStudyingC.AdvantageFeature;
using AdvantageStudyingC.MutilThread;

namespace AdvantageStudyingC
{
   
    class Program
    {
        static int Main(string[] args)
        {
            //Delegation delegation = new Delegation();
            //delegation.callTest();

            //Static
            //SavingAccount s1 = new SavingAccount(50);
            //Console.WriteLine("Interest Rate is : {0}", SavingAccount.GetInterestRate());
            //s1.SetInterestRate(0.08);
            //Console.WriteLine("Interest Rate is : {0}", SavingAccount.GetInterestRate());
            //SavingAccount s2 = new SavingAccount(100);
            //s1.SetInterestRate(0.04);
            //Console.WriteLine("Interest Rate is : {0}", SavingAccount.GetInterestRate());
            //Console.WriteLine(Now.Date);
            //AdvantageStudyingC.DownUpCasting.DownUpCasting.execute();
            //ExecuteInterface.start();

            //ExecuteInterfaceIterator.start();
            //ExecuteInterfaceClonable.start();
            //ExecuteIComparable.start();
            //ObservableCollection.ExecuteObservableCollection();
            //CustomGeneric.CustomGenericExecute();
            //StructGeneric.StructGenericExecute();
            //SimpleDelegateExecute.execute();
            //SendingObjectState.SendingObjectStateExecute();
            //DeligateAction.ExecuteDeligateAction();
            //EventCarExecute.execute();
            //CarEventArgsExecute.execute();
            //TraditionalDelegateSyntax.execute();
            //MutipleParameter.execute();
            //AdvantageStudyingC.AdvantageFeature.Point.execute();
            //CustomeTypeConversionMain.Execute();
            //ExtentionMethodMain.Execute();
            //AnonymousMain.Execute();
            //PointerType.Execute();
            //MutipleThread mutilThread = new MutipleThread();
            //mutilThread.Execute();
            AsyncDelegate.Execute();
            //Printer.Execute();
            //Parametize.Execute();
            //AutoResetEvent2.Execute();
            //TaskParallelism.GetBook();
            //ParallelLinq.Execute();
            //AsyncAwait.Execute();
            Console.ReadLine();
            return -1;
        }
    }
}
