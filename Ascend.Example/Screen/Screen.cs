using Ascend.Example.Screen.Menu;

namespace Ascend.Example.Screen
{
    public abstract class Screen : IScreen
    {
        private IMenus _menus;
        public IMenus Menus
        {
            get { return _menus; }
            set { _menus = value; }
        }

        protected Screen( IMenus menus)
        {
            _menus = menus;
        }
      

        public bool GetMenuSelection() => MenuSelected(Menus.GetMenuSelection());

 

        public void Start()
        {
          
            Configure(ref _menus);
            Run();
        }
        public abstract bool MenuSelected(IMenu menu);
        public abstract void Configure(ref IMenus menus);
        public abstract void Run();

    }
}