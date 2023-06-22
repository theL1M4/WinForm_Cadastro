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
        string ConnctionString = @"Data Source=NOTEBOOK\SQLEXPRESS;" +
            "Initial Catalog=AtividadeBD;" +
            "User ID=aluno;" +
            "Password='123'";
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
