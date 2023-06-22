using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_ADO.Data
{
    class DataCliente
    {
        readonly ConectaBD sqlConn = new ConectaBD();
        readonly SqlCommand sqlCMD = new SqlCommand();

        public void Inserir(Cliente cliente)
        {
            sqlConn.AbreBanco();
            string strCMD = "insert";
            sqlCMD.CommandText = strCMD;
            sqlCMD.Parameters.AddWithValue("@nome", cliente.Nome);
            sqlCMD.Parameters.AddWithValue("@usuario", cliente.Usuario);
            sqlCMD.Parameters.AddWithValue("@telefone", cliente.Telefone);
            sqlCMD.Parameters.AddWithValue("@email", cliente.Email);
            sqlCMD.Parameters.AddWithValue("@data", DateTime.Now.ToString());
            sqlCMD.ExecuteNonQuery();
        }
    }
}
