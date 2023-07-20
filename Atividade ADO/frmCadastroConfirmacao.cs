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

namespace Atividade_ADO
{
    public partial class frmCadastroConfirmacao : Form
    {
        Cliente varCliente = new Cliente();
        public frmCadastroConfirmacao()
        {
            InitializeComponent();
        }

        private void CadastroSim(object sender, EventArgs e)
        {
            varCliente.Nome = txtNome.Text.ToLower();
            varCliente.Usuario = txtUsuario.Text.ToLower();
            varCliente.Email = txtEmail.Text.ToLower();
            varCliente.Telefone = txtTelefone.Text.ToLower();

            //INSTANCIANDO CLASSE DATACLIENTE
            DataCliente dataCliente = new DataCliente();

            //CHAMANDO METODO INSERIR NA CLASSE DATACLIENTE
            dataCliente.Inserir(varCliente);

            frmCadastroConfirmado varChamaTelaCadConfirm = new frmCadastroConfirmado();
            varChamaTelaCadConfirm.ShowDialog();

            this.Close();

        }

        public void CadastroNao(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
