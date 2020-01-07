using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.LamdaExpression
{
    public class TraditionalDelegateSyntax
    {
        public static void execute()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10,11});
            Predicate<int> callback = IsEvenNumber;
            List<int> eventNum =  list.FindAll( i => {
                Console.WriteLine("value of current index: {0}",i);
                return i % 2 == 0;
            });
            foreach (var item in eventNum)
            {
                Console.WriteLine(item);
            }
        }

        static bool IsEvenNumber(int i)
        {
            return i % 2 == 0;
        }
    }
}
