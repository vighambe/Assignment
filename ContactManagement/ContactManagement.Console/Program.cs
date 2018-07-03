using ContactManagement.Lib;
using System;

namespace ContactManagement.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Logger log = Logger.GetLoggerObject(@"c:\test.txt", @"c:\error.txt");
            log.WriteLog("Test Log");
            log.WriteError("Test error log");
            Console.Read();
        }
    }
}
