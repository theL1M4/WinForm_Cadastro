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
    public partial class BuscaCliente : Form
    {
        public BuscaCliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroCliente varCadastroCliente = new CadastroCliente();
            varCadastroCliente.Show(); // Ou form2.ShowDialog()
        }
    }
}
