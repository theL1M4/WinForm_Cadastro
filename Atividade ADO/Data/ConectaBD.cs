using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Atividade_ADO.Data
{
    internal class ConectaBD
    {
        string ConnctionString = @"Data Source=JUN0675589W10-1\BDSENAC;" +
            "Initial Catalog=AtvBD;" +
            "User ID=senaclivre;" +
            "Password='senaclivre'";
        public SqlConnection SqlConn()
        {
            SqlConnection sqlConn = new SqlConnection(ConnctionString);
            return sqlConn;
        }
        
        public void AbreBanco()
        {
            var sqlConn = SqlConn();
            sqlConn.Open();
            if (sqlConn.State == System.Data.ConnectionState.Closed)
            {

            }
        }
    }
}
