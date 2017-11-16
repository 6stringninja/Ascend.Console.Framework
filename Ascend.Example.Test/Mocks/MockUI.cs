using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ascend.Example.UI;

namespace Ascend.Example.Test.Mocks
{
    public class MockUi : IUi
    {
         public char ReadPreset ;
        public void ReadKeyPreset(char c)
        {
            ReadPreset = c;
        }
        public char ReadKey(char testOveride = Char.MinValue)
        {
              if(testOveride == Char.MinValue && ReadPreset == Char.MinValue)
                throw new Exception("MockUI ReadKey was Not Faked");
            var ret = ReadPreset != Char.MinValue ? ReadPreset : testOveride;
            ReadPreset = Char.MinValue;
           return ret;
        }

        public void WriteLine(string format, params object[] arg)
        {
            Debug.WriteLine(format,arg);
        }

        public void Write(string format)
        {
            Debug.Write(format);
            
        }

        public string ReadLinPreset = String.Empty;
        public void ReadLinePreset(string c)
        {
            ReadLinPreset = c;
        }
        public string ReadLine(string testOveride)
        {
            if (testOveride ==  String.Empty && ReadLinPreset ==  String.Empty)
                throw new Exception("MockUI ReadLin was Not Faked");
            var ret = ReadLinPreset !=  String.Empty ? ReadLinPreset : testOveride;
            ReadLinPreset =  String.Empty;
            return ret;
        }

        public void Clear()
        {
           //not used
        }
    }
}
