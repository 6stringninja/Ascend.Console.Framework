using Ascend.Example.Test.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ascend.Example.Test
{
    [TestClass]
    public class InputTest
    {
        public InputTest()
        {
            Application.AppBase.UI = new MockUi();
        }

        public MockUi FakeUi => (MockUi) Application.AppBase.UI;
        [TestMethod]
        public void InputStringTest()
        {
            var input = new MockInput("test prompt", "test message");
            FakeUi.ReadLinPreset = "test";
            var t = input.GetValidEntry();

            Assert.IsTrue(t=="test");

        }
    }
}
