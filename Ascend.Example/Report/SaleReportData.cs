using Ascend.Example.Models;
using System;
using System.Collections.Generic;

namespace Ascend.Example.Report
{
    public class SaleReportData : ReportDataBase<ISaleReportModel>
    {
        public SaleReportData(string reportName) : base(reportName) { }

        //public override void ConfigureReportData(ref IList<string> fieldnames, ref IList<string> columndisplays, ref IDictionary<string, string> reportcolumnformating)
        //{

        //}

        public override void GetReportData(ref IList<ISaleReportModel> newData)
        {
            if (newData == null) throw new ArgumentNullException(nameof(newData));
            newData = Application.AppBase.SaleDataBridge.GetSaleReport();
        }

        public override void ConfigureReportData(ref IList<string> fieldnames, ref IDictionary<string, string> columndisplays, ref IDictionary<string, string> reportcolumnformating)
        {
            reportcolumnformating.Add("EntryDate", "{0:G}");
            reportcolumnformating.Add("SaleAmount", "{0:C2}");
            reportcolumnformating.Add("TaxAmount", "{0:C2}");
            reportcolumnformating.Add("TotalSales", "{0:C2}");

            columndisplays.Add("EntryDate", "Entry Date");
            columndisplays.Add("SaleAmount", "Sale Amount");
            columndisplays.Add("TaxAmount", "Tax Amount");
            columndisplays.Add("TotalSales", "Total Sales");
        }
    }
}