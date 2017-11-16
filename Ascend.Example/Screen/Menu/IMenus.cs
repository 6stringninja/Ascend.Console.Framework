using System.Collections.Generic;

namespace Ascend.Example.Screen.Menu
{
    public interface IMenus : IDictionary<char, IMenu>
    {
        bool AddMenu(char execChar, string displayMessage, bool isdisplayed);
        IMenu GetMenu(char execChar);
        void DisplayMenus(bool clearFirst);
        IMenu GetMenuSelection();

    }
}