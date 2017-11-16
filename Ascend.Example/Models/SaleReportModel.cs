

namespace Ascend.Example.Models
{
    public class SaleReportModel : SaleModel, ISaleReportModel
    {
        public decimal TotalSales => SaleAmount + TaxAmount;
    }
}
