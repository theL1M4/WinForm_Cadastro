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
using Dapper;

namespace Atividade_ADO
{
    public partial class frmBuscaProduto : Form
    {
        public frmBuscaProduto()
        {
            InitializeComponent();
        }
        private void BuscaProduto(object sender, EventArgs e)
        {

            Produto oProduto = new Produto();
            oProduto.NomeProd = txtNomeProduto.Text == "" ? "" : txtNomeProduto.Text;

            DataProduto oDataProduto = new DataProduto();

            var produto = oDataProduto.BuscarProduto(oProduto);

            dtgProduto.DataSource = produto;

            Utils utils = new Utils();
            utils.FormataGrid(dtgProduto, 2);

        }

    }
}
