namespace Atividade_ADO
{
    partial class frmCadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrarProd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQtdProd = new System.Windows.Forms.TextBox();
            this.txtUnMedProd = new System.Windows.Forms.TextBox();
            this.txtTipoProd = new System.Windows.Forms.TextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.lblQtdProd = new System.Windows.Forms.Label();
            this.lblMedProd = new System.Windows.Forms.Label();
            this.lblTipoProd = new System.Windows.Forms.Label();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloProd = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInfMed = new System.Windows.Forms.Label();
            this.lblinfMed1 = new System.Windows.Forms.Label();
            this.lblInfMed2 = new System.Windows.Forms.Label();
            this.lblInfMed3 = new System.Windows.Forms.Label();
            this.lblInfMed4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInfTip4 = new System.Windows.Forms.Label();
            this.lblInfTip3 = new System.Windows.Forms.Label();
            this.lblInfTip2 = new System.Windows.Forms.Label();
            this.lblInfTip1 = new System.Windows.Forms.Label();
            this.lblInfTipo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarProd
            // 
            this.btnCadastrarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProd.Location = new System.Drawing.Point(39, 404);
            this.btnCadastrarProd.Name = "btnCadastrarProd";
            this.btnCadastrarProd.Size = new System.Drawing.Size(104, 29);
            this.btnCadastrarProd.TabIndex = 5;
            this.btnCadastrarProd.Text = "Cadastrar";
            this.btnCadastrarProd.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtQtdProd);
            this.panel2.Controls.Add(this.txtUnMedProd);
            this.panel2.Controls.Add(this.txtTipoProd);
            this.panel2.Controls.Add(this.txtNomeProd);
            this.panel2.Controls.Add(this.lblQtdProd);
            this.panel2.Controls.Add(this.lblMedProd);
            this.panel2.Controls.Add(this.lblTipoProd);
            this.panel2.Controls.Add(this.lblNomeProd);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(23, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 273);
            this.panel2.TabIndex = 4;
            // 
            // txtQtdProd
            // 
            this.txtQtdProd.Location = new System.Drawing.Point(551, 116);
            this.txtQtdProd.Name = "txtQtdProd";
            this.txtQtdProd.Size = new System.Drawing.Size(203, 26);
            this.txtQtdProd.TabIndex = 9;
            // 
            // txtUnMedProd
            // 
            this.txtUnMedProd.Location = new System.Drawing.Point(271, 116);
            this.txtUnMedProd.Name = "txtUnMedProd";
            this.txtUnMedProd.Size = new System.Drawing.Size(198, 26);
            this.txtUnMedProd.TabIndex = 8;
            // 
            // txtTipoProd
            // 
            this.txtTipoProd.Location = new System.Drawing.Point(16, 116);
            this.txtTipoProd.Name = "txtTipoProd";
            this.txtTipoProd.Size = new System.Drawing.Size(195, 26);
            this.txtTipoProd.TabIndex = 5;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(16, 49);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(738, 26);
            this.txtNomeProd.TabIndex = 4;
            // 
            // lblQtdProd
            // 
            this.lblQtdProd.AutoSize = true;
            this.lblQtdProd.Location = new System.Drawing.Point(547, 89);
            this.lblQtdProd.Name = "lblQtdProd";
            this.lblQtdProd.Size = new System.Drawing.Size(102, 20);
            this.lblQtdProd.TabIndex = 3;
            this.lblQtdProd.Text = "Quantidade";
            // 
            // lblMedProd
            // 
            this.lblMedProd.AutoSize = true;
            this.lblMedProd.Location = new System.Drawing.Point(267, 89);
            this.lblMedProd.Name = "lblMedProd";
            this.lblMedProd.Size = new System.Drawing.Size(171, 20);
            this.lblMedProd.TabIndex = 2;
            this.lblMedProd.Text = "Unidade de Medida*";
            // 
            // lblTipoProd
            // 
            this.lblTipoProd.AutoSize = true;
            this.lblTipoProd.Location = new System.Drawing.Point(16, 89);
            this.lblTipoProd.Name = "lblTipoProd";
            this.lblTipoProd.Size = new System.Drawing.Size(143, 20);
            this.lblTipoProd.TabIndex = 1;
            this.lblTipoProd.Text = "Tipo do Produto*";
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Location = new System.Drawing.Point(16, 22);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(148, 20);
            this.lblNomeProd.TabIndex = 0;
            this.lblNomeProd.Text = "Nome do Produto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTituloProd);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(21, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 55);
            this.panel1.TabIndex = 3;
            // 
            // lblTituloProd
            // 
            this.lblTituloProd.AutoSize = true;
            this.lblTituloProd.Location = new System.Drawing.Point(13, 14);
            this.lblTituloProd.Name = "lblTituloProd";
            this.lblTituloProd.Size = new System.Drawing.Size(196, 25);
            this.lblTituloProd.TabIndex = 0;
            this.lblTituloProd.Text = "Cadastro Produto";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblInfMed4);
            this.panel3.Controls.Add(this.lblInfMed3);
            this.panel3.Controls.Add(this.lblInfMed2);
            this.panel3.Controls.Add(this.lblinfMed1);
            this.panel3.Controls.Add(this.lblInfMed);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(271, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 112);
            this.panel3.TabIndex = 4;
            // 
            // lblInfMed
            // 
            this.lblInfMed.AutoSize = true;
            this.lblInfMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfMed.Location = new System.Drawing.Point(13, 14);
            this.lblInfMed.Name = "lblInfMed";
            this.lblInfMed.Size = new System.Drawing.Size(58, 16);
            this.lblInfMed.TabIndex = 0;
            this.lblInfMed.Text = "*Digite:";
            // 
            // lblinfMed1
            // 
            this.lblinfMed1.AutoSize = true;
            this.lblinfMed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfMed1.Location = new System.Drawing.Point(16, 34);
            this.lblinfMed1.Name = "lblinfMed1";
            this.lblinfMed1.Size = new System.Drawing.Size(37, 13);
            this.lblinfMed1.TabIndex = 1;
            this.lblinfMed1.Text = "1 - KG";
            // 
            // lblInfMed2
            // 
            this.lblInfMed2.AutoSize = true;
            this.lblInfMed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfMed2.Location = new System.Drawing.Point(16, 50);
            this.lblInfMed2.Name = "lblInfMed2";
            this.lblInfMed2.Size = new System.Drawing.Size(35, 13);
            this.lblInfMed2.TabIndex = 2;
            this.lblInfMed2.Text = "2 - LT";
            // 
            // lblInfMed3
            // 
            this.lblInfMed3.AutoSize = true;
            this.lblInfMed3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfMed3.Location = new System.Drawing.Point(16, 66);
            this.lblInfMed3.Name = "lblInfMed3";
            this.lblInfMed3.Size = new System.Drawing.Size(38, 13);
            this.lblInfMed3.TabIndex = 3;
            this.lblInfMed3.Text = "3 - UN";
            // 
            // lblInfMed4
            // 
            this.lblInfMed4.AutoSize = true;
            this.lblInfMed4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfMed4.Location = new System.Drawing.Point(16, 82);
            this.lblInfMed4.Name = "lblInfMed4";
            this.lblInfMed4.Size = new System.Drawing.Size(38, 13);
            this.lblInfMed4.TabIndex = 4;
            this.lblInfMed4.Text = "4 - MT";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblInfTip4);
            this.panel4.Controls.Add(this.lblInfTip3);
            this.panel4.Controls.Add(this.lblInfTip2);
            this.panel4.Controls.Add(this.lblInfTip1);
            this.panel4.Controls.Add(this.lblInfTipo);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(16, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(104, 122);
            this.panel4.TabIndex = 5;
            // 
            // lblInfTip4
            // 
            this.lblInfTip4.AutoSize = true;
            this.lblInfTip4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfTip4.Location = new System.Drawing.Point(16, 82);
            this.lblInfTip4.Name = "lblInfTip4";
            this.lblInfTip4.Size = new System.Drawing.Size(65, 13);
            this.lblInfTip4.TabIndex = 4;
            this.lblInfTip4.Text = "4 - Escritório";
            // 
            // lblInfTip3
            // 
            this.lblInfTip3.AutoSize = true;
            this.lblInfTip3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfTip3.Location = new System.Drawing.Point(16, 66);
            this.lblInfTip3.Name = "lblInfTip3";
            this.lblInfTip3.Size = new System.Drawing.Size(61, 13);
            this.lblInfTip3.TabIndex = 3;
            this.lblInfTip3.Text = "3 - Limpeza";
            // 
            // lblInfTip2
            // 
            this.lblInfTip2.AutoSize = true;
            this.lblInfTip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfTip2.Location = new System.Drawing.Point(16, 50);
            this.lblInfTip2.Name = "lblInfTip2";
            this.lblInfTip2.Size = new System.Drawing.Size(60, 13);
            this.lblInfTip2.TabIndex = 2;
            this.lblInfTip2.Text = "2 - Bebidas";
            // 
            // lblInfTip1
            // 
            this.lblInfTip1.AutoSize = true;
            this.lblInfTip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfTip1.Location = new System.Drawing.Point(16, 34);
            this.lblInfTip1.Name = "lblInfTip1";
            this.lblInfTip1.Size = new System.Drawing.Size(67, 13);
            this.lblInfTip1.TabIndex = 1;
            this.lblInfTip1.Text = "1 - Alimentos";
            // 
            // lblInfTipo
            // 
            this.lblInfTipo.AutoSize = true;
            this.lblInfTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfTipo.Location = new System.Drawing.Point(13, 14);
            this.lblInfTipo.Name = "lblInfTipo";
            this.lblInfTipo.Size = new System.Drawing.Size(58, 16);
            this.lblInfTipo.TabIndex = 0;
            this.lblInfTipo.Text = "*Digite:";
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarProd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadastroProduto";
            this.Text = "frmCadastroProduto";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarProd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtQtdProd;
        private System.Windows.Forms.TextBox txtUnMedProd;
        private System.Windows.Forms.TextBox txtTipoProd;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Label lblQtdProd;
        private System.Windows.Forms.Label lblMedProd;
        private System.Windows.Forms.Label lblTipoProd;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloProd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblinfMed1;
        private System.Windows.Forms.Label lblInfMed;
        private System.Windows.Forms.Label lblInfMed4;
        private System.Windows.Forms.Label lblInfMed3;
        private System.Windows.Forms.Label lblInfMed2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblInfTip4;
        private System.Windows.Forms.Label lblInfTip3;
        private System.Windows.Forms.Label lblInfTip2;
        private System.Windows.Forms.Label lblInfTip1;
        private System.Windows.Forms.Label lblInfTipo;
    }
}