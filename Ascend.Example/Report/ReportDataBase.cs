using System.Collections.Generic;
using System.Linq;

namespace Ascend.Example.Report
{
    public abstract class ReportDataBase<T> : IReportData<T>
    {
        public string ReportName { get; set; }
        public IList<T> ReportItems { get; set; }
        public IList<string> ReportDataFieldNames { get; set; }
        public IDictionary<string, string> ReportColumnDisplays { get; set; }
        public IDictionary<string, string> ReportFieldFormats { get; set; }
        protected ReportDataBase(string reportName)
        {
            ReportName = reportName;
            IntializeReport();
        }
        public void IntializeReport()
        {
            IList<string> reportDataFieldNames = typeof(T).GetProperties().Select(a => a.Name).ToList();
            IDictionary<string, string> reportColumnDisplayDefaults = new Dictionary<string, string>();
            //reportDataFieldNames.ToList();
            IDictionary<string, string> reportFieldFormats = new Dictionary<string, string>();
            ConfigureReportData(ref reportDataFieldNames, ref reportColumnDisplayDefaults, ref reportFieldFormats);
            ReportDataFieldNames = reportDataFieldNames;
            ReportColumnDisplays = reportColumnDisplayDefaults;
            ReportFieldFormats = reportFieldFormats;
        }
        public abstract void ConfigureReportData(ref IList<string> fieldnames, ref IDictionary<string, string> columndisplays, ref IDictionary<string, string> reportcolumnformating);

        public abstract void GetReportData(ref IList<T> newData);



    }
}