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
            oProduto.NomeProd = txtNomeProd.Text == "" ? "" : txtNomeProd.Text;

            DataProduto oDataProduto = new DataProduto();

            var produto = oDataProduto.BuscarProduto(oProduto);

            dtgProduto.DataSource = produto;

            Utils utils = new Utils();
            utils.FormataGrid(dtgProduto, 2);

        }

        private void ExcluirProduto(object sender, EventArgs e)
        {
            var produto = dtgProduto.CurrentRow.Cells[1].Value.ToString();
            var idProd = dtgProduto.CurrentRow.Cells[0].Value.ToString();
            var resp = MessageBox.Show(txtNomeProd, "Deseja mesmo excluir o produto " + produto + "?", "Atenção!", MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                DataProduto oDataProduto = new DataProduto();

                if (oDataProduto.Excluir(idProd))
                    MessageBox.Show(txtNomeProd, "O produto " + produto + " foi excluido corretamente!\nObrigado.", "Atenção!", MessageBoxButtons.OK);
                else
                    MessageBox.Show(txtNomeProd, "Deu ruim, tente de novo a exclusão\nObrigado.", "Atenção!", MessageBoxButtons.OK);
            }
        }
    }
}
