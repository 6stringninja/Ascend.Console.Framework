using Ascend.Example.Models;

namespace Ascend.Example.Report
{
    public class SaleReport : ReportBase<ISaleReportModel>
    {
        public SaleReport(ReportDataBase<ISaleReportModel> reportItems) : base(reportItems)
        {
        }
    }
}