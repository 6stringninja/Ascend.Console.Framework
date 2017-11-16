using System;

namespace Ascend.Example.Models
{
    public interface ISaleModel
    {
        DateTime EntryDate { get; set; }
        int Id { get; set; }
        decimal SaleAmount { get; set; }
        string StateCode { get; set; }
        decimal TaxAmount { get; set; }
        decimal TaxRate { get; set; }
    }
}