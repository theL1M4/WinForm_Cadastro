namespace Atividade_ADO
{
    partial class frmTelaInicio
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
            this.components = new System.ComponentModel.Container();
            this.pnlTituloInicio = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnChamaCadCliente = new System.Windows.Forms.Button();
            this.btnChamaCadProduto = new System.Windows.Forms.Button();
            this.pnlClicks = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTituloInicio.SuspendLayout();
            this.pnlClicks.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTituloInicio
            // 
            this.pnlTituloInicio.Controls.Add(this.lblTitulo);
            this.pnlTituloInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTituloInicio.Location = new System.Drawing.Point(240, 12);
            this.pnlTituloInicio.Name = "pnlTituloInicio";
            this.pnlTituloInicio.Size = new System.Drawing.Size(265, 100);
            this.pnlTituloInicio.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(40, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(189, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Tela de Início";
            // 
            // btnChamaCadCliente
            // 
            this.btnChamaCadCliente.Location = new System.Drawing.Point(3, 36);
            this.btnChamaCadCliente.Name = "btnChamaCadCliente";
            this.btnChamaCadCliente.Size = new System.Drawing.Size(110, 110);
            this.btnChamaCadCliente.TabIndex = 1;
            this.btnChamaCadCliente.Text = "Cadastro de Cliente";
            this.btnChamaCadCliente.UseVisualStyleBackColor = true;
            this.btnChamaCadCliente.Click += new System.EventHandler(this.TelaCadastrarCliente);
            // 
            // btnChamaCadProduto
            // 
            this.btnChamaCadProduto.Location = new System.Drawing.Point(367, 36);
            this.btnChamaCadProduto.Name = "btnChamaCadProduto";
            this.btnChamaCadProduto.Size = new System.Drawing.Size(110, 110);
            this.btnChamaCadProduto.TabIndex = 2;
            this.btnChamaCadProduto.Text = "Cadastro de Produto";
            this.btnChamaCadProduto.UseVisualStyleBackColor = true;
            this.btnChamaCadProduto.Click += new System.EventHandler(this.TelaCadastrarProduto);
            // 
            // pnlClicks
            // 
            this.pnlClicks.Controls.Add(this.btnChamaCadCliente);
            this.pnlClicks.Controls.Add(this.btnChamaCadProduto);
            this.pnlClicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlClicks.Location = new System.Drawing.Point(132, 118);
            this.pnlClicks.Name = "pnlClicks";
            this.pnlClicks.Size = new System.Drawing.Size(480, 183);
            this.pnlClicks.TabIndex = 3;
            // 
            // frmTelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlClicks);
            this.Controls.Add(this.pnlTituloInicio);
            this.Name = "frmTelaInicio";
            this.Text = "frmTelaInicio";
            this.pnlTituloInicio.ResumeLayout(false);
            this.pnlTituloInicio.PerformLayout();
            this.pnlClicks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTituloInicio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnChamaCadCliente;
        private System.Windows.Forms.Button btnChamaCadProduto;
        private System.Windows.Forms.Panel pnlClicks;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}