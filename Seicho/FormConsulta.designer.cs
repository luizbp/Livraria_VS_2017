namespace Seicho
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.venderPeçaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPesqPecasVend = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvPecasVendidas = new System.Windows.Forms.DataGridView();
            this.tabPecasVendidas = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mskFiltro = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPeca = new System.Windows.Forms.TabPage();
            this.tbConsulta = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecasVendidas)).BeginInit();
            this.tabPecasVendidas.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPeca.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // venderPeçaToolStripMenuItem
            // 
            this.venderPeçaToolStripMenuItem.Name = "venderPeçaToolStripMenuItem";
            this.venderPeçaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.venderPeçaToolStripMenuItem.Text = "Vender Peça";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderPeçaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 26);
            // 
            // txtPesqPecasVend
            // 
            this.txtPesqPecasVend.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesqPecasVend.Location = new System.Drawing.Point(17, 25);
            this.txtPesqPecasVend.Name = "txtPesqPecasVend";
            this.txtPesqPecasVend.Size = new System.Drawing.Size(846, 20);
            this.txtPesqPecasVend.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(869, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pesquisar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPesqPecasVend);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(8, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(990, 67);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pesquisa";
            // 
            // dgvPecasVendidas
            // 
            this.dgvPecasVendidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPecasVendidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPecasVendidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecasVendidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPecasVendidas.Location = new System.Drawing.Point(3, 16);
            this.dgvPecasVendidas.Name = "dgvPecasVendidas";
            this.dgvPecasVendidas.ReadOnly = true;
            this.dgvPecasVendidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPecasVendidas.Size = new System.Drawing.Size(989, 502);
            this.dgvPecasVendidas.TabIndex = 0;
            // 
            // tabPecasVendidas
            // 
            this.tabPecasVendidas.Controls.Add(this.groupBox4);
            this.tabPecasVendidas.Controls.Add(this.groupBox5);
            this.tabPecasVendidas.Location = new System.Drawing.Point(4, 22);
            this.tabPecasVendidas.Name = "tabPecasVendidas";
            this.tabPecasVendidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPecasVendidas.Size = new System.Drawing.Size(1007, 610);
            this.tabPecasVendidas.TabIndex = 1;
            this.tabPecasVendidas.Text = "Consulta de Vendas";
            this.tabPecasVendidas.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPecasVendidas);
            this.groupBox4.Location = new System.Drawing.Point(6, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(995, 521);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // mskFiltro
            // 
            this.mskFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mskFiltro.FormattingEnabled = true;
            this.mskFiltro.Items.AddRange(new object[] {
            "CODIGO",
            "DESCRIÇÃO"});
            this.mskFiltro.Location = new System.Drawing.Point(11, 24);
            this.mskFiltro.Name = "mskFiltro";
            this.mskFiltro.Size = new System.Drawing.Size(97, 21);
            this.mskFiltro.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(869, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(4, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 514);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPesquisa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPesquisa.Location = new System.Drawing.Point(3, 16);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(989, 495);
            this.dgvPesquisa.TabIndex = 0;
            this.dgvPesquisa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPesquisa_CellFormatting);
            // 
            // txtPesq
            // 
            this.txtPesq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesq.Location = new System.Drawing.Point(120, 31);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(749, 20);
            this.txtPesq.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskFiltro);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 74);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // tabPeca
            // 
            this.tabPeca.Controls.Add(this.groupBox1);
            this.tabPeca.Controls.Add(this.txtPesq);
            this.tabPeca.Controls.Add(this.groupBox2);
            this.tabPeca.Location = new System.Drawing.Point(4, 22);
            this.tabPeca.Name = "tabPeca";
            this.tabPeca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPeca.Size = new System.Drawing.Size(1007, 610);
            this.tabPeca.TabIndex = 0;
            this.tabPeca.Text = "Consultar Produtos";
            this.tabPeca.UseVisualStyleBackColor = true;
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(this.tabPeca);
            this.tbConsulta.Controls.Add(this.tabPecasVendidas);
            this.tbConsulta.Location = new System.Drawing.Point(10, 11);
            this.tbConsulta.Name = "tbConsulta";
            this.tbConsulta.SelectedIndex = 0;
            this.tbConsulta.Size = new System.Drawing.Size(1015, 636);
            this.tbConsulta.TabIndex = 5;
            this.tbConsulta.Click += new System.EventHandler(this.tbConsulta_Click);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 658);
            this.Controls.Add(this.tbConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsulta_KeyDown_1);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecasVendidas)).EndInit();
            this.tabPecasVendidas.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPeca.ResumeLayout(false);
            this.tabPeca.PerformLayout();
            this.tbConsulta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem venderPeçaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPesqPecasVend;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvPecasVendidas;
        private System.Windows.Forms.TabPage tabPecasVendidas;
        private System.Windows.Forms.GroupBox groupBox4;
        protected System.Windows.Forms.ComboBox mskFiltro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPeca;
        private System.Windows.Forms.TabControl tbConsulta;
    }
}