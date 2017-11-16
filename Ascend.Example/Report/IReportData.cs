using System.Collections.Generic;

namespace Ascend.Example.Report
{
    public interface IReportData<T>
    {
        string ReportName { get; set; }
        IList<T> ReportItems { get; set; }
        IList<string> ReportDataFieldNames { get; set; }
        IDictionary<string, string> ReportColumnDisplays { get; set; }
        void IntializeReport();
        void ConfigureReportData(ref IList<string> columns, ref IDictionary<string, string> display, ref IDictionary<string, string> formating);
        void GetReportData(ref IList<T> newData);
    }
}