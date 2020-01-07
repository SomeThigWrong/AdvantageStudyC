using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Collection
{
    public struct Point<T>
    {
        private T xPos;
        private T yPos;
        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        public T XPos { get => xPos; set => xPos = value; }
        public T YPos { get => yPos; set => yPos = value; }
        public override string ToString() => $"[{xPos},{YPos}]";
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }

        //public T XPos { get => xPos; set => xPos = value; }
    }
    public class StructGeneric{
        internal static void StructGenericExecute()
        {
            Point<int> p = new Point<int>(10, 10);
            Console.WriteLine(p.ToString());
            p.ResetPoint();
            Console.WriteLine(p.ToString());

            Point<double> pd = new Point<double>(10.0, 10.0);
            Console.WriteLine(pd.ToString());
            pd.ResetPoint();
            Console.WriteLine(pd.ToString());
        }
    }
}
