using System.Collections.Generic;

namespace Ascend.Example.Models.Bridge
{
    public abstract class SalesBridgeBase<TSales, TSalesReport> : ISalesBridge<TSales, TSalesReport>
    {
        protected ISalesBridge<TSales, TSalesReport> Bridge { get; set; }
        protected SalesBridgeBase(ISalesBridge<TSales, TSalesReport> bridge)
        {
            this.Bridge = bridge;
        }
        public abstract IList<TSalesReport> GetSaleReport();
        public abstract void InsertSale(TSales item);
        public abstract SaleReportTaxRate GetStateTaxRate(string statecode, decimal defaultIfnotFound);

    }


}

