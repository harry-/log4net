using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using log4net.Util;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.xml", Watch = true)]

class ConsoleExample
{
      private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
      //private static log4net.ILog log = log4net.LogManager.GetLogger("loog");
    static void Main(string[] args)
    {
        Console.WriteLine("hello");
            // log4net.ILog log = log4net.LogManager.GetLogger("loggername");

        log.Debug("fjdskl");
        if(args.Length >0)
            Console.WriteLine(args[0]);

        System.Diagnostics.Debug.WriteLine("from sysdiag");

        log.Error("error messafage");
        Console.ReadLine();
    }
}
    