using System;

namespace Ascend.Example.Models
{
    public interface ISaleReportModel : ISaleModel
    {
        new DateTime EntryDate { get; set; }
        new decimal SaleAmount { get; set; }
        new string StateCode { get; set; }
        new decimal TaxAmount { get; set; }
        decimal TotalSales { get; }
    }
}