using System;

namespace Ascend.Example.UI
{
    public class ConsoleUi:IUi
    {
        public char ReadKey(char testOveride)
        {
            return Console.ReadKey().KeyChar;
        }

        public void WriteLine(string format, params object[] arg)
        {
            Console.WriteLine(format,arg);
           
        }

        public void Write(string format)
        {
            Console.Write(format);
             
        }
        
        public string ReadLine(string testOveride)
        {
            return Console.ReadLine();
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}