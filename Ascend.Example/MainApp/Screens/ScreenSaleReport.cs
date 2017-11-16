using Ascend.Example.Models;
using Ascend.Example.Report;
using Ascend.Example.Screen.Menu;

namespace Ascend.Example.MainApp.Screens
{
    public class ScreenSaleReport : Screen.Screen
    {
        public IReportData<ISaleReportModel> SaleReportData => new SaleReportData("Sales");
        public ScreenSaleReport() : base(new MainMenus())
        {

        }

        public override void Configure(ref IMenus menus)
        {

            menus.AddMenu('M', "Main Menu", false);
        }

        public override bool MenuSelected(IMenu menu)
        {
            Application.AppBase.UI.WriteLine("Detected '{0}' menu: {1}  was selected", menu.ExecuteCharacter, menu.DisplayMessage);
            return menu.ExecuteCharacter != 'M';
        }
        public override void Run()
        {
            do
            {
                var sl = new SaleReport(new SaleReportData("Sale Report"));
                sl.Render();  
                Menus.GetMenu('M').Print();
            } while (GetMenuSelection());

        }
    }
}