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
    public partial class frmTelaInicio : Form
    {
        public frmTelaInicio()
        {
            InitializeComponent();
        }

        private void TelaCadastrarProduto(object sender, EventArgs e)
        {
            frmCadastroProduto varChamaTelaCadProduto = new frmCadastroProduto();
            varChamaTelaCadProduto.ShowDialog();
        }

        private void TelaCadastrarCliente(object sender, EventArgs e)
        {
            frmCadastroCliente varChamaTelaCadCliente = new frmCadastroCliente();
            varChamaTelaCadCliente.ShowDialog();
        }
    }
}
