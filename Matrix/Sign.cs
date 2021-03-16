using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Sign
    {
        public static Random RandomGen = new Random();

        private char GetSign()
        {
            int t = RandomGen.Next(10);
            if (t <= 2)
                return (char)('0' + RandomGen.Next(10));
            else if (t <= 4)
                return (char)('a' + RandomGen.Next(27));
            else if (t <= 6)
                return (char)('A' + RandomGen.Next(27));
            else
                return (char)(RandomGen.Next(32, 255));
        }

        public void ShowWhiteSign(int left, int top)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(left, top);
            Console.Write(GetSign());
        }

        public void ShowGreenSign(int left, int top)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(left, top);
            Console.Write(GetSign());

            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ShowDarkGreenSign(int left, int top)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(left, top);
            Console.Write(GetSign());

            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ShowSpaceSign(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(' ');
        }
    }
}
