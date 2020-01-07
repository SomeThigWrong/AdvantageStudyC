using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Delegate
{
    public class SendingObjectState
    {
        public static void SendingObjectStateExecute()
        {
            Car car1 = new Car("SlugBug",100,10);
            car1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));


            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            car1.RegisterWithCarEngine(handler2);
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                car1.Accelerate(20);              
            }

            car1.UnRegisterWithCarEngine(handler2);
            car1.CurrentSpeed = 10;
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                car1.Accelerate(20);
            }
            car1.RegisterWithCarEngine(CallMeHere);

        }
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=>{0}",msg);
            Console.WriteLine("***********************************\n");
        }
        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=>{0}", msg.ToUpper());
            Console.WriteLine("***********************************\n");
        }


        public static void SendingObjectStateExecute2()
        {
            Car c1 = new Car();
            
        }
        static void CallMeHere(string msg)
        {
            Console.WriteLine("=> Message from Car:{0}",msg);
        }
    }

    internal class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        private bool carIsDead;
        public Car()
        {

        }
        public Car(string name,int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }
        public delegate void CarEngineHandler(string msgForCaller);
        private CarEngineHandler listOfHandlers;
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall;
        }
        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }


        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (listOfHandlers != null) 
                {
                    listOfHandlers("Sorry, this car is dead ...");
                }
               
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Carefully buddy! gonna blow!");
                }
                if (CurrentSpeed > MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine("current speed = {0}", CurrentSpeed);
                }
            }

           
          
        }
    }
}
