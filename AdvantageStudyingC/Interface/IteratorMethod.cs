using AdvantageStudyingC.DownUpCasting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Interface
{
    internal class Garage : IEnumerable
    {
         Car[] carArray = new Car[4];

       

        public Garage()
        {
            carArray[0] = new Car(VehicleColor.Back, 200);
            carArray[1] = new Car(VehicleColor.Back, 10);
            carArray[2] = new Car(VehicleColor.Back, 200);
            carArray[3] = new Car(VehicleColor.Back, 200);
        }

        public IEnumerator GetEnumerator()
        {
            return actualImplementation();
            throw new Exception("This won't get called");
            
            IEnumerator actualImplementation()
            {
               
                foreach (var car in carArray)
                {
                    yield return car;
                }
            }
        }
    }
    public class ExecuteInterfaceIterator
    {
        public static void start()
        {
            Garage garage = new Garage();
            IEnumerator i = garage.GetEnumerator();
            i.MoveNext();
            Car car = (Car)i.Current;
            Console.WriteLine(car.CurrentSpeed);


        }
    }
}
