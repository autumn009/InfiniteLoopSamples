using System;
using System.Threading;

namespace Wait
{
    class Program
    {
        static void Main()
        {
            var evt = new AutoResetEvent(false);
            Console.WriteLine("Start to wait");
            evt.WaitOne();
            Console.WriteLine("Done to wait");
        }
    }
}
