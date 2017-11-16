using System;

namespace Ascend.Example.Screen.Menu
{
    public class TestMenus  : Menus
    {
       
        public override bool AddMenu(char execChar, string displayMessage, bool isdisplayed)
        {
            IMenu menu = new TestMenu();
            return AddMenu(ref menu, execChar, displayMessage, isdisplayed);

        }
    }
}