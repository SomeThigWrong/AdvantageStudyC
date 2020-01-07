using System;
using System.Collections.Generic;
using System.Text;

namespace AdvantageStudyingC.Delegate
{
    public class DeligateAction
    {
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;
            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }
            Console.ForegroundColor = previous;
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }


        public static void ExecuteDeligateAction()
        {
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);
            Func<int, int, int> functionTarget = new Func<int, int, int>(Add);
            int result = functionTarget.Invoke(40, 40);

            Func<int, int, string> functionTarget2 = new Func<int, int, string>(SumToString);
            string result2 = functionTarget2(90, 300);
            Console.WriteLine(result2);
            Console.WriteLine(result);
        }

    }
}
