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
using System.IO;
using System.Diagnostics;
using Microsoft.Reporting.WinForms;
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)
//using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Seicho
{
    public partial class FormRelatorio : Form
    {
        string nome;
        string local, local2;
        DateTime data = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void dtpDe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpAte_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btCarregar_Click(object sender, EventArgs e)
        {
            if (rbHoje.Checked != true && rbPer.Checked != true && rbTodos.Checked != true)
            {
                MessageBox.Show("Selecione um tipo de filtro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DateTime data1 = Convert.ToDateTime(dtpDe.Text);
                DateTime data2 = Convert.ToDateTime(dtpAte.Text);
                using (var db = new dbSgc())
                {
                    if (rbHoje.Checked)
                    {
                        dgvRelatorio.DataSource = db.produtos_vendidos.Where(d => d.DATA_VENDA == data).Select(d => new
                        {

                            COD = d.CODIGO,
                            DESCRIÇÃO = d.DESCRICAO,
                            QUANT = d.QTDE,
                            DATA_VENDA = d.DATA_VENDA
                        }).ToList();
                    }

                    if (rbTodos.Checked)
                        dgvRelatorio.DataSource = db.produtos_vendidos.Select(d => new
                        {

                            COD = d.CODIGO,
                            DESCRIÇÃO = d.DESCRICAO,
                            QUANT = d.QTDE,
                            DATA_VENDA = d.DATA_VENDA
                        }).ToList();
                    if (rbPer.Checked)
                    {
                        dgvRelatorio.DataSource = db.produtos_vendidos.Where(d => d.DATA_VENDA >= data1 && d.DATA_VENDA <= data2).Select(d => new
                        {

                            COD = d.CODIGO,
                            DESCRIÇÃO = d.DESCRICAO,
                            QUANT = d.QTDE,
                            DATA_VENDA = d.DATA_VENDA
                        }).ToList();
                    }
                    btPasta.Enabled = true;
                }
            }
        }

        private void Relatorio_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(local + @"\" + txtNome.Text + ".pdf"))
            {
                if ((MessageBox.Show("Esse arquivo já existe, deseja substituilo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes))
                {
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Digite o nome do arquivo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNome.Focus();
                    }
                    else
                    {
                        //Creating iTextSharp Table from the DataTable data
                        PdfPTable pdfTable = new PdfPTable(dgvRelatorio.ColumnCount);
                        pdfTable.PaddingTop = 0;
                        pdfTable.DefaultCell.Padding = 4;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = 1;
                        pdfTable.DefaultCell.BorderWidth = 0;
                        //Adding Header row
                        foreach (DataGridViewColumn column in dgvRelatorio.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BorderColor = BaseColor.BLACK;
                            cell.BorderWidth = 0;
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            cell.Padding = 8;
                            cell.BorderWidthRight = 1;
                            cell.HorizontalAlignment = 1;
                            pdfTable.AddCell(cell);
                        }

                        //Adding DataRow
                        foreach (DataGridViewRow row in dgvRelatorio.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.DefaultCell.HorizontalAlignment = 1;
                                pdfTable.AddCell(cell.Value.ToString());
                            }

                        }

                        //Exporting to PDF
                        string folderPath = local + @"\";
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        using (FileStream stream = new FileStream(folderPath + txtNome.Text + ".pdf", FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A2, 100f, 100f, 100f, 30f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            //criando a variavel para paragrafo
                            Paragraph paragrafo = new Paragraph();
                            //etipulando o alinhamneto
                            paragrafo.Alignment = Element.ALIGN_CENTER;
                            paragrafo.Font.Size = 35;
                            //Alinhamento Justificado
                            //adicioando texto
                            paragrafo.Add("Relatorio de venda"); ;
                            Paragraph pa = new Paragraph();
                            //etipulando o alinhamneto
                            pa.Alignment = Element.ALIGN_CENTER;
                            pa.Font.Size = 35;
                            //Alinhamento Justificado
                            //adicioando texto
                            pa.Add("                                ");
                            Paragraph data = new Paragraph();
                            data.Alignment = Element.ALIGN_LEFT;
                            data.Font.Size = 15;
                            data.Add("Data: " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"));
                            Paragraph seicho = new Paragraph();
                            seicho.Alignment = Element.ALIGN_LEFT;
                            seicho.Font.Size = 15;
                            seicho.Add("Seicho No Ie - Núcleo Barretos");
                            Paragraph tipo = new Paragraph();
                            tipo.Alignment = Element.ALIGN_LEFT;
                            tipo.Font.Size = 15;
                            tipo.Add("Tipo: Relação completa de estoque.");
                            //acidionado paragrafo ao documento
                            pdfDoc.Add(paragrafo);
                            pdfDoc.Add(pa);
                            pdfDoc.Add(tipo);
                            pdfDoc.Add(seicho);
                            pdfDoc.Add(data);
                            pdfDoc.Add(pa);
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                            MessageBox.Show("Documendo gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            System.Diagnostics.Process.Start(folderPath + txtNome.Text + ".pdf");
                        }
                    }
                }
            }
            else
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Digite o nome do arquivo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                }
                else
                {
                    //Creating iTextSharp Table from the DataTable data
                    PdfPTable pdfTable = new PdfPTable(dgvRelatorio.ColumnCount);
                    pdfTable.PaddingTop = 0;
                    pdfTable.DefaultCell.Padding = 4;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = 1;
                    pdfTable.DefaultCell.BorderWidth = 0;
                    //Adding Header row
                    foreach (DataGridViewColumn column in dgvRelatorio.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BorderColor = BaseColor.BLACK;
                        cell.BorderWidth = 0;
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.Padding = 8;
                        cell.BorderWidthRight = 1;
                        cell.HorizontalAlignment = 1;
                        pdfTable.AddCell(cell);
                    }

                    //Adding DataRow
                    foreach (DataGridViewRow row in dgvRelatorio.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.DefaultCell.HorizontalAlignment = 1;
                            pdfTable.AddCell(cell.Value.ToString());
                        }

                    }

                    //Exporting to PDF
                    string folderPath = local + @"\";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    using (FileStream stream = new FileStream(folderPath + txtNome.Text + ".pdf", FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A2, 100f, 100f, 100f, 30f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        //criando a variavel para paragrafo
                        Paragraph paragrafo = new Paragraph();
                        //etipulando o alinhamneto
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Font.Size = 35;
                        //Alinhamento Justificado
                        //adicioando texto
                        paragrafo.Add("Relatorio de venda"); ;
                        Paragraph pa = new Paragraph();
                        //etipulando o alinhamneto
                        pa.Alignment = Element.ALIGN_CENTER;
                        pa.Font.Size = 35;
                        //Alinhamento Justificado
                        //adicioando texto
                        pa.Add("                                ");
                        Paragraph data = new Paragraph();
                        data.Alignment = Element.ALIGN_LEFT;
                        data.Font.Size = 15;
                        data.Add("Data: " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"));
                        Paragraph seicho = new Paragraph();
                        seicho.Alignment = Element.ALIGN_LEFT;
                        seicho.Font.Size = 15;
                        seicho.Add("Seicho No Ie - Núcleo Barretos");
                        Paragraph tipo = new Paragraph();
                        tipo.Alignment = Element.ALIGN_LEFT;
                        tipo.Font.Size = 15;
                        tipo.Add("Tipo: Relação completa de estoque.");
                        //acidionado paragrafo ao documento
                        pdfDoc.Add(paragrafo);
                        pdfDoc.Add(pa);
                        pdfDoc.Add(tipo);
                        pdfDoc.Add(seicho);
                        pdfDoc.Add(data);
                        pdfDoc.Add(pa);
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("Documendo gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start(folderPath + txtNome.Text + ".pdf");
                    }
                }
            }
        }

        private void btExcel_Click(object sender, EventArgs e)
        {

            //string caminho = @"C:\Users\Luiz Carlos B Pereir\Desktop\";

            //if (cboSGBD.SelectedIndex == 0)
            //{
            //    // criar um arquivo para escrever
            //    using (StreamWriter sw = File.CreateText(caminho))
            //    {
            //        //Monta a string de conexão para MS Access com os dados do formulário
            //        String conn = @"provider=Microsoft.Jet.OLEDB.4.0;data source = c:\dados\ " + txtBD.Text + ".mdb";
            //        OleDbConnection cn = new OleDbConnection(conn);
            //        OleDbCommand cmd = new OleDbCommand("SELECT * FROM " + txtTabela.Text, cn);
            //        try
            //        {
            //            cn.Open();
            //            OleDbDataReader dr = cmd.ExecuteReader();
            //            // percorre o datareader e escreve os dados no arquivo .xls definido
            //            while (dr.Read())
            //            {
            //                sw.WriteLine(dr["ProductName"].ToString() + "\t" + dr["UnitPrice"].ToString());
            //            }
            //            //exibe mensagem ao usuario
            //            MessageBox.Show("Arquivo " + caminho + " gerado com sucesso.");
            //        }
            //        catch (Exception excpt)
            //        {
            //            MessageBox.Show(excpt.Message);
            //        }
            //    }
            //}
        }

        private void rvDoc_Load(object sender, EventArgs e)
        {

        }

        private void btPasta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPasta.Text = folderBrowserDialog1.SelectedPath;
                local = folderBrowserDialog1.SelectedPath;
            }
        }

        private void dgvRelatorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtNome.Text != String.Empty && txtPasta.Text != String.Empty)
            {
                btOK.Enabled = true;
            }
            else
            {
                btOK.Enabled = false;
            }
            if (dgvRelacao.Rows.Count > 1)
                btPasta2.Enabled = true;
            if (txtNome2.Text != String.Empty && txtPasta2.Text != String.Empty)
            {
                btOk2.Enabled = true;
            }
            else
            {
                btOk2.Enabled = false;
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabRelacao.SelectedTab == tbRelacao)
                carregarDgv();

        }

        private void carregarDgv()
        {
            using (var db = new dbSgc())
            {
                dgvRelacao.DataSource = db.produtos.Select(d => new
                {
                    CODIGO = d.CODIGO,
                    DESCRIÇÃO = d.DESCRICAO,
                    ESTOQUE = d.QTDE,
                    DATA_DE_ENTRADA = d.DT_ENTRADA

                }).ToList();
            }
        }

        private void btOk2_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(local + @"\" + txtNome.Text + ".pdf"))
            {
                if ((MessageBox.Show("Esse arquivo já existe, deseja substituilo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes))
                {
                    if (txtNome2.Text == "")
                    {
                        MessageBox.Show("Digite o nome do arquivo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNome2.Focus();
                    }
                    else
                    {
                        //Creating iTextSharp Table from the DataTable data
                        PdfPTable pdfTable = new PdfPTable(dgvRelacao.ColumnCount);
                        pdfTable.PaddingTop = 0;
                        pdfTable.DefaultCell.Padding = 4;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = 1;
                        pdfTable.DefaultCell.BorderWidth = 0;
                        //Adding Header row
                        foreach (DataGridViewColumn column in dgvRelacao.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BorderColor = BaseColor.BLACK;
                            cell.BorderWidth = 0;
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            cell.Padding = 8;
                            cell.BorderWidthRight = 1;
                            cell.HorizontalAlignment = 1;
                            pdfTable.AddCell(cell);
                        }

                        //Adding DataRow
                        foreach (DataGridViewRow row in dgvRelacao.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.DefaultCell.HorizontalAlignment = 1;
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }

                        //Exporting to PDF
                        string folderPath = local2 + @"\";
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        using (FileStream stream = new FileStream(folderPath + txtNome2.Text + ".pdf", FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A2, 100f, 100f, 100f, 30f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            //criando a variavel para paragrafo
                            Paragraph paragrafo = new Paragraph();
                            //etipulando o alinhamneto
                            paragrafo.Alignment = Element.ALIGN_CENTER;
                            paragrafo.Font.Size = 35;
                            //Alinhamento Justificado
                            //adicioando texto
                            paragrafo.Add("Controle de Estoque Geral");
                            Paragraph pa = new Paragraph();
                            //etipulando o alinhamneto
                            pa.Alignment = Element.ALIGN_CENTER;
                            pa.Font.Size = 35;
                            //Alinhamento Justificado
                            //adicioando texto
                            pa.Add("                                ");
                            Paragraph data = new Paragraph();
                            data.Alignment = Element.ALIGN_LEFT;
                            data.Font.Size = 15;
                            data.Add("Data: " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"));
                            Paragraph seicho = new Paragraph();
                            seicho.Alignment = Element.ALIGN_LEFT;
                            seicho.Font.Size = 15;
                            seicho.Add("Seicho No Ie - Núcleo Barretos");
                            Paragraph tipo = new Paragraph();
                            tipo.Alignment = Element.ALIGN_LEFT;
                            tipo.Font.Size = 15;
                            tipo.Add("Tipo: Relação completa de estoque.");
                            //acidionado paragrafo ao documento
                            pdfDoc.Add(paragrafo);
                            pdfDoc.Add(pa);
                            pdfDoc.Add(tipo);
                            pdfDoc.Add(seicho);
                            pdfDoc.Add(data);
                            pdfDoc.Add(pa);
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                            MessageBox.Show("Documendo gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            System.Diagnostics.Process.Start(folderPath + txtNome2.Text + ".pdf");
                        }
                    }
                }
            }
            else
            {
                if (txtNome2.Text == "")
                {
                    MessageBox.Show("Digite o nome do arquivo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome2.Focus();
                }
                else
                {
                    //Creating iTextSharp Table from the DataTable data
                    PdfPTable pdfTable = new PdfPTable(dgvRelacao.ColumnCount);
                    pdfTable.PaddingTop = 0;
                    pdfTable.DefaultCell.Padding = 4;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = 1;
                    pdfTable.DefaultCell.BorderWidth = 0;
                    //Adding Header row
                    foreach (DataGridViewColumn column in dgvRelacao.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BorderColor = BaseColor.BLACK;
                        cell.BorderWidth = 0;
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.Padding = 8;
                        cell.BorderWidthRight = 1;
                        cell.HorizontalAlignment = 1;
                        pdfTable.AddCell(cell);
                    }

                    //Adding DataRow
                    foreach (DataGridViewRow row in dgvRelacao.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.DefaultCell.HorizontalAlignment = 1;
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }

                    //Exporting to PDF
                    string folderPath = local2 + @"\";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    using (FileStream stream = new FileStream(folderPath + txtNome2.Text + ".pdf", FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A2, 100f, 100f, 100f, 30f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        //criando a variavel para paragrafo
                        Paragraph paragrafo = new Paragraph();
                        //etipulando o alinhamneto
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Font.Size = 35;
                        //Alinhamento Justificado
                        //adicioando texto
                        paragrafo.Add("Controle de Estoque Geral");
                        Paragraph pa = new Paragraph();
                        //etipulando o alinhamneto
                        pa.Alignment = Element.ALIGN_CENTER;
                        pa.Font.Size = 35;
                        //Alinhamento Justificado
                        //adicioando texto
                        pa.Add("                                ");
                        Paragraph data = new Paragraph();
                        data.Alignment = Element.ALIGN_LEFT;
                        data.Font.Size = 15;
                        data.Add("Data: " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"));
                        Paragraph seicho = new Paragraph();
                        seicho.Alignment = Element.ALIGN_LEFT;
                        seicho.Font.Size = 15;
                        seicho.Add("Seicho No Ie - Núcleo Barretos");
                        Paragraph tipo = new Paragraph();
                        tipo.Alignment = Element.ALIGN_LEFT;
                        tipo.Font.Size = 15;
                        tipo.Add("Tipo: Relação completa de estoque.");
                        //acidionado paragrafo ao documento
                        pdfDoc.Add(paragrafo);
                        pdfDoc.Add(pa);
                        pdfDoc.Add(tipo);
                        pdfDoc.Add(seicho);
                        pdfDoc.Add(data);
                        pdfDoc.Add(pa);
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("Documendo gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start(folderPath + txtNome2.Text + ".pdf");
                    }
                }
            }
        }

        private void btPasta2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPasta2.Text = folderBrowserDialog1.SelectedPath;
                local2 = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
