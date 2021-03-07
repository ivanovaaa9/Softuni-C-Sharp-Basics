using System;
using System.Diagnostics;

namespace turnPcOff
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("shutdown", "/s /t 0");
        }
    }
}
