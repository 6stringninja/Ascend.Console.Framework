using System;
using System.Linq;

namespace Ascend.Example
{
    public class KeyMenuCommand
    {
        public char Key { get; set; }
        public string Menu { get; set; }

        public App MyApp { get; set; }
        public Func<int> Method { get; set; }

        public KeyMenuCommand(char key, string menu, Func<int> method)
        {
            Key = key;
            Menu = menu;
            Method = method;
        }
        public KeyMenuCommand(char key, string menu, App app)
        {
            Key = key;
            Menu = menu;
            MyApp = app;
        }




    }

    public class ConsoleUtilities
    {
        public static char ReadValidKey(params char[] validkeys)
        {
            while (true)
            {
                var key = Console.ReadKey().KeyChar;
                if (validkeys.Contains((key))) return key;
            }
        }


        public static void DisplayMenu(params string[] menus)
        {

            foreach (var item in menus.ToList())
            {
                Console.WriteLine(item);

            }

        }
    }
}
