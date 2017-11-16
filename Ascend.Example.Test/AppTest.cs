using System;
using Ascend.Example.Test.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ascend.Example.Test
{
    [TestClass]
    public class AppTest
    {
        [TestMethod]
        public void AppRun()
        {
            var screen = new MockScreen();

            var app = new MockApp(new MockUi(), new MockScreens(),new MockBridge());

            app.Screens.Add((screen));

        }

        [TestMethod]
        public void AppNew()
        {
             
            var app = new MockApp(new MockUi(), new MockScreens(), new MockBridge());

            Assert.IsNotNull(app);
        }
    }
}
