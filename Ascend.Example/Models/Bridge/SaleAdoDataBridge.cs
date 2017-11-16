using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Ascend.Example.DataLayer;

namespace Ascend.Example.Models.Bridge
{
    public class SaleReportTaxRate
    {
        public bool IsDefault { get; set; }
        public decimal TaxRate { get; set; }
    }
public class SaleAdoDataBridge : ISalesBridge<ISaleModel, ISaleReportModel>
    {
        const string ConnectionString = "Ascend.Database";
        const string TaxRateColumn = "TaxRate";
        private const string IsDefaultColumn = "IsDefault";

        AdoDataAccessAscend dataAccess => new AdoDataAccessAscend(ConnectionString);

        public IList<ISaleReportModel> GetSaleReport() => SaleReportFromDataTable();

         List<ISaleReportModel> SaleReportFromDataTable()
        {
            var results = dataAccess.SaleReport().Tables[0].Rows;
            return (from DataRow item in dataAccess.SaleReport().Tables[0].Rows
                    select new SaleReportModel
                    {
                        EntryDate = DateTime.Parse(item["Entry Date"].ToString()),
                        StateCode = item["State Code"].ToString(),
                        TaxAmount = (decimal)item["Tax Amount"],
                        SaleAmount = decimal.Parse(item["Sale Amount"].ToString())
                    }).Cast<ISaleReportModel>().ToList();
        }

        public void InsertSale(ISaleModel item) => dataAccess.SaleInsert(item.StateCode, item.SaleAmount, item.TaxRate);

        public SaleReportTaxRate GetStateTaxRate(string statecode, decimal defaultIfnotFound)
        {
            var dataSet = dataAccess.GetStateTaxRate(statecode, defaultIfnotFound);
            var taxRate = new SaleReportTaxRate 
            {
                TaxRate = DataSetToDecimal(dataSet, TaxRateColumn),
                IsDefault = DataSetToBool(dataSet, IsDefaultColumn)
            };
            return taxRate;
        }

        private static decimal DataSetToDecimal(DataSet data, string columName) => (decimal)data.Tables[0].Rows[0][columName];
        private static bool DataSetToBool(DataSet data, string columName) => (bool) data.Tables[0].Rows[0][columName];
    }

  
}