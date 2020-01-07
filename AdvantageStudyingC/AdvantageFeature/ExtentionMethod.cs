using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AdvantageStudyingC.AdvantageFeature
{
    public static class ExtentionMethod
    {
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here: => {1}\n0",obj.GetType().Name,Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }
        public static int ReverseDigits(this int i)
        {
            char[] digit = i.ToString().ToCharArray();
            Array.Reverse(digit);
            string newDigits = new string(digit);
            return int.Parse(newDigits);
        }
    }

    public static class AnnoyingExtension
    {
        public static void PrintDataAndBeep(this System.Collections.IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
                Console.Beep();
            }
        }
    }







    public class ExtentionMethodMain
    {
        public static void Execute()
        {
            //int c = 1;
            //c.DisplayDefiningAssembly();
            //System.Data.DataSet d = new System.Data.DataSet();
            //d.DisplayDefiningAssembly();
            //int b = 343512;
            //Console.WriteLine(b.ReverseDigits());
            string[] data = new string[] { "Wow", "this", "is", "sort", "of", "annoying","but", "in", "a", "weird", "way", "fun!" };
            data.PrintDataAndBeep();
        }
    }




}

