using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.AdvantageFeature
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xPos,int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        public Point(){}
        public override string ToString()
        {
            return $"[{this.X},{this.Y}]";
        }
        public static Point operator - (Point p1, int change) => new Point(p1.X - change, p1.Y - change);
        public static Point operator +(Point p1, Point p2) => new Point(p1.X + p2.X, p1.Y + p2.Y);
        public static Point operator ++(Point p1) => new Point(p1.X +1, p1.Y + 1);
        public static Point operator --(Point p1) => new Point(p1.X - 1, p1.Y - 1);
        public override bool Equals(object obj) => obj.ToString() == this.ToString();
        public override int GetHashCode() => this.ToString().GetHashCode();

        public static bool operator ==(Point p1, Point p2) => p1.Equals(p2);
        public static bool operator !=(Point p1, Point p2) => !p1.Equals(p2);

        public static void execute()
        {
            Point p1 = new Point { X = 1, Y = 2 };
            Point p2 = new Point { X = 1, Y = 2 };
            Point p3 = p1 + p2;
            Point p4 = p2 - 1;
            Point p5 = new Point { X = 5, Y = 6 };
            p5--;
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(p5);
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine("ptOne == ptTwo :{0}", p1 == p2);
        }
    }
}
