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
    public partial class frmCadastroCliente : Form
    {
        public Cliente oCliente = new Cliente();
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        public void CadastrarCliente(object sender, EventArgs e)
        {
            frmCadastroConfirmacao varChamaTelaCadSN = new frmCadastroConfirmacao();
            varChamaTelaCadSN.ShowDialog();
            if (varChamaTelaCadSN.CadSim == 1)
            {
                oCliente.Nome = txtNome.Text.ToLower();
                oCliente.Usuario = txtUsuario.Text.ToLower();
                oCliente.Email = txtEmail.Text.ToLower();
                oCliente.Telefone = txtTelefone.Text.ToLower();

                //INSTANCIANDO CLASSE DATACLIENTE
                DataCliente dataCliente = new DataCliente();

                //CHAMANDO METODO INSERIR NA CLASSE DATACLIENTE
                dataCliente.Inserir(oCliente);

                frmCadastroConfirmado varChamaTelaCadConfirm = new frmCadastroConfirmado();
                varChamaTelaCadConfirm.ShowDialog();

                this.Close();
            }
        }

        private void FecharTela(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}