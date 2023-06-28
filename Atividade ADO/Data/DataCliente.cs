using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Atividade_ADO.Data
{
    class DataCliente
    {
        readonly ConectaBD sqlConn = new ConectaBD();
        readonly SqlCommand sqlCMD = new SqlCommand();

        public void Inserir(Cliente cliente)
        {
            sqlConn.AbreBanco();
            string strCMD = "INSERT INTO CLIENTES(Nome,Usuario,Telefone,Email,DtCadastro) VALUES(@Nome, @Usuario, @Telefone, @Email, @DtCadastro)";
            sqlCMD.CommandText = strCMD;
            sqlCMD.Parameters.AddWithValue("@Nome", cliente.Nome);
            sqlCMD.Parameters.AddWithValue("@Usuario", cliente.Usuario);
            sqlCMD.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            sqlCMD.Parameters.AddWithValue("@Email", cliente.Email);
            sqlCMD.Parameters.AddWithValue("@DtCadastro", DateTime.Now.ToString());
            sqlCMD.ExecuteNonQuery();
        }
    }
}
