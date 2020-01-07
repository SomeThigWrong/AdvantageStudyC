using System;
using System.Collections.Generic;
using System.Text;
using AdvantageStudyingC.DownUpCasting;
using System.Collections;

namespace AdvantageStudyingC.Interface
{
 
    public class Car2 : Vehicle, IComparable
    {
        public int CarID { get; set; }

        public static IComparer SortByCurrentSpeed
        {
            get { return new SpeedComparator(); }
        }
        public Car2(int currentSpeed, VehicleColor color, double maxSpeed,int ID) : base(currentSpeed, color, maxSpeed)
        {
            this.CarID = ID;
        }       

        public override void Run()
        {
            Console.WriteLine("Car running");
        }
        public void increVelocity()
        {

        }

        public int CompareTo(object obj)
        {
            Car2 tempcar = obj as Car2;
            if (tempcar != null)
            {
                if (this.CarID < tempcar.CarID)
                {
                    return 1;
                }
                else
                if (this.CarID > tempcar.CarID)
                {
                    return -1;
                }
                else
                    return 0;
                //return this.CarID.CompareTo(tempcar.CarID);
            }
            else
            {
                throw new ArgumentException("Parameter is not a Car!");
            }
        }

    }


    public class SpeedComparator : IComparer
    {
        public int Compare(object x, object y)
        {
            Car2 car1 = x as Car2;
            Car2 car2 = y as Car2;
            if(car1 != null && car2 != null)
            {
                return car1.CurrentSpeed.CompareTo((int)car2.CurrentSpeed);
            }
            else
            {
                throw new ArgumentException("Parameter is not a car");
            }
        }
    }

    public static class ExecuteIComparable
    {
        public static void start()
        {
            Car2[] mycars = new Car2[5];
            mycars[0] = new Car2(100,VehicleColor.Back, 100, 1);
            mycars[1] = new Car2(50,VehicleColor.Back, 200, 1);
            mycars[2] = new Car2(70,VehicleColor.Back, 300, 1);
            mycars[3] = new Car2(60,VehicleColor.Back, 500, 2);
            mycars[4] = new Car2(10,VehicleColor.Back, 600, 2);
            foreach (var car in mycars)
            {
                Console.WriteLine("{0} {1}",car.CarID,car.CurrentSpeed);
            }
            Array.Sort(mycars, Car2.SortByCurrentSpeed);
            Console.WriteLine("After sorted");
            foreach (var car in mycars)
            {
                Console.WriteLine("{0} {1}", car.CarID, car.CurrentSpeed);
            }

        }

    }

    
}
