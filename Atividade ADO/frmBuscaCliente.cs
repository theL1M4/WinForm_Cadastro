using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atividade_ADO.Data;
using Dapper;

namespace Atividade_ADO
{
    public partial class frmBuscaCliente : Form
    {
        public frmBuscaCliente()
        {
            InitializeComponent();
        }

        private void BuscaCliente(object sender, EventArgs e)
        {

            Cliente oCliente = new Cliente();
            oCliente.Nome = txtNome.Text == "" ? "" : txtNome.Text;

            DataCliente oDataCliente = new DataCliente();

            var clientes = oDataCliente.BuscarCliente(oCliente);

            dtgClientes.DataSource = clientes;

            Utils utils = new Utils();
            utils.FormataGrid(dtgClientes, 1);

        }
    }
}
