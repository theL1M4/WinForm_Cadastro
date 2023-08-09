namespace Atividade_ADO
{
    partial class frmBuscaProduto
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
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dtgProduto = new System.Windows.Forms.DataGridView();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.btnExcluirProd = new System.Windows.Forms.Button();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloBscClient = new System.Windows.Forms.Label();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).BeginInit();
            this.pnlBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dtgProduto);
            this.pnlGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGrid.Location = new System.Drawing.Point(2, 165);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(796, 277);
            this.pnlGrid.TabIndex = 9;
            // 
            // dtgProduto
            // 
            this.dtgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProduto.Location = new System.Drawing.Point(0, 0);
            this.dtgProduto.Name = "dtgProduto";
            this.dtgProduto.Size = new System.Drawing.Size(796, 277);
            this.dtgProduto.TabIndex = 0;
            this.dtgProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlterarProdutoGrid);
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.btnAlterarProduto);
            this.pnlBuscar.Controls.Add(this.btnExcluirProd);
            this.pnlBuscar.Controls.Add(this.txtNomeProd);
            this.pnlBuscar.Controls.Add(this.lblNomeProduto);
            this.pnlBuscar.Controls.Add(this.btnBuscarProduto);
            this.pnlBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBuscar.Location = new System.Drawing.Point(2, 93);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(796, 66);
            this.pnlBuscar.TabIndex = 8;
            // 
            // btnExcluirProd
            // 
            this.btnExcluirProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProd.Location = new System.Drawing.Point(689, 31);
            this.btnExcluirProd.Name = "btnExcluirProd";
            this.btnExcluirProd.Size = new System.Drawing.Size(104, 29);
            this.btnExcluirProd.TabIndex = 7;
            this.btnExcluirProd.Text = "Excluir";
            this.btnExcluirProd.UseVisualStyleBackColor = true;
            this.btnExcluirProd.Click += new System.EventHandler(this.ExcluirProduto);
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(3, 31);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(463, 26);
            this.txtNomeProd.TabIndex = 4;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(3, 4);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(55, 20);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome";
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProduto.Location = new System.Drawing.Point(472, 30);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(104, 29);
            this.btnBuscarProduto.TabIndex = 6;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.BuscaProduto);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTituloBscClient);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(21, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 55);
            this.panel1.TabIndex = 7;
            // 
            // lblTituloBscClient
            // 
            this.lblTituloBscClient.AutoSize = true;
            this.lblTituloBscClient.Location = new System.Drawing.Point(3, 14);
            this.lblTituloBscClient.Name = "lblTituloBscClient";
            this.lblTituloBscClient.Size = new System.Drawing.Size(166, 25);
            this.lblTituloBscClient.TabIndex = 0;
            this.lblTituloBscClient.Text = "Busca Produto";
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarProduto.Location = new System.Drawing.Point(579, 31);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(104, 29);
            this.btnAlterarProduto.TabIndex = 8;
            this.btnAlterarProduto.Text = "Alterar";
            this.btnAlterarProduto.UseVisualStyleBackColor = true;
            this.btnAlterarProduto.Click += new System.EventHandler(this.AlterarProduto);
            // 
            // frmBuscaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.panel1);
            this.Name = "frmBuscaProduto";
            this.Text = "frmBuscaProduto";
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).EndInit();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dtgProduto;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloBscClient;
        private System.Windows.Forms.Button btnExcluirProd;
        private System.Windows.Forms.Button btnAlterarProduto;
    }
}