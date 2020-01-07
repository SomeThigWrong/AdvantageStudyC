using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.AdvantageFeature
{
    public class Person
    {
        public string Name { get; set; }
        private Person[] _BackStore;
        public Person this[int index]
        {
            get
            {
                return _BackStore[index];
            }
            set
            {
                _BackStore[index] = value;
            }
        }
    }

    public class MutipleDimentionArr
    {
        int[,] my2dArr = new int[10,10];
        public int this[int row, int column]
        {
            get
            {
                return my2dArr[row, column];
            }
        }
    }

    public interface IStringContainer
    {
        string this[int index] { get;set; }
    }
    public class SomeClass : IStringContainer
    {
        private List<string> list = new List<string>();
        public string this[int index] { get => list[index]; set => list.Insert(index, value); }
    }
}
