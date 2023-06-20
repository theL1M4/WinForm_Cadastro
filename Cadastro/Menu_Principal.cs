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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void CadastroCliente(object sender, EventArgs e)
        {
            BuscaCliente varBuscaCliente = new BuscaCliente();
            varBuscaCliente.ShowDialog();
        }

        private void FecharPrograma(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroFornecedor(object sender, EventArgs e)
        {
            BuscaFornecedor varBuscaFornecedor = new BuscaFornecedor();
            varBuscaFornecedor.ShowDialog();
        }

        private void CadastroProduto(object sender, EventArgs e)
        {
            BuscaProduto varBuscaProduto = new BuscaProduto();
            varBuscaProduto.ShowDialog();
        }
    }
}
