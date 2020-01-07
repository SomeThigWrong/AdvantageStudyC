using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.LamdaExpression
{
    public class MutipleParameter
    {
        public delegate void MathMesage(string msg, int result);
        private MathMesage mmDelegate;
        public void SetMathHandler(MathMesage target) { mmDelegate = target; }
        public void Add(int x, int y)
        {
            mmDelegate?.Invoke("Adding has completed!,",x+y);
        }
        public static void execute()
        {
            MutipleParameter mutipleParameter = new MutipleParameter();
            mutipleParameter.SetMathHandler((m, r) => { Console.WriteLine("Message: {0}, Result: {1}",m,r); });
            mutipleParameter.Add(10, 10);
        }
    }
}
