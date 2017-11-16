using Ascend.Example.MainApp.Screens;
using Ascend.Example.Models;
using Ascend.Example.Models.Bridge;
using Ascend.Example.Screen;
using Ascend.Example.UI;
 

namespace Ascend.Example.MainApp
{
    public class MainApp : Application.AppBase
    {
        private const int MainScreenIndex = 0;
        public MainApp(    IUi ui, IScreens screens, ISalesBridge<ISaleModel, ISaleReportModel> bridge) : base( ui, screens, bridge)
        {
            screens.Add((new ScreenMain()));
            screens.Add(new ScreenSaleReport());
            screens.Add(new ScreenSaleEntry());
            AppScreens = screens;
        }
        public override void Run() => Screens[MainScreenIndex].Start();
    }
}