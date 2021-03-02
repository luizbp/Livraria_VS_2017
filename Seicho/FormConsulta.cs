using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seicho.Models;

namespace Seicho
{
    public partial class FormConsulta : Form
    {
        int IDAlt;
        int id;
        string nome;
        public FormConsulta()
        {
            InitializeComponent();
        }
        private void carregarDgvPecas()
        {
            try
            {
                using (var db = new dbSgc())
                {
                    dgvPesquisa.DataSource = db.produtos.Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        QUANTIDADE = d.QTDE,
                        DATA_ENTRADA = d.DT_ENTRADA,
                        INFORMAÇÕES = d.INFO_ADICIONAIS
                    }).ToList();
                }
        }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void carregarDgvPecasVendidas()
        {
            try
            {
                using (var db = new dbSgc())
                {
                    dgvPecasVendidas.DataSource = db.produtos_vendidos.Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        QUANTIDADE = d.QTDE,
                        DATA_VENDA = d.DATA_VENDA
                    }).ToList();
                }


            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            carregarDgvPecas();
            mskFiltro.Text = "CODIGO";
            txtPesq.Focus();
        }

        private void dgvPesquisa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && Convert.ToInt32(e.Value) >= 1)
            {
                dgvPesquisa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            if (e.ColumnIndex == 3 && Convert.ToInt32(e.Value) <= 0)
            {
                dgvPesquisa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
            }

            if (e.ColumnIndex == 3 && Convert.ToInt32(e.Value) == 0)
            {
                dgvPesquisa.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new dbSgc())
            {
                 if (mskFiltro.Text == "DESCRIÇÃO")
                {
                    dgvPesquisa.DataSource = db.produtos.Where(d => d.DESCRICAO.Contains(txtPesq.Text)).Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        QUANTIDADE = d.QTDE,
                        DATA_ENTRADA = d.DT_ENTRADA,
                        INFORMAÇÕES = d.INFO_ADICIONAIS
                    }).ToList();
                }
                 if (mskFiltro.Text == "CODIGO")
                {
                    dgvPesquisa.DataSource = db.produtos.Where(d => d.CODIGO.ToString().Contains(txtPesq.Text)).Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        QUANTIDADE = d.QTDE,
                        DATA_ENTRADA = d.DT_ENTRADA,
                        INFORMAÇÕES = d.INFO_ADICIONAIS
                    }).ToList();
                }
                 
            }
        }

        private void ckbSVO_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = Convert.ToInt32(dgvPesquisa.CurrentCell.RowIndex);
            IDAlt = Convert.ToInt32(dgvPesquisa[0, linha].Value);
            using (var db = new dbSgc())
            {

            }
        }

        private void tbConsulta_Click(object sender, EventArgs e)
        {
            if (tbConsulta.SelectedTab == tabPeca)
            {
                carregarDgvPecas();
                txtPesq.Focus();
            }
            if (tbConsulta.SelectedTab == tabPecasVendidas)
            {
                carregarDgvPecasVendidas();
                txtPesqPecasVend.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new dbSgc())
                {
                    dgvPecasVendidas.DataSource = db.produtos_vendidos.Where(d => d.DESCRICAO.Contains(txtPesqPecasVend.Text) ||
                    d.CODIGO.ToString().Contains(txtPesqPecasVend.Text)).Select(d => new
                    {
                        ID = d.ID,
                        CODIGO = d.CODIGO,
                        DESCRIÇÃO = d.DESCRICAO,
                        QUANTIDADE = d.QTDE,
                        DATA_VENDA = d.DATA_VENDA
                    }).ToList();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbConsulta.SelectedTab == tabPeca)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button1_Click(sender, e);
                }
            }
            if (tbConsulta.SelectedTab == tabPecasVendidas)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button2_Click(sender, e);
                }
            }
        }

        private void dgvPecasVendidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormConsulta_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (tbConsulta.SelectedTab == tabPeca && e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
            if (tbConsulta.SelectedTab == tabPecasVendidas && e.KeyCode == Keys.Enter)
                button2_Click(sender, e);
        }
    }
}
