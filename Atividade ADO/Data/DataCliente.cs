using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Atividade_ADO.Data
{
    class DataCliente
    {
        readonly ConectaBD oConenctaBD = new ConectaBD();
        readonly SqlCommand sqlCMD = new SqlCommand();
        public int Inserir(Cliente cliente)
        {
            var oRetorno = 0;
            //sqlConn.AbreBanco();
            var conn = oConenctaBD.SqlConn();
            conn.Open();
            sqlCMD.Connection = conn;
            //ADICIONA OS PARAMETROS
            sqlCMD.Parameters.AddWithValue("@Nome", cliente.Nome);
            sqlCMD.Parameters.AddWithValue("@Usuario", cliente.Usuario);
            sqlCMD.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            sqlCMD.Parameters.AddWithValue("@Email", cliente.Email);
            sqlCMD.Parameters.AddWithValue("@DtCadastro", DateTime.Now.ToString());
            //COMANDO PARA VERIFICAR SE O USUARIO EXISTE
            string strCMD = "SELECT 1 FROM CLIENTES WHERE Usuario = @usuario";
            sqlCMD.CommandText = strCMD;
            //DATAREADER RECEBE O COMANDO SQLCMD.EXECUTEREADER
            IDataReader dtreader = sqlCMD.ExecuteReader();
            //INSTANCIA O OBJETO DATATABLE 
            DataTable dtResult = new DataTable();
            //EXECUTA A LEITURA DO DATAREADER PARA POPULAR O DATATABLE
            dtResult.Load(dtreader);
            //VERIFICA O RETORNO POSIÇÃO 0 É A PRIMEIRA POSIÇÃO DE RETORNO
            //COMO O SELECT RETORNA 1 SE EXISTIR E NADA SE NÃO EXISTIR
            //if(dtResult.Rows[0].ItemArray[0].ToString() == "1")

            if (dtResult.Rows.Count > 0 && cliente.Id == 0)
            {
                ///CODIGO PARA INFORMAR QUE O USUARIO JÁ EXISTE...
                ///sqlCMD.ExecuteNonQuery();
                oRetorno = 1;
                MessageBox.Show("Usuário já existente");

            }
            else if (cliente.Id != 0) //se existir o id ele executa o update
            {
                //LOGICA PARA ALTERAR CLIENTE NÃO PERMITINDO ALTERAÇÃO DO USUARIO
                //LOGICA PARA ALTERAR CLIENTE PERMITINDO ALTERAÇÃO DO USUARIO
                sqlCMD.ExecuteNonQuery();
                oRetorno = 2;
                MessageBox.Show("Usuário atualizado");
            }
            else //se não existir o id ele executa o insert
            {
                strCMD = "INSERT INTO CLIENTES(Nome,Usuario,Telefone,Email,DtCadastro) " +
                         "VALUES(@Nome,@Usuario,@Telefone,@Email,@DtCadastro)";

                sqlCMD.CommandText = strCMD;
                sqlCMD.ExecuteNonQuery();
                oRetorno = 3;
                //MessageBox.Show("Usuário cadastrado");
            }

            conn.Close();
            conn.Dispose();
            conn = null;

            return oRetorno;

        }
        public List<Cliente> BuscarCliente(Cliente cliente)
        {
            try
            {
                ConectaBD oConectaBD = new ConectaBD();
                var conn = oConectaBD.SqlConn();
                conn.Open();
                string strCMD = "SELECT * FROM CLIENTES WHERE Nome like '%" + cliente.Nome.ToString() + "%'";
                //USANDO DAPPER
                var clientes = conn.Query<Cliente>(strCMD).ToList();
                return clientes;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
