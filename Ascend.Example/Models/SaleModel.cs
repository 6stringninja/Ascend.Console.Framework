using System;

namespace Ascend.Example.Models
{
    /// Holds Sale Records From Sale Table
    public class SaleModel : ISaleModel
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public string StateCode { get; set; }
        public decimal SaleAmount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
    }

     


}

