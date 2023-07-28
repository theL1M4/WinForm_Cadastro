using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Atividade_ADO
{
    public partial class frmCadastroConfirmacao : Form
    {
        public int CadSim;
        public frmCadastroConfirmacao()
        {
            InitializeComponent();
        }

        public void CadastroSim(object sender, EventArgs e)
        {
            CadSim = 1;
            this.Close();
        }

        public void CadastroNao(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}