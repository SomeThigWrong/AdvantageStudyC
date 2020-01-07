using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Event
{
    internal class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        private bool carIsDead;
        public Car()
        {

        }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }


        public delegate void CarEngineHandler(string msg);
        public event CarEngineHandler Explored;
        public event CarEngineHandler AboutToBlow;
        
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Explored?.Invoke("Sorry, this car is dead....");    
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == MaxSpeed - CurrentSpeed && AboutToBlow != null)
                {
                    AboutToBlow("Careful buddy! gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }

            }
        }
    }

    public class EventCarExecute
    {
        public static void execute()
        {
            Car car1 = new Car("SlugBug", 100, 10);

            car1.AboutToBlow += new Car.CarEngineHandler(Car1_AboutToBlow);
            car1.AboutToBlow += new Car.CarEngineHandler(CarIsAlmostDoomed);
            Car.CarEngineHandler d = new Car.CarEngineHandler(CarExplored);
            car1.Explored += d;
            for (int i = 0; i < 6; i++)
            {
                car1.Accelerate(20);
            }
        }

        private static void CarIsAlmostDoomed(string msg)
        {
            Console.WriteLine("=> Critical Message from car: {0}",msg);
        }

        private static void Car1_AboutToBlow(string msg)
        {
            Console.WriteLine(msg);
        }
        private static void CarExplored(string msg)
        {
            Console.WriteLine(msg);
        }

    }

}
