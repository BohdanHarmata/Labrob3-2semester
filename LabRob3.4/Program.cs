using System;
using System.Threading.Tasks;
using System.Threading;

namespace LabRob3._4
{
    class Program
    {

        static void Go(object num)
        {
            int n = (int)num;
            if (n <= 0)
                return;
            Thread t = new Thread(Go);
            t.Name = "Thread" + n;
            t.Start(n - 1);
            Console.WriteLine(t.Name);
        }

        static void Main(string[] args)
        {
            Go(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
