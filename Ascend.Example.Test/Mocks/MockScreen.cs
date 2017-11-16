using Ascend.Example.Screen.Menu;
using System;

namespace Ascend.Example.Test.Mocks
{
    class MockScreen : Screen.Screen
    {
        public MockScreen() : base(new MockMenus())
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
            Application.AppBase.UI.WriteLine("Detected '{0}' menu: {1}  was selected", menu.ExecuteCharacter, menu.DisplayMessage);
            return menu.ExecuteCharacter != 'Q';
        }

        public override void Run()
        {
            var exitAfter = 10;
            do
            {
                if (--exitAfter == 0)
                    throw new Exception("Mock Screen Run infinitie loop");
                if (((MockUi)(Application.AppBase.UI)).ReadPreset == char.MinValue)
                    ((MockUi)(Application.AppBase.UI)).ReadKeyPreset('Q');
                Menus.DisplayMenus(false);
            } while (GetMenuSelection());

        }

    }
}
