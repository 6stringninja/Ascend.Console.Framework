using Ascend.Example.DataLayer;
using Ascend.Example.Models;
using Ascend.Example.Test.Mocks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ascend.Example.Models.Bridge;

namespace Ascend.Example.Test
{
    [TestClass]
    public class SqlTest
    {
        [TestMethod]
        public void SaleEfBridgeSaleInsert()
        {
            var bridge = new SaleAdoDataBridge();

            var recordcount = bridge.GetSaleReport().Count;
            bridge.InsertSale(new SaleModel { EntryDate = DateTime.UtcNow, SaleAmount = 10.00M, StateCode = "WI" });
            var recordcount2 = bridge.GetSaleReport().Count;  
            Assert.IsTrue((recordcount2 - recordcount) == 1);

        }
        [TestMethod]
        public void SaleEfBridgeSales()
        {
            var bridge = new SaleAdoDataBridge();
            var results = bridge.GetSaleReport();
            var t = results;
        }
        [TestMethod]
        public void MockBridgeSaleInsert()
        {
            var bridge = new MockBridge();
            bridge.InsertSale(new SaleModel { EntryDate = DateTime.UtcNow, SaleAmount = 10.00M, StateCode = "WI" });
            bridge.InsertSale(new SaleModel { EntryDate = DateTime.UtcNow, SaleAmount = 10.00M, StateCode = "WI" });
            var recordcount2 = ((MockBridge)bridge).FakeSales.Count;
            Assert.IsTrue((recordcount2) == 2);

        }
        [TestMethod]
        public void MockBridgeSales()
        {
            var bridge = new MockBridge();

            var results = bridge.GetSaleReport();
            Assert.IsTrue(results.Count > 0);
            var t = results;

        }
        [TestMethod]
        public void SaleInserttProc()
        {
            var dr = (new AdoDataAccessAscend("Ascend.Database"));
            var recordcount = dr.SaleReport().Tables[0].Rows.Count;
            (new AdoDataAccessAscend("Ascend.Database")).SaleInsert("WI", 1.00M, 0.05M);
            var recordcount2 = dr.SaleReport().Tables[0].Rows.Count;
            Assert.IsTrue((recordcount2 - recordcount) == 1);
        }
        [TestMethod]
        public void SaleReportProc()
        {
            var dr = (new AdoDataAccessAscend("Ascend.Database")).SaleReport();
            var ads = dr;
        }
    }
}
