using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.AdvantageFeature
{
    public class Base { };
    public class Derived : Base { };
    public class CustomeTypeConversion
    {
        public static void Execute()
        {
            int a = 123;
            long b = a;
            int c = (int)b;
            Derived myBaseType = new Derived();
            Base derived = myBaseType;

        }
    }
    public struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }
        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public override string ToString() => $"[With = {Width};Height = {Height}]";
        public static implicit operator Rectangle(Square s)
        {
            Rectangle r = new Rectangle
            {
                Height = s.Length,
                Width = s.Length * 2
            };
            return r;
        }
    }
    public struct Square
    {
        public int Length { get; set; }
        public Square(int length)
        {
            this.Length= length;
        }
        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public override string ToString() => $"[Legnth = {Length}]";
        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square{ Length = r.Height};
            return s;
        }
        public static explicit operator Square(int sideLength)
        {
            Square newSq = new Square { Length = sideLength };
            return newSq;
        }
    }

    public class CustomeTypeConversionMain
    {
        public static void Execute()
        {
            Rectangle rectangle = new Rectangle(15, 4);
            Console.WriteLine(rectangle.ToString());
            rectangle.Draw();
            Console.WriteLine();
            Square s = (Square)rectangle;
            //Square s2 = (Square)50;
            Square s3 = new Square { Length = 30 };
            Rectangle rect2 = s3;
            rect2.Draw();
            //s.Draw();
            //s2.Draw();
        }
    }
}
