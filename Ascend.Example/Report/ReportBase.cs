using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ascend.Example.Report
{
    public abstract class ReportBase<T> : IReport<T>
    {
        public ReportDataBase<T> ReportItems { get; set; }

        protected ReportBase(ReportDataBase<T> reportItems)
        {
            ReportItems = reportItems;
        }
        public object GetPropValue(object target, string propName)
        {
            return target.GetType().GetProperty(propName).GetValue(target, null);
        }
        public void Render()
        {
            Application.AppBase.UI.WriteLine(ReportItems.ReportName);
            var sb = new StringBuilder();
            foreach (var column in ReportItems.ReportDataFieldNames)
            {
                var columnname = column;
                if (ReportItems.ReportColumnDisplays.ContainsKey( column )) columnname = ReportItems.ReportColumnDisplays[column];

                sb.AppendFormat("{0}\t", columnname);
            }

            Application.AppBase.UI.WriteLine(sb.ToString());
            sb.Clear();
            IList<T> newiList = new List<T>();
            ReportItems.GetReportData(ref newiList);
            ReportItems.ReportItems = newiList;
            var props = typeof(T).GetProperties();
            foreach (var item in ReportItems.ReportItems)
            {
                // { 0:C2}
                foreach (var test in props.ToList())
                {

                    var ovalue = GetPropValue(item, test.Name);
                    if (ReportItems.ReportFieldFormats.ContainsKey(test.Name))
                        sb.AppendFormat(ReportItems.ReportFieldFormats[(test.Name)] + "\t", ovalue);

                    else
                    {
                        sb.AppendFormat("{0}\t", ovalue);

                    }
                }
                Application.AppBase.UI.WriteLine(sb.ToString());
                sb.Clear();
            }

        }
    }
}
