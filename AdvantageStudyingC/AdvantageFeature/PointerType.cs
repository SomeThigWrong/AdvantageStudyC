using System;
using System.Collections.Generic;
using System.Text;
//using System.Text.Json;

namespace AdvantageStudyingC.AdvantageFeature
{
    public class PointerType
    {
        public unsafe static void Execute()
        {
            unsafe{
                int myInt = 10;
                SquareIntPointer(&myInt);
            }
            int myInt2 = 5;
            SquareIntPointer(&myInt2);
            Console.WriteLine(myInt2); ;
            Point2 p1;
            p1.x = 1;
            //Point2* p1;
            //p1.
            

        }
        static unsafe void SquareIntPointer(int* myIntPointer)
        {
            *myIntPointer *= *myIntPointer;
        }
    }
    struct Point2
    {
       
        public int x;
        public int y;
      
        public override string ToString()
        {
            return $"({y},{y})";
        }
    }

}
