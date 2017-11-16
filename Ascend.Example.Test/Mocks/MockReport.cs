using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ascend.Example.Models;
using Ascend.Example.Report;

namespace Ascend.Example.Test.Mocks
{
    public class MockReport : ReportBase<IMockReportModel>
    {
        public MockReport(ReportDataBase<IMockReportModel> reportItems) : base(reportItems)
        {
        }
    }


    public interface IMockReportModel
    {
          decimal SomeAmountDecimal { get; set; }
          string SomeString { get; set; } 

    }
    public class  MockReportModel : IMockReportModel
    {
        public decimal SomeAmountDecimal { get; set; }
        public string SomeString { get; set; }
    }
}

 
