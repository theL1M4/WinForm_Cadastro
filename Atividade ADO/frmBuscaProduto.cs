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
            try
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

                BuscaProduto(sender, e);
            }
            catch
            {
                MessageBox.Show("Por favor selecione um produto para excluir.\nObrigado!", "Atenção");
            }
        }

        private void AlterarProduto(object sender, EventArgs e)
        {
            try
            {
                frmCadastroProduto oCadastroProduto = new frmCadastroProduto();

                oCadastroProduto.oProduto.IdProd = (int)dtgProduto.CurrentRow.Cells[0].Value;
                oCadastroProduto.oProduto.NomeProd = (string)dtgProduto.CurrentRow.Cells[1].Value;
                oCadastroProduto.oProduto.TipoProd = (string)dtgProduto.CurrentRow.Cells[2].Value;
                oCadastroProduto.oProduto.UnMedidaProd = (string)dtgProduto.CurrentRow.Cells[3].Value;
                oCadastroProduto.oProduto.QuantidadeProd = (string)dtgProduto.CurrentRow.Cells[4].Value;

                oCadastroProduto.ShowDialog();

                BuscaProduto(sender, e);
            }
            catch
            {
                MessageBox.Show("Por favor selecione um produto para alterar.\nObrigado!", "Atenção");
            }
        }

        private void AlterarProdutoGrid(object sender, DataGridViewCellEventArgs e)
        {
            AlterarProduto(sender, e);
        }
    }
}
