using Ascend.Example.Screen.Menu;

namespace Ascend.Example.Test.Mocks
{
    public class MockMenus : Menus
    {

        public override bool AddMenu(char execChar, string displayMessage, bool isdisplayed)
        {
            IMenu menu = new MockMenu();
            return AddMenu(ref menu, execChar, displayMessage, isdisplayed);

        }
    }
}