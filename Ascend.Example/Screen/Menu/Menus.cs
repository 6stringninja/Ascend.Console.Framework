using System;
using System.Collections.Generic;
using System.Linq;

namespace Ascend.Example.Screen.Menu
{
    public abstract class Menus : Dictionary<char, IMenu>, IMenus
    {
        public abstract bool AddMenu(char execChar, string displayMessage, bool isdisplayed);
        public bool AddMenu(ref IMenu menu, char execChar, string displayMessage, bool isdisplayed)
        {
            if (!ContainsKey(execChar))
            {
                menu.DisplayMessage = displayMessage;
                menu.ExecuteCharacter = execChar;
                menu.Display = isdisplayed;

                Add(execChar, menu);
                return true;
            }
            return false;

        }

        public IMenu GetMenu(char execChar) => this.ContainsKey(execChar) ? this[execChar] : null;

        public void DisplayMenus(bool clearFirst)
        {
            ClearConsole(clearFirst);

            this.Values.ToList().ForEach(i =>
            {
                if (i.Display) Application.AppBase.UI.WriteLine("'{0}' {1}'", i.ExecuteCharacter, i.DisplayMessage);
            });
        }

        private void ClearConsole(bool clearFirst)
        {
            if (clearFirst)
            {
                Console.Clear();
            }
        }


        public IMenu GetMenuSelection()
        {
             
           
            if (this.Count == 0)
                return null;
              
           
            while(true)
            {
                var returnMenu = Application.AppBase.UI.ReadKey(Char.MinValue);
                if (this.ContainsKey(returnMenu)) return this[returnMenu];
            }  

             
        }
    }


}