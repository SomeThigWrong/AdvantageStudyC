using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Collections.Specialized;

namespace AdvantageStudyingC.Collection
{
    public class ObservableCollection
    {
        public static void ExecuteObservableCollection()
        {       
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
            new Person{ FirstName = "Peter", LastName = "Murphy", Age = 52 },
            new Person{ FirstName = "Kevin", LastName = "Key", Age = 48 },
            };
            //Person person = new Person { FirstName = "Kevin2", LastName = "Ke2y", Age = 482 };
            //Console.WriteLine(person.ToString()); 
            people.CollectionChanged += people_Collectionchanged;

            people.RemoveAt(0);
            people.Add(new Person { FirstName = "Kevin2", LastName = "Ke2y", Age = 482 });
        }
        private static void people_Collectionchanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Action for this event: {0}", e.Action);
            if(e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here is the OLD items:");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here is the new items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
        }
    }


    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public Person()
        {

        }
        public Person(string firstName, string lastName, int age)
        {
            this.age = age;
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public string FirstName { get; set ; }
        public string LastName { get; set; }
        public int Age { get; set; }

        override
        public string ToString()
        {
            return string.Format("FirstName : {0}, LastName : {1}, Age : {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
