using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.DownUpCasting
{
    public class Car : Vehicle
    {        
        
        public Car(VehicleColor color, double maxSpeed) : base(color, maxSpeed)
        {

        }
        public Car() : this(VehicleColor.Yellow,0)
        {

        }

        public override void Run() {         
            Console.WriteLine("Car running");
        }
        public void increVelocity()
        {

        }
    }

    public class MotorBike : Vehicle
    {
        public MotorBike(VehicleColor color, double maxSpeed) : base(color, maxSpeed)
        {

        }
        public MotorBike() : this(VehicleColor.Yellow,0)
        {

        }
        public override void Run()
        {         
            Console.WriteLine("MotorBike running");
        }
    }

    public class Vehicle
    {
        #region Property
        protected double maxSpeed = 100;
        protected VehicleColor color;

        public double CurrentSpeed { get ; set ; }
        #endregion
        public Vehicle() { }
        public Vehicle(VehicleColor color, double maxSpeed)
        {
            this.color = color;
            this.maxSpeed = maxSpeed;
        }
        public Vehicle(int currentSpeed, VehicleColor color, double maxSpeed):this(color, maxSpeed)
        {
            this.CurrentSpeed = currentSpeed;
        }
        public virtual void Run()
        {
            Console.WriteLine("Vehicle Running");
        }
    }

    public enum VehicleColor
    {
        Red,
        Yellow,
        Brown,
        Back
    }
    public class DownUpCasting
    {
        public static void execute()
        {

            Vehicle vehicle = new Vehicle();

            Vehicle car = new Car();
            //car.Run();
            //((Vehicle)car).Run();

            //object motorBike = new MotorBike();
            //((Vehicle)motorBike).Run();
            //MotorBike motorBike2 = new MotorBike();
            //motorBike2.Run();
            //((Vehicle)motorBike2).Run();
            Vehicle car2 = new Car();
            ((Car)car2).increVelocity();
            Console.WriteLine(car.CurrentSpeed);
            SpeedUp(car);
            Console.WriteLine(car.CurrentSpeed);
        }
        static void SpeedUp(Vehicle vehicle)
        {
            switch (vehicle)
            {
                case MotorBike m:
                    m.CurrentSpeed += 10;
                    break;
                case Car c:
                    c.CurrentSpeed += 20;
                    break;
                default:
                    break;
            }
            if(vehicle is MotorBike )
            {
                vehicle.CurrentSpeed += 10;
            }else if (vehicle is Car)
            {
                vehicle.CurrentSpeed += 20;
            }
        }
    }
}
