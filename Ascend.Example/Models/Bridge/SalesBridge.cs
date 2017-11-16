using System.Collections.Generic;

namespace Ascend.Example.Models.Bridge
{
    public class SalesBridge : SalesBridgeBase<ISaleModel, ISaleReportModel>
    {
        public SalesBridge(ISalesBridge<ISaleModel, ISaleReportModel> bridge) : base(bridge) { }
        public override IList<ISaleReportModel> GetSaleReport() => Bridge.GetSaleReport();
        public override void InsertSale(ISaleModel item) => Bridge.InsertSale(item);
        public override SaleReportTaxRate GetStateTaxRate(string statecode, decimal defaultIfnotFound) => Bridge.GetStateTaxRate(statecode, defaultIfnotFound);
    }
}

