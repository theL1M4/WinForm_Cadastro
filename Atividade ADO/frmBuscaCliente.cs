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

        private void ExcluirCliente(object sender, EventArgs e)
        {
            try
            {

                var cliente = dtgClientes.CurrentRow.Cells[1].Value.ToString();
                var id = dtgClientes.CurrentRow.Cells[0].Value.ToString();
                var resp = MessageBox.Show(txtNome, "Deseja mesmo excluir o cliente " + cliente + "?", "Atenção!", MessageBoxButtons.YesNo);

                if (resp == DialogResult.Yes)
                {
                    DataCliente oCliente = new DataCliente();

                    if (oCliente.Excluir(id))
                        MessageBox.Show(txtNome, "O cliente " + cliente + " foi excluido corretamente!\nObrigado.", "Atenção!", MessageBoxButtons.OK);
                    else
                        MessageBox.Show(txtNome, "Deu ruim, tente de novo a exclusão\nObrigado.", "Atenção!", MessageBoxButtons.OK);
                }

                BuscaCliente(sender, e);
            }
            catch
            {
                MessageBox.Show("Por favor selecione um cliente para excluir.\nObrigado!", "Atenção");
            }
        }

        private void AlterarCliente(object sender, EventArgs e)
        {
            try
            {
                frmCadastroCliente oCadastroCliente = new frmCadastroCliente();

                oCadastroCliente.oCliente.Id = (int)dtgClientes.CurrentRow.Cells[0].Value;
                oCadastroCliente.oCliente.Nome = (string)dtgClientes.CurrentRow.Cells[1].Value;
                oCadastroCliente.oCliente.Usuario = (string)dtgClientes.CurrentRow.Cells[2].Value;
                oCadastroCliente.oCliente.Telefone = (string)dtgClientes.CurrentRow.Cells[3].Value;
                oCadastroCliente.oCliente.Email = (string)dtgClientes.CurrentRow.Cells[4].Value;

                oCadastroCliente.ShowDialog();

                BuscaCliente(sender, e);
            }
            catch
            {
                MessageBox.Show("Por favor selecione um cliente para alterar.\nObrigado!", "Atenção");
            }
        }

        private void AlterarClienteGrid(object sender, DataGridViewCellEventArgs e)
        {
            AlterarCliente(sender, e);
        }
    }
}
