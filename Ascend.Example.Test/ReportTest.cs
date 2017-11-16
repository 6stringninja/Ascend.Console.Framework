using Ascend.Example.Report;
using Ascend.Example.Test.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Ascend.Example.Test
{
    [TestClass]
    public class ReportTest
    {

        public ReportTest()
        {
            Application.AppBase.UI = new MockUi();
        }

        public MockUi FakeUi => (MockUi)Application.AppBase.UI;
        [TestMethod]
        public void ReportTestRender()
        {


            var report = new MockReport(new MockReportData("MockReport"));
            report.Render();


        }
    }

    public class MockReportData : ReportDataBase<IMockReportModel>
    {
        public MockReportData(string reportName) : base(reportName)
        {
        }

        public override void ConfigureReportData(ref IList<string> fieldnames, ref IDictionary<string, string> columndisplays, ref IDictionary<string, string> reportcolumnformating)
        {
            reportcolumnformating.Add("SomeAmountDecimal", "{0:C2}");
            columndisplays.Add("SomeAmountDecimal","New ColmunName");

        }

        public override void GetReportData(ref IList<IMockReportModel> newData)
        {
            
            newData.Add(new MockReportModel() { SomeAmountDecimal = 2.0M, SomeString = "Some string" });
             

        }
    }
    public class MockReportModel : IMockReportModel
    {
        public decimal SomeAmountDecimal { get; set; }
        public string SomeString { get; set; }
    }
}
