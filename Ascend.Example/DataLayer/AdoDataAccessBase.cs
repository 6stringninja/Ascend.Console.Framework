using System.Configuration;
using System.Data.SqlClient;

namespace Ascend.Example.DataLayer
{
    public abstract class AdoDataAccessBase
    {
        const string SqlConfigKey = "Ascend.Database";
        public string ConnectionString { get; set; }
        protected AdoDataAccessBase(string sqlconfigkey) { GetConnectionString(sqlconfigkey); }
        protected AdoDataAccessBase() { GetConnectionString(SqlConfigKey); }
        void GetConnectionString(string sqlconfigkey) => ConnectionString = ConfigurationManager.ConnectionStrings[sqlconfigkey].ConnectionString;
        public SqlConnection GetConnection() => new SqlConnection(ConnectionString);
        public SqlCommand GetCommand(string proc) => new SqlCommand(proc, GetConnection());
    }
}
