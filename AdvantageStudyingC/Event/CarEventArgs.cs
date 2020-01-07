using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Event
{
    public class CarEventArgs :EventArgs
    {
        public readonly string msg;
        public CarEventArgs(string message)
        {
            this.msg = message;
        }
    }
    internal class Car2
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        private bool carIsDead;
        public Car2()
        {

        }
        public Car2(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        public event EventHandler<CarEventArgs> Explored;
        public event EventHandler<CarEventArgs> AboutToBlow;
        //public delegate void CarEngineHandler(object sender, CarEventArgs e);
        //public event CarEngineHandler Explored;
        //public event CarEngineHandler AboutToBlow;

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Explored?.Invoke(this, new CarEventArgs("Sorry, this car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == MaxSpeed - CurrentSpeed && AboutToBlow != null)
                {
                    AboutToBlow(this, new CarEventArgs("Careful buddy! gonna blow!"));
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
    public class CarEventArgsExecute
    {
        public static void execute()
        {
            Car2 car1 = new Car2("SlugBug", 100, 10);
            int aboutToBlowCounter = 0;

            car1.AboutToBlow += Car1_AboutToBlow1;
            car1.AboutToBlow += delegate
            {
                aboutToBlowCounter++;
                Console.WriteLine("Going too fast!");
            };
            car1.Explored += delegate (object sender, CarEventArgs e)
            {
                aboutToBlowCounter++;
                Console.WriteLine("Fatal Message from Car: {0}",e.msg);
            };

                    
            for (int i = 0; i < 7; i++)
            {
                car1.Accelerate(20);
            }
        }

        

        private static void Car1_AboutToBlow1(object sender, CarEventArgs e)
        {
            if(sender is Car2 c)
            {
                Console.WriteLine("Critical message from {0}: {1}",c.PetName,e.msg);
            }
        }

        private static void CarIsAlmostDoomed(string msg)
        {
            Console.WriteLine("=> Critical Message from car: {0}", msg);
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
