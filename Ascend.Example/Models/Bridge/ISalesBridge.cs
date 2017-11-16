using System.Collections.Generic;

namespace Ascend.Example.Models.Bridge
{
    // Bridge Pattern
    public interface ISalesBridge<in TSale, TSaleReport>
    {
        void InsertSale(TSale item);
        IList<TSaleReport> GetSaleReport();
        SaleReportTaxRate GetStateTaxRate(string stateCode, decimal defaultTaxRateIfnotFound);
    }


}

