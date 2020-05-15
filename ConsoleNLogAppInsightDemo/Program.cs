using System;

namespace ConsoleNLogAppInsightDemo
{
    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            try
            {
                //Test Log
                Logger.Info("Hello world");
                Logger.Trace("This should go to App insight");
                Logger.Warn("Wow!! This is a warning message");
                System.Console.ReadKey();
                int i = 10;

                Console.WriteLine(i / 0);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Hmm! Something is not right.");
            }
        }
    }
}
