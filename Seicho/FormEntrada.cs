using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seicho.Models;
using System.Windows.Forms;

namespace Seicho
{
    public partial class FormEntrada : Form
    {
        int Linha;
        public FormEntrada()
        {
            InitializeComponent();
        }

        private void FormEntrada_Load(object sender, EventArgs e)
        {
            tmEntrada.Start();
            txtCodigo.Select();
            dgvPecas.Columns.Add("Codigo", "Codigo");
            dgvPecas.Columns.Add("Descrição", "Descrição");
            dgvPecas.Columns.Add("Quantidade", "Quantidade");
            dgvPecas.Columns.Add("Informações", "Informações");

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verifica() == true)
                {
                    dgvPecas.Rows.Add(txtCodigo.Text, txtDescricao.Text, txtQuant.Text, rtbAdicionais.Text);
                    btCadastrar.Enabled = true;
                    LimparCampos();
                    LimparCampos2();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Verifique se Todos os dados estão corretos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool verifica()
        {
            if (txtCodigo.Text != String.Empty && txtDescricao.Text != String.Empty && txtQuant.Text
                != String.Empty)
            {
                return true;
            }
            else return false;
        }
        public bool verifica2()
        {
            if (txtIDPeca.Text != String.Empty && txtDescPeca.Text != String.Empty && txtQunt2.Text
                != String.Empty)
            {
                return true;
            }
            else return false;
        }

        public void LimparCampos()
        {
            txtQuant.Clear();
            txtDescricao.Clear();
            txtCodigo.Clear();

        }
        public void LimparCampos2()
        {
            txtQunt2.Clear();
            txtIDPeca.Clear();
            txtDescPeca.Clear();

        }

        private void tmEntrada_Tick(object sender, EventArgs e)
        {

        }


        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            int dgv = dgvPecas.RowCount;
            if (dgv > 1)
            {
                using (var db = new dbSgc())
                {
                    try
                    {
                        for (int op = 0; op < dgvPecas.RowCount - 1; op++)
                        {
                            int codigo = Convert.ToInt32(dgvPecas.Rows[op].Cells[0].Value);
                            int count = db.produtos.Where(d => d.CODIGO == codigo).Count();
                            if (count > 0)
                            {
                                int idpeca = db.produtos.Where(d => d.CODIGO == codigo).FirstOrDefault().ID;
                                produtos pe = db.produtos.Find(idpeca);
                                pe.DT_ENTRADA = DateTime.Now.ToString("dd/MM/yyyy");
                                pe.INFO_ADICIONAIS = Convert.ToString(dgvPecas.Rows[op].Cells[3].Value);
                                pe.QTDE = Convert.ToInt32(dgvPecas.Rows[op].Cells[2].Value) + pe.QTDE;
                                db.Entry(pe).State = System.Data.Entity.EntityState.Modified;
                                db.SaveChanges();
                            }
                            else
                            {
                                produtos pe = new produtos();
                                pe.DT_ENTRADA = DateTime.Now.ToString("dd/MM/yyyy");
                                pe.INFO_ADICIONAIS = Convert.ToString(dgvPecas.Rows[op].Cells[3].Value);
                                pe.CODIGO = Convert.ToInt32(dgvPecas.Rows[op].Cells[0].Value);
                                pe.DESCRICAO = Convert.ToString(dgvPecas.Rows[op].Cells[1].Value);
                                pe.QTDE = Convert.ToInt32(dgvPecas.Rows[op].Cells[2].Value);
                                db.Entry(pe).State = System.Data.Entity.EntityState.Added;
                                db.SaveChanges();
                            }

                        }
                        MessageBox.Show("Peças Cadastradas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        dgvPecas.Rows.Clear();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erro" + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há nenhuma peça adicionada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgvPecas_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvPecas.Rows.Count > 1)
                Linha = Convert.ToInt32(dgvPecas.CurrentCell.RowIndex);
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPecas.Rows.Count > 1)
                dgvPecas.Rows.RemoveAt(Linha);
        }

        private void FormEntrada_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvPecas.Rows.Count > 1)
            {
                if ((MessageBox.Show("Todos os dados serão perdidos! \n" +
                "      Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    e.Cancel = false;

                }
                else
                    e.Cancel = true;
            }
        }

        PesqGeral pesq = new PesqGeral();
        private void btPesqPeca_Click(object sender, EventArgs e)
        {

            pesq.Load += pesqDiag_Load;
            pesq.btPesqDoc.Click += btPDiag_Click;
            pesq.ShowDialog();
            preencheCampos(txtIDPeca, txtDescPeca, pesq.retornoID, pesq.retornoDesc);

        }

        private void pesqDiag_Load(object sender, EventArgs e)
        {
            using (var db = new dbSgc())
            {
                pesq.dgvPesq.DataSource = db.produtos.Select(d => new
                {
                    CODIGO = d.CODIGO,
                    DESCRIÇÃO = d.DESCRICAO,
                    QUANTIDADE = d.QTDE,
                }).ToList();
            }
        }
        private void btPDiag_Click(object sender, EventArgs e)
        {
            dbSgc db = new dbSgc();
            pesq.dgvPesq.DataSource = pesquisarAluno(pesq.txtPesq.Text);
            db.Dispose();

        }
        private object pesquisarAluno(string pesquisa)
        {
            dbSgc db = new dbSgc();

            return db.produtos.Where(d => d.DESCRICAO.Contains(pesquisa) || d.CODIGO.ToString().Contains(pesquisa)).Select(d => new
            {
                CODIGO = d.CODIGO,
                DESCRIÇÃO = d.DESCRICAO,
                QUANTIDADE = d.QTDE,

            }).ToList();
        }
        private void preencheCampos(object sender1, object sender2, string ID, string Desc)
        {
            TextBox tID = sender1 as TextBox;
            if (!string.IsNullOrWhiteSpace(ID))
                tID.Text = ID;
            tID.BackColor = Color.White;


            TextBox tDesc = sender2 as TextBox;
            if (!string.IsNullOrWhiteSpace(Desc))
                tDesc.Text = Desc;


        }

        private void btAdicionar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (verifica2() == true)
                {
                    dgvPecas.Rows.Add(txtIDPeca.Text, txtDescPeca.Text, txtQunt2.Text, "");
                    btCadastrar.Enabled = true;
                    LimparCampos2();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Verifique se Todos os dados estão corretos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

