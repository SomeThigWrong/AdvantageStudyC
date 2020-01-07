using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Interface
{
    public class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }
        public PointDescription()
        {
            PetName = "No-name";
            PointID = Guid.NewGuid();
        }
    }
    public class Point :ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();
        public Point(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            desc.PetName = petName;
        }
        public Point(int xPos, int yPos)
        {
            X = xPos; Y = yPos;
        }
        public Point()
        {

        }
        public override string ToString() => $"X = {X}; Y = {Y}; Name = {desc.PetName};\nID = {desc.PointID}\n";

        public object Clone()
        {
            Point newPoint = (Point)this.MemberwiseClone();
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }

    public class ExecuteInterfaceClonable
    {
        public static void start()
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");
            Console.WriteLine("Cloned p3 and stored new Point in p4");
            Point point3 = new Point(100, 100, "jane");
            Point point4 = (Point)point3.Clone();
            Console.WriteLine("Before modification:");
            Console.WriteLine("P3:{0}",point3);
            Console.WriteLine("P4:{0}", point4);
            point4.desc.PetName = "My New Point";
            point4.X = 9;
            Console.WriteLine("After modification:");
            Console.WriteLine("P3:{0}", point3);
            Console.WriteLine("P4:{0}", point4);
        }
    }
}
