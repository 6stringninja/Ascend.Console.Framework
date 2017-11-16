using Ascend.Example.Screen.Menu;

namespace Ascend.Example.MainApp.Screens
{
    public class ScreenMain : Screen.Screen
    {
        public ScreenMain() : base(new MainMenus())
        {

        }

        // called from base class Start();
        // Set Menus here
        public override void Configure(ref IMenus menus)
        {
            menus.AddMenu('S', "Sale", true);
            menus.AddMenu('R', "Report", true);
            menus.AddMenu('Q', "Quit", true);
        }

        public override bool MenuSelected(IMenu menu)
        {
            switch (menu.ExecuteCharacter)
            {
                case 'S':
                    Application.AppBase.UI.Clear();
                    Application.AppBase.AppScreens[2].Start();
                    Application.AppBase.UI.Clear();
                    break;
                case 'R':
                    Application.AppBase.UI.Clear();
                    Application.AppBase.AppScreens[1].Start();
                    Application.AppBase.UI.Clear();
                    break;
                 

            }

            return menu.ExecuteCharacter != 'Q';
        }
        // Called in Start() from base 
        // Called After Configure C
        public override void Run()
        {
            do
            {

                Menus.DisplayMenus(false);
            } while (GetMenuSelection());

        }
    }
}