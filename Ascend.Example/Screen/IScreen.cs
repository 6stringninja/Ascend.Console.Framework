using Ascend.Example.Screen.Menu;

namespace Ascend.Example.Screen
{
    public interface IScreen
    {
        IMenus Menus { get; set; }

        bool GetMenuSelection();

        bool MenuSelected(IMenu menu);
        void Configure(ref IMenus menus);
        void Start();
        void Run();
    }
}
