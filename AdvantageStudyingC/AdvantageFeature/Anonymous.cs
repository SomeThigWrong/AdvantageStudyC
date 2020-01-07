using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.AdvantageFeature
{
    public class Anonymous
    {
        public static void BuildOnType(string make, string color, int currSp)
        {
            var car = new { Make = make, Color = color, Speed = currSp };
            Console.WriteLine("You have a {0} {1} going {2} MPH",car.Color, car.Make, car.Speed);
            Console.WriteLine("ToString() == {0}", car.ToString());
        }
    }
    public class AnonymousMain
    {
        public static void Execute()
        {
            var mycar = new { Color = "Red", Make = "Saab", CurrendSpeed = 55 };            
            Console.WriteLine("My car is a {0} {1}",mycar.Color,mycar.CurrendSpeed);
            Anonymous.BuildOnType("BMW", "Black", 90);
        }
    }
}
