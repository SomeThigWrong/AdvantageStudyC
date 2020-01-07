using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Delegate
{
    public partial class Delegation
    {
        public delegate double Intergrand(double x);
        private static double DMyfun1(double x)
        {
            return x;
        }
        private static double DMyfun2(double x)
        {
            return 2 * x;
        }
        static double Gauss3(Intergrand f, double a, double b, int n)
        {
            double c = a * b + n;
            return f(c);
        }
    }
    #region Without delegates
    //interface Intergrand
    //{
    //    double eval(double x);
    //}
    // class Myfunc1 : Intergrand
    //{
    //    public double eval(double x)
    //    {
    //        return x ;
    //    }

    //}
    // class Myfunc2 : Intergrand
    //{
    //    public double eval(double x)
    //    {
    //        return 2 * x;
    //    }
    //}
    #endregion

}
