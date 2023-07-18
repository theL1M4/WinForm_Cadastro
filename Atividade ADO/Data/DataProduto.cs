using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_ADO.Data
{
    internal class DataProduto
    {
        readonly ConectaBD oConectaBD = new ConectaBD();
        readonly SqlCommand sqlCMD = new SqlCommand();

        public void Inserir(Produto produto)
        {
            //sqlConn.AbreBanco();
            var conn = oConectaBD.SqlConn();
            conn.Open();
            string strCMD = "INSERT INTO PRODUTOS(NomeProd,TipoProd,UnMedidaProd,QuantidadeProd,) VALUES(@Nome, @Usuario, @Telefone, @Email)";
            sqlCMD.CommandText = strCMD;
            sqlCMD.Connection = conn;
            sqlCMD.Parameters.AddWithValue("@Nome", produto.NomeProd);
            sqlCMD.Parameters.AddWithValue("@Usuario", produto.TipoProd);
            sqlCMD.Parameters.AddWithValue("@Telefone", produto.UnMedidaProd);
            sqlCMD.Parameters.AddWithValue("@Email", produto.QuantidadeProd);
            sqlCMD.ExecuteNonQuery();
        }
    }
}
