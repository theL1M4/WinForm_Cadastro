using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_ADO.Data
{
     class DataProduto
    {
        readonly ConectaBD oConectaBD = new ConectaBD();
        readonly SqlCommand sqlCMD = new SqlCommand();
        //frmCadastroProduto oCadastroProduto = new frmCadastroProduto();
        public int oRetornoProd;

        public int Inserir(Produto produto)

        {
            //sqlConn.AbreBanco();
            var conn = oConectaBD.SqlConn();
            conn.Open();
            sqlCMD.Connection = conn;
            //ADICIONA OS PARAMETROS
            sqlCMD.Parameters.AddWithValue("@NomeProd", produto.NomeProd);
            sqlCMD.Parameters.AddWithValue("@TipoProd", produto.TipoProd);
            sqlCMD.Parameters.AddWithValue("@UnMedidaProd", produto.UnMedidaProd);
            sqlCMD.Parameters.AddWithValue("@QuantidadeProd", produto.QuantidadeProd);
            //COMANDO PARA VERIFICAR SE O USUARIO EXISTE
            string strCMD = "SELECT 1 FROM PRODUTOS WHERE NomeProd = @NomeProd";
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

            if (dtResult.Rows.Count > 0 && produto.IdProd == 0)
            {
                ///CODIGO PARA INFORMAR QUE O USUARIO JÁ EXISTE...
                ///sqlCMD.ExecuteNonQuery();
                MessageBox.Show("Usuário já existente!\nCrie um novo");
                oRetornoProd = 1;
            }
            else if (produto.IdProd != 0) //se existir o id ele executa o update
            {
                //LOGICA PARA ALTERAR CLIENTE NÃO PERMITINDO ALTERAÇÃO DO USUARIO
                //LOGICA PARA ALTERAR CLIENTE PERMITINDO ALTERAÇÃO DO USUARIO
                //strCMD = "INSERT INTO PRODUTOS(NomeProd,TipoProd,UnMedidaProd,QuantidadeProd) VALUES(@NomeProd, @TipoProd, @UnMedidaProd, @QuantidadeProd)";
                //sqlCMD.ExecuteNonQuery();
                oRetornoProd = 2;
            }
            else //se não existir o id ele executa o insert
            {
                strCMD = "INSERT INTO PRODUTOS(NomeProd,TipoProd,UnMedidaProd,QuantidadeProd) VALUES(@NomeProd, @TipoProd, @UnMedidaProd, @QuantidadeProd)";

                sqlCMD.CommandText = strCMD;
                sqlCMD.ExecuteNonQuery();
                oRetornoProd = 3;
            }

            conn.Close();
            conn.Dispose();
            conn = null;

            return oRetornoProd;
        }
        public List<Produto> BuscarProduto(Produto produto)
        {
            try
            {
                ConectaBD oConectaBD = new ConectaBD();
                var conn = oConectaBD.SqlConn();
                conn.Open();
                string strCMD = "SELECT * FROM PRODUTOS WHERE NomeProd like '%" + produto.NomeProd.ToString() + "%'";
                //USANDO DAPPER
                var produtos = conn.Query<Produto>(strCMD).ToList();
                return produtos;
            }
            catch (Exception ex) 
            {
                throw;
            }
        }
    }
}
