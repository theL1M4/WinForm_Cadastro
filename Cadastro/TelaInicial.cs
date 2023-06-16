using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnChamarBuscaCliente(object sender, EventArgs e)
        {
            BuscaCliente varBuscaCliente = new BuscaCliente();
            varBuscaCliente.Show(); // Ou form2.ShowDialog();
        }

        private void btnChamarBuscaFornecedor(object sender, EventArgs e)
        {
            BuscaFornecedor varBuscaFornecedor = new BuscaFornecedor();
            varBuscaFornecedor.Show(); // Ou form2.ShowDialog();
        }

        private void btnChamarBuscaProduto(object sender, EventArgs e)
        {
            BuscaProduto varBuscaProduto = new BuscaProduto();
            varBuscaProduto.Show(); // Ou form2.ShowDialog();
        }
    }
}
