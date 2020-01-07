using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Interface
{
    public class Circle : Shape
    {
        private string name;
        public Circle(string name) {
            this.name = name;
        }
        public Circle()
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public interface IPointy
    {
        byte Points { get; }
    }

    public class Pencil : IPointy
    {
        public byte Points => throw new NotImplementedException();
    }

    public abstract class Shape
    {
        private string name;
        public Shape(string name)
        {
            this.name = name;
        }
        public Shape() { }
        public abstract void Draw();
    }

    public class SwitchBlade : IPointy
    {
        public byte Points
        {
            get { return 2; }
        }
    }

    public class Triangle : Shape, IPointy
    {

        public Triangle() { }
        public Triangle(string name) : base(name)
        {
            
        }
        public byte Points
        {
            get { return 3; }
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing  the Triangle");
        }
    }

   

    public class Hexagon : Shape, IPointy
    {

        public Hexagon() { }
        public Hexagon(string name) : base(name)
        {

        }
        public byte Points
        {
            get { return 6; }
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing the Hexagon");
        }
    }


    public class ExecuteInterface
    {
        public static void start()
        {
            Hexagon hex = new Hexagon();
            IPointy pointy = hex as IPointy ;
            if (pointy != null)
            {
                Console.WriteLine("Points: {0}", pointy.Points);
            }
            else
            {
                Console.WriteLine("It's not pointy....");
            }

            Shape[] arrShape = { new Hexagon(), new Circle(),
                                 new Triangle("Joe"), new Circle("JoJo") };
            var length = arrShape.Length;
            for (int i = 0; i < length; i++)
            {
                arrShape[i].Draw();
                if (arrShape[i] is IPointy ip)
                {
                    Console.WriteLine("Point : {0}", ip.Points);
                }
                else
                {
                    Console.WriteLine("It's not pointy");
                }
            }


        }
    }
}
