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
        string ConnctionString = @"Server=tcp:prjsenac.database.windows.net,1433;Initial Catalog=AtvBD;Persist Security Info=False;User ID=adm;Password=P@ssw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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
