﻿using Atividade_ADO.Data;
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
    public partial class frmCadastroProduto : Form
    {
        public Produto oProduto = new Produto();
        DataProduto oDataProduto = new DataProduto();
        frmCadastroConfirmado varChamaTelaCadConfirm = new frmCadastroConfirmado();

        public frmCadastroProduto()
        {
            InitializeComponent();
        }
        public void CadastrarProduto(object sender, EventArgs e)
        {
            frmCadastroConfirmacao varChamaTelaCadSN = new frmCadastroConfirmacao();
            varChamaTelaCadSN.ShowDialog();
            if(varChamaTelaCadSN.CadSim == 1)
            {
                oProduto.NomeProd = txtNomeProd.Text.ToLower();
                oProduto.TipoProd = txtTipoProd.Text.ToLower();
                oProduto.UnMedidaProd = txtUnMedProd.Text.ToLower();
                oProduto.QuantidadeProd = txtQtdProd.Text.ToLower();

                //INSTANCIANDO CLASSE DATACLIENTE
                DataProduto dataProduto = new DataProduto();

                //CHAMANDO METODO INSERIR NA CLASSE DATACLIENTE
                dataProduto.Inserir(oProduto);

                if (oDataProduto.oRetornoProd == 3)
                {
                    varChamaTelaCadConfirm.ShowDialog();
                    this.Close();
                }
                else if (oDataProduto.oRetornoProd == 2)
                {

                }
                else if (oDataProduto.oRetornoProd == 1)
                {
                    txtNomeProd.Focus();
                }
            }
        }

        private void FecharTela(object sender, EventArgs e)
        {
            this.Close();
        }

   
        private void CarregaFormProd(object sender, EventArgs e)
        {
            if (oProduto.IdProd > 0)
            {
                txtNomeProd.Text = oProduto.NomeProd;
                txtTipoProd.Text = oProduto.TipoProd;
                txtUnMedProd.Text = oProduto.UnMedidaProd;
                txtQtdProd.Text = oProduto.QuantidadeProd;
                btnCadastrarProd.Text = "Alterar";
            }
        }
    }
}
