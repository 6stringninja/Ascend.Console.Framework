using Ascend.Example.Screen.Menu;
using System;

namespace Ascend.Example.Screen
{
    public class TestScreen : Screen
    {
        public TestScreen() : base(new TestMenus())
        {

        }

        public override void Configure(ref IMenus menus)
        {
            menus.AddMenu('A', "A Message", true);
            menus.AddMenu('B', "B Message", true);
            menus.AddMenu('Q', "Quit", true);
        }

        public override bool MenuSelected(IMenu menu)
        {
            App.App.UI.WriteLine("Detected '{0}' menu: {1}  was selected", menu.ExecuteCharacter, menu.DisplayMessage);
            return menu.ExecuteCharacter != 'Q';
        }

        public override void Run()
        {
            do
            {

                Menus.DisplayMenus(false);
            } while (GetMenuSelection());

        }
    }
}