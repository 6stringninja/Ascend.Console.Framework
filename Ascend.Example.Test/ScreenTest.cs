using System;
using Ascend.Example.Screen;
using Ascend.Example.Screen.Menu;
using Ascend.Example.Test.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ascend.Example.Test
{
    [TestClass]
    public class ScreenTest
    {
        public ScreenTest()
        {
            Application.AppBase.UI = new MockUi();
        }
        public MockUi FakeUi => (MockUi) Application.AppBase.UI;

        [TestMethod]
        public void ScreensAddScreenStart()
        {
            var screens = new MockScreens();
            var screen = new MockScreen();
            FakeUi.ReadKeyPreset('Q');
            screen.Start();
             Assert.IsTrue(true);
        }

        [TestMethod]
        public void ScreensAddScreenRunMenu()
        {
            var screens = new MockScreens();
            var screen = new MockScreen();
            FakeUi.ReadKeyPreset('A');
            screen.Menus.AddMenu('A', "Test message", true);
           Assert.IsTrue( screen.GetMenuSelection());
             
        }

        [TestMethod]
        public void ScreensAddScreenAddMenu()
        {
            var screens = new MockScreens();
            var screen = new MockScreen();
            screen.Menus.AddMenu('A', "Test message", true);
             
            screens.Add(screen);
            Assert.IsTrue(screens.Count == 1);
        }
        [TestMethod]
        public void ScreensAddScreen()
        {
            var screens = new MockScreens();
          
            screens.Add(new MockScreen());
            Assert.IsTrue(screens.Count == 1);
        }
        [TestMethod]
        public void ScreensCreate()
        {
            var screens = new MockScreens();
            Assert.IsTrue(screens.Count ==0);
            
        }
        [TestMethod]
        public void ScreenCreate()
        {
            var screen = new MockScreen();
            Assert.IsNotNull((screen));
        }
    }
    
}
