using System;
using System.Threading;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            SignsShower signsShower = new SignsShower();

            Console.Clear();
            Console.CursorVisible = false;

            int ms = 0;
            while (true)
            {
                DateTime timeMark = DateTime.Now;
                signsShower.SignShow();

                ms = 10 - (int)((TimeSpan)(DateTime.Now - timeMark)).TotalMilliseconds;
                if (ms > 0) Thread.Sleep(ms);
            }
        }
    }
}

