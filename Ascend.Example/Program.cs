using System;
using Ascend.Example.MainApp;
using Ascend.Example.Models;
using Ascend.Example.Models.Bridge;
using Ascend.Example.UI;

namespace Ascend.Example
{
    class Program
    {
        static void Main()
        {
            System.AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;

            (new MainApp.MainApp(new ConsoleUi(), new MainScreens(), new SaleAdoDataBridge())).Run();
        }

        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
