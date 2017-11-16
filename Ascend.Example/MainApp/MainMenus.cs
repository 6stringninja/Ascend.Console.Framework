using Ascend.Example.Screen.Menu;

namespace Ascend.Example.MainApp
{
    public class MainMenus : Menus
    {

        public override bool AddMenu(char execChar, string displayMessage, bool isdisplayed)
        {
            IMenu menu = new MainMenu();
            return AddMenu(ref menu, execChar, displayMessage, isdisplayed);

        }
    }
}