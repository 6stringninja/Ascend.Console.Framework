using System.Configuration;
using Ascend.Example.Input;
using Ascend.Example.Models;
using Ascend.Example.Screen.Menu;

namespace Ascend.Example.MainApp.Screens
{
    public class ScreenSaleEntry : Screen.Screen
    {
        public ScreenSaleEntry() : base(new MainMenus())
        {

        }

        // called from base class Start();
        // Set Menus here
        public override void Configure(ref IMenus menus)
        {
            menus.AddMenu('M', "Main Menu", false);
            menus.AddMenu('S', "Add Sale", false);
        }

        public override bool MenuSelected(IMenu menu)
        {

            if (menu.ExecuteCharacter == 'S')
                Run();

            return menu.ExecuteCharacter != 'M';
        }
        public override void Run()

        {
            char returnToMain;
            do
            {
              
                Application.AppBase.UI.Clear();

                Application.AppBase.UI.WriteLine("Sale Entry");
                var sale = new SaleModel
                {
                    SaleAmount =
                        (new InputSaleAmount("Enter Sale Amount: example (#.##)", "Sale Amount was invalid"))
                        .GetValidEntry(),
                    StateCode =
                        (new InputStateCode("Enter State Code: example (XX)", "State Code was invalid"))
                        .GetValidEntry()
                };

                var defaultTaxRate = decimal.Parse(ConfigurationManager.AppSettings["DefaultTaxRate"]);
                var saleTaxRate = Application.AppBase.SaleDataBridge.GetStateTaxRate(sale.StateCode, defaultTaxRate);
                sale.TaxRate = saleTaxRate.TaxRate;
                if (saleTaxRate.IsDefault) Application.AppBase.UI.WriteLine("Tax rate NOT found using Default: {0:p}", saleTaxRate.TaxRate);
                else
                    Application.AppBase.UI.WriteLine("{0} Tax rate found.", sale.StateCode);

                sale.TaxAmount = sale.SaleAmount * sale.TaxRate;
                var totalAmount = sale.TaxAmount + sale.SaleAmount;
                Application.AppBase.UI.WriteLine("Sale Amount: {2:C2} Tax Rate: {0:p} Tax Amount: {1:C2} Total Amount: {3:C2}", sale.TaxRate, sale.TaxAmount,sale.SaleAmount, totalAmount);
                var saveSaleToDatabase = (new InputYesNo("Commit Sale?  (y/n) ", "")).GetValidEntry();
                if (saveSaleToDatabase == 'Y')
                {
                    Application.AppBase.SaleDataBridge.InsertSale(sale);
                }
                Application.AppBase.UI.WriteLine("");

                returnToMain = (new InputYesNo("Enter another Sale?  (y/n) ", "")).GetValidEntry();

            } while (returnToMain != 'N');

        }
    }
}