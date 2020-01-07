using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Delegate
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public partial class Delegation {
        public delegate bool FilterDelegate(Person p);

        public  void callTest()
        {
            Person p1 = new Person() { Name = "Join", Age = 14 };
            Person p2 = new Person() { Name = "Jane", Age = 69 };
            Person p3 = new Person() { Name = "Jake", Age = 12 };
            Person p4 = new Person() { Name = "Jessie", Age = 25 };
            //----------------------------
            // AgeDelegation invoke;
            //----------------------------
            //List<Person> people = new List<Person>() { p1, p2, p3, p4 };
            //DisplayPeople("Children:", people, Ischild);
            //DisplayPeople("Adults:", people, IsAdult);
            //DisplayPeople("Seniors:", people, IsSenior);
            //----------------------------
            // MathMethodDelegation invoke;
            //----------------------------           
            //double res1 = Delegation.Gauss3(Delegation.DMyfun1, 1,2,3);
            //double res2 = Delegation.Gauss3(Delegation.DMyfun2, 2,3,4);
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            //----------------------------
            // DictionaryDelegate invoke;
            //----------------------------         
            DoSomething("Prinf2");

        }
        /// <summary>
        /// A method to filter out the people you need
        /// </summary>
        /// <param name="people">A list of people</param>
        /// <param name="filter">A filter</param>
        /// <returns>A filtered list</returns>
        public static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (var p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0} - {1} year old", p.Name,p.Age);
                }
            }
        }
        #region Filter
        public static bool Ischild(Person p)
        {
            return p.Age < 18;
        }
        public static bool IsAdult(Person p)
        {
            return p.Age >=  18 && p.Age <= 65;
        }
        public static bool IsSenior(Person p)
        {
            return p.Age > 65;
        }
        #endregion

    }

}
