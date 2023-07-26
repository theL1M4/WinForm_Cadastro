using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Atividade_ADO.Data
{
    public class Utils
    {
        public void FormataGrid(DataGridView dataGridView, int tipo)
        {
            if (tipo == 1)
            {
                //Renomeia as colunas do DataGridView 
                dataGridView.Columns[0].HeaderText = "Código";
                dataGridView.Columns[1].HeaderText = "Nome";
                dataGridView.Columns[2].HeaderText = "Usuario";
                dataGridView.Columns[3].HeaderText = "Telefone";
                dataGridView.Columns[4].HeaderText = "Email";
                dataGridView.Columns[0].Width = 80;
                dataGridView.Columns[1].Width = 200;
                dataGridView.Columns[2].Width = 150;
                dataGridView.Columns[3].Width = 120;
                dataGridView.Columns[4].Width = 300;
            }
            else if (tipo == 2)
            {
                //CADASTRO PRODUTO
                //Renomeia as colunas do DataGridView 
                dataGridView.Columns[0].HeaderText = "Código";
                dataGridView.Columns[1].HeaderText = "Nome";
                dataGridView.Columns[2].HeaderText = "Tipo";
                dataGridView.Columns[3].HeaderText = "Un. de Medida";
                dataGridView.Columns[4].HeaderText = "Quantidade";
                dataGridView.Columns[0].Width = 80;
                dataGridView.Columns[1].Width = 200;
                dataGridView.Columns[2].Width = 110;
                dataGridView.Columns[3].Width = 110;
                dataGridView.Columns[4].Width = 110;
            }

            {
                dataGridView.RowsDefaultCellStyle.BackColor = Color.Bisque;
                dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView.DefaultCellStyle.SelectionBackColor = Color.Red;
                dataGridView.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView.AllowUserToResizeColumns = false;
                dataGridView.RowHeadersVisible = false;
                dataGridView.AllowUserToResizeRows = false;
            }
        }
    }
}
