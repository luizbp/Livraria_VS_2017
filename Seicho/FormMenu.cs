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
    public partial class FormMenu : Form
    {
        int IDUser;
        public FormMenu()
        {
            try
            {
                using (var db = new dbSgc())
                {
                    int op = db.produtos.Count();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o banco!! \n     Contate o administrador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            InitializeComponent();
        }

        private void MenuConsulta_Click(object sender, EventArgs e)
        {
            FormConsulta fo = new FormConsulta();
            fo.WindowState = FormWindowState.Normal;
            fo.StartPosition = FormStartPosition.CenterParent;
            fo.ShowDialog();
        }

        private void MenuEntrada_Click(object sender, EventArgs e)
        {
            FormEntrada fo = new FormEntrada();
            fo.WindowState = FormWindowState.Normal;
            fo.StartPosition = FormStartPosition.CenterParent;
            fo.ShowDialog();

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else e.Cancel = true;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void MenuSaida_Click(object sender, EventArgs e)
        {
            FormSaida fo = new FormSaida();
            fo.WindowState = FormWindowState.Normal;
            fo.StartPosition = FormStartPosition.CenterParent;
            fo.ShowDialog();
        }

        private void MenuRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio fo = new FormRelatorio();
            fo.WindowState = FormWindowState.Normal;
            fo.StartPosition = FormStartPosition.CenterParent;
            fo.ShowDialog();
        }

        private void MenuOrcamento_Click(object sender, EventArgs e)
        {

        }

        private void MenuInfo_Click(object sender, EventArgs e)
        {
            FormInfo fo = new FormInfo();
            fo.WindowState = FormWindowState.Normal;
            fo.StartPosition = FormStartPosition.CenterParent;
            fo.ShowDialog();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Environment.Exit(0);
            }
            else
                e.Cancel = true;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
