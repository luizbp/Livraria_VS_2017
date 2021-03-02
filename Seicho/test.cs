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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void btCarregar_Click(object sender, EventArgs e)
        {
            using (var db = new dbSgc())
            {
                int count = db.produtos.Count();
                for(int op = 1; op <= count; op++)
                {
                    produtos po = db.produtos.Find(op);
                    dgvtest.Rows.Add(po.CODIGO, po.DESCRICAO, po.QTDE, po.INFO_ADICIONAIS);
                }

            }
        }
    }
}
