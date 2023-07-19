using Atividade_ADO.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_ADO
{
    public partial class frmCadastroProduto : Form
    {
        Produto oProduto = new Produto();
        public frmCadastroProduto()
        {
            InitializeComponent();
        }
        private void CadastrarCliente(object sender, EventArgs e)
        {
            oProduto.NomeProd = txtNomeProd.Text.ToLower();
            oProduto.TipoProd = txtTipoProd.Text.ToLower();
            oProduto.UnMedidaProd = txtUnMedProd.Text.ToLower();
            oProduto.QuantidadeProd = txtQtdProd.Text.ToLower();

            //INSTANCIANDO CLASSE DATACLIENTE
            DataProduto dataProduto = new DataProduto();

            //CHAMANDO METODO INSERIR NA CLASSE DATACLIENTE
            dataProduto.Inserir(oProduto);
        }
    }
}
