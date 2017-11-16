using Ascend.Example.Models;
using Ascend.Example.Models.Bridge;
using Ascend.Example.Screen;
using Ascend.Example.UI;

namespace Ascend.Example.Application
{
    public abstract class AppBase : IApp
    {
        public static IUi UI { get; set; }

        public static IScreens AppScreens { get; set; }

        public static ISalesBridge<ISaleModel, ISaleReportModel> SaleDataBridge { get; set; }

        protected AppBase(IUi ui, IScreens screens, ISalesBridge<ISaleModel, ISaleReportModel>    bridge    )
        {
            UI = ui;
            Screens = screens;
            SaleDataBridge = bridge;
        }
        public IScreens Screens { get; set; }
        public abstract void Run();

    }
}