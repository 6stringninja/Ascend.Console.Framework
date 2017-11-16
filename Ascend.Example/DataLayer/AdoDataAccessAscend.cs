using System.Data;
using System.Data.SqlClient;

namespace Ascend.Example.DataLayer
{
    public class AdoDataAccessAscend : AdoDataAccessBase
    {
        public AdoDataAccessAscend(string sqlconfigkey) : base(sqlconfigkey){}
        public DataSet SaleReport()
        {
            using (var command = GetCommand("spSaleReport"))
            {
                command.Connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                var adapter = new SqlDataAdapter(command);
                var data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
        public void SaleInsert(string statecode, decimal saleamount, decimal taxrate)
        {
            using (var command = GetCommand("spSaleInsert"))
            {
                command.Connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StateCode", statecode);
                command.Parameters.AddWithValue("@SaleAmount", saleamount);
                command.Parameters.AddWithValue("@TaxRate", taxrate);
                command.ExecuteNonQuery();
            }
        }
     
     
        public DataSet GetStateTaxRate(string statecode, decimal defaultIfNotFound)
        {
            using (var command = GetCommand("spGetStateTaxRate"))
            {
                command.Connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@statecode", statecode);
                command.Parameters.AddWithValue("@defaultTaxRate", defaultIfNotFound);               
                var adapter = new SqlDataAdapter(command);
                var data = new DataSet();  
                adapter.Fill(data);
                return data;

            }
        }


    }
}