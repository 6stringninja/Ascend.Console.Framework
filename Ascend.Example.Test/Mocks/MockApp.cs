using Ascend.Example.Models;
using Ascend.Example.Models.Bridge;
using Ascend.Example.Screen;
using Ascend.Example.UI;


namespace Ascend.Example.Test.Mocks
{
    public class MockApp : Application.AppBase
    {


        public MockApp(IUi ui, IScreens screens, ISalesBridge<ISaleModel, ISaleReportModel> bridge) : base(ui, screens, bridge)
        {
        }

        public override void Run()
        {
            Screens[0].Start();

        }
    }
}
