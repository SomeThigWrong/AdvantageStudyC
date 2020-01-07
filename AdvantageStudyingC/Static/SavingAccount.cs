using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Static
{
    public class SavingAccount
    {
        public double currBalance;
        public static double currInterestRate;
        public SavingAccount(double balance)
        {
            currBalance = balance;
            currInterestRate = 0.04;
        }
        public  void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
        public static double GetInterestRate()
        {
            return currInterestRate;
        }
        static SavingAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.08;
        }
    }
}
