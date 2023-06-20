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
    public partial class BuscaFornecedor : Form
    {
        public BuscaFornecedor()
        {
            InitializeComponent(); 
        }

        private void clickCadastroFornecedor(object sender, EventArgs e)
        {
            CadastroFornecedor varCadastroFornecedor = new CadastroFornecedor();
            varCadastroFornecedor.Show(); // Ou form2.ShowDialog()
        }
         
        private void clickHome(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
