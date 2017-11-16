using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ascend.Example.Screen.Menu;
using Ascend.Example.Test.Mocks;
using Ascend.Example.UI;

namespace Ascend.Example.Test
{
    [TestClass]
    public class MenuTest
    {

        [TestMethod]
        public void MenuDisplay()
        {
            var menu = new MockMenus();

            menu.AddMenu('A', "a display", true);
            Application.AppBase.UI = new MockUi();
            menu.DisplayMenus(false);
            Assert.IsTrue(true);
            
        }
        [TestMethod]
        public void MenuCreateMenusGet()
        {
            var menu = new MockMenus();
            
            menu.AddMenu('A', "a display", true);

            Assert.IsNotNull(menu.GetMenu('A'));
            Assert.IsNull(menu.GetMenu('B'));
        }
        [TestMethod]
        public void MenuCreateMenusAdd()
        {
            var menu = new MockMenus();
            menu.AddMenu('A', "a display", true);
            Assert.IsTrue(menu.Count==1);

        }

        [TestMethod]
        public void MenuCreateMenus()
        {
            var menu = new MockMenus();
            Assert.IsNotNull(menu);

        }
        [TestMethod]
        public void MenuCreate()
        {
            var menu = new MockMenu();
            Assert.IsNotNull(menu);

        }
    }
}
