using Ascend.Example.Models;
using System;
using System.Collections.Generic;
using Ascend.Example.Models.Bridge;


namespace Ascend.Example.Test.Mocks
{
    public class MockBridge : ISalesBridge<ISaleModel, ISaleReportModel>
    {
        public List<ISaleModel> FakeSales { get; set; } = new List<ISaleModel>();

        public void InsertSale(ISaleModel item)
        {

            FakeSales.Add(item);

        }

        public IList<ISaleReportModel> GetSaleReport()
        {
            var fakeSalesReport = new List<ISaleReportModel>();
            var item = new SaleReportModel
            {
                EntryDate = DateTime.UtcNow,
                SaleAmount = 10.0M,
                StateCode = "WI",
                TaxRate = 0.04M
            };
            fakeSalesReport.Add(item);
            return fakeSalesReport;
        }

        public SaleReportTaxRate GetStateTaxRate(string stateCode, decimal defaultIfnotFound)
        {
            return new SaleReportTaxRate();
        }
    }
}
