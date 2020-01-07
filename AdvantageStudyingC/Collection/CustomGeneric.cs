using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AdvantageStudyingC.Collection
{
    public class CustomGeneric
    {
        static void Swap(ref Person a, ref Person b)
        {
            Person temp = a;
            a = b;
            b = temp;            
            
        }
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

        }
        public static void  CustomGenericExecute()
        {
            int a = 10, b = 90;
            Swap<int>(ref a, ref b);
            Console.WriteLine(string.Format("a:{0},b:{1}", a,b));
            string c = "hello", d = "world";
            Swap<string>(ref c, ref d);
            Console.WriteLine(string.Format("c:{0},d:{1}", c, d));        
        }
    }
}
