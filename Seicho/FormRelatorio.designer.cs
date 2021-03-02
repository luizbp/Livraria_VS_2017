namespace Seicho
{
    partial class FormRelatorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btExcel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.gbTipos = new System.Windows.Forms.GroupBox();
            this.btCarregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.rbPer = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbHoje = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btPasta = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tbGerar = new System.Windows.Forms.TabPage();
            this.txtPasta = new System.Windows.Forms.TextBox();
            this.tabRelacao = new System.Windows.Forms.TabControl();
            this.tbRelacao = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btPasta2 = new System.Windows.Forms.Button();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.txtPasta2 = new System.Windows.Forms.TextBox();
            this.btOk2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRelacao = new System.Windows.Forms.DataGridView();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.gbTipos.SuspendLayout();
            this.tbGerar.SuspendLayout();
            this.tabRelacao.SuspendLayout();
            this.tbRelacao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacao)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbData
            // 
            this.gbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbData.Controls.Add(this.dgvRelatorio);
            this.gbData.Location = new System.Drawing.Point(6, 68);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(1023, 460);
            this.gbData.TabIndex = 7;
            this.gbData.TabStop = false;
            // 
            // dgvRelatorio
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvRelatorio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelatorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRelatorio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRelatorio.Enabled = false;
            this.dgvRelatorio.Location = new System.Drawing.Point(3, 16);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.ReadOnly = true;
            this.dgvRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorio.Size = new System.Drawing.Size(1017, 441);
            this.dgvRelatorio.TabIndex = 0;
            // 
            // btExcel
            // 
            this.btExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcel.Enabled = false;
            this.btExcel.FlatAppearance.BorderSize = 2;
            this.btExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btExcel.Image = ((System.Drawing.Image)(resources.GetObject("btExcel.Image")));
            this.btExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcel.Location = new System.Drawing.Point(687, 550);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(168, 54);
            this.btExcel.TabIndex = 9;
            this.btExcel.Text = "Excel";
            this.btExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Visible = false;
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.Enabled = false;
            this.btOK.FlatAppearance.BorderSize = 2;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btOK.Image = ((System.Drawing.Image)(resources.GetObject("btOK.Image")));
            this.btOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOK.Location = new System.Drawing.Point(861, 550);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(168, 54);
            this.btOK.TabIndex = 9;
            this.btOK.Text = "PDF";
            this.btOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // gbTipos
            // 
            this.gbTipos.Controls.Add(this.btCarregar);
            this.gbTipos.Controls.Add(this.label2);
            this.gbTipos.Controls.Add(this.label1);
            this.gbTipos.Controls.Add(this.dtpAte);
            this.gbTipos.Controls.Add(this.dtpDe);
            this.gbTipos.Controls.Add(this.rbPer);
            this.gbTipos.Controls.Add(this.rbTodos);
            this.gbTipos.Controls.Add(this.rbHoje);
            this.gbTipos.Location = new System.Drawing.Point(6, 9);
            this.gbTipos.Name = "gbTipos";
            this.gbTipos.Size = new System.Drawing.Size(1023, 53);
            this.gbTipos.TabIndex = 8;
            this.gbTipos.TabStop = false;
            this.gbTipos.Text = "Filtros";
            // 
            // btCarregar
            // 
            this.btCarregar.Location = new System.Drawing.Point(880, 23);
            this.btCarregar.Name = "btCarregar";
            this.btCarregar.Size = new System.Drawing.Size(75, 23);
            this.btCarregar.TabIndex = 4;
            this.btCarregar.Text = "Carregar";
            this.btCarregar.UseVisualStyleBackColor = true;
            this.btCarregar.Click += new System.EventHandler(this.btCarregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(591, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "De:";
            // 
            // dtpAte
            // 
            this.dtpAte.Location = new System.Drawing.Point(621, 25);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(240, 20);
            this.dtpAte.TabIndex = 1;
            this.dtpAte.Value = new System.DateTime(2016, 8, 11, 0, 0, 0, 0);
            this.dtpAte.ValueChanged += new System.EventHandler(this.dtpAte_ValueChanged);
            // 
            // dtpDe
            // 
            this.dtpDe.Location = new System.Drawing.Point(356, 25);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(229, 20);
            this.dtpDe.TabIndex = 1;
            this.dtpDe.Value = new System.DateTime(2016, 8, 11, 0, 0, 0, 0);
            this.dtpDe.ValueChanged += new System.EventHandler(this.dtpDe_ValueChanged);
            // 
            // rbPer
            // 
            this.rbPer.AutoSize = true;
            this.rbPer.Location = new System.Drawing.Point(236, 25);
            this.rbPer.Name = "rbPer";
            this.rbPer.Size = new System.Drawing.Size(94, 17);
            this.rbPer.TabIndex = 0;
            this.rbPer.TabStop = true;
            this.rbPer.Text = "Personalizado.";
            this.rbPer.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(122, 25);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(100, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos registros.";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbHoje
            // 
            this.rbHoje.AutoSize = true;
            this.rbHoje.Location = new System.Drawing.Point(6, 25);
            this.rbHoje.Name = "rbHoje";
            this.rbHoje.Size = new System.Drawing.Size(110, 17);
            this.rbHoje.TabIndex = 0;
            this.rbHoje.TabStop = true;
            this.rbHoje.Text = "Registros de hoje.";
            this.rbHoje.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome do arquivo:";
            // 
            // btPasta
            // 
            this.btPasta.Enabled = false;
            this.btPasta.Location = new System.Drawing.Point(12, 550);
            this.btPasta.Name = "btPasta";
            this.btPasta.Size = new System.Drawing.Size(108, 23);
            this.btPasta.TabIndex = 11;
            this.btPasta.Text = "Selecionar pasta:";
            this.btPasta.UseVisualStyleBackColor = true;
            this.btPasta.Click += new System.EventHandler(this.btPasta_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 582);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 10;
            // 
            // tbGerar
            // 
            this.tbGerar.Controls.Add(this.label3);
            this.tbGerar.Controls.Add(this.btPasta);
            this.tbGerar.Controls.Add(this.txtNome);
            this.tbGerar.Controls.Add(this.txtPasta);
            this.tbGerar.Controls.Add(this.btExcel);
            this.tbGerar.Controls.Add(this.btOK);
            this.tbGerar.Controls.Add(this.gbTipos);
            this.tbGerar.Controls.Add(this.gbData);
            this.tbGerar.Location = new System.Drawing.Point(4, 22);
            this.tbGerar.Name = "tbGerar";
            this.tbGerar.Padding = new System.Windows.Forms.Padding(3);
            this.tbGerar.Size = new System.Drawing.Size(1035, 618);
            this.tbGerar.TabIndex = 0;
            this.tbGerar.Text = "Relatorio de Vendas";
            this.tbGerar.UseVisualStyleBackColor = true;
            // 
            // txtPasta
            // 
            this.txtPasta.Location = new System.Drawing.Point(122, 552);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.ReadOnly = true;
            this.txtPasta.Size = new System.Drawing.Size(197, 20);
            this.txtPasta.TabIndex = 10;
            // 
            // tabRelacao
            // 
            this.tabRelacao.Controls.Add(this.tbGerar);
            this.tabRelacao.Controls.Add(this.tbRelacao);
            this.tabRelacao.Location = new System.Drawing.Point(9, 7);
            this.tabRelacao.Name = "tabRelacao";
            this.tabRelacao.SelectedIndex = 0;
            this.tabRelacao.Size = new System.Drawing.Size(1043, 644);
            this.tabRelacao.TabIndex = 2;
            this.tabRelacao.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tbRelacao
            // 
            this.tbRelacao.Controls.Add(this.label4);
            this.tbRelacao.Controls.Add(this.btPasta2);
            this.tbRelacao.Controls.Add(this.txtNome2);
            this.tbRelacao.Controls.Add(this.txtPasta2);
            this.tbRelacao.Controls.Add(this.btOk2);
            this.tbRelacao.Controls.Add(this.groupBox1);
            this.tbRelacao.Location = new System.Drawing.Point(4, 22);
            this.tbRelacao.Name = "tbRelacao";
            this.tbRelacao.Padding = new System.Windows.Forms.Padding(3);
            this.tbRelacao.Size = new System.Drawing.Size(1035, 618);
            this.tbRelacao.TabIndex = 1;
            this.tbRelacao.Text = "Relação de Peças";
            this.tbRelacao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nome do arquivo:";
            // 
            // btPasta2
            // 
            this.btPasta2.Enabled = false;
            this.btPasta2.Location = new System.Drawing.Point(12, 523);
            this.btPasta2.Name = "btPasta2";
            this.btPasta2.Size = new System.Drawing.Size(108, 23);
            this.btPasta2.TabIndex = 18;
            this.btPasta2.Text = "Selecionar pasta:";
            this.btPasta2.UseVisualStyleBackColor = true;
            this.btPasta2.Click += new System.EventHandler(this.btPasta2_Click);
            // 
            // txtNome2
            // 
            this.txtNome2.Location = new System.Drawing.Point(106, 555);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(213, 20);
            this.txtNome2.TabIndex = 16;
            // 
            // txtPasta2
            // 
            this.txtPasta2.Location = new System.Drawing.Point(122, 525);
            this.txtPasta2.Name = "txtPasta2";
            this.txtPasta2.ReadOnly = true;
            this.txtPasta2.Size = new System.Drawing.Size(197, 20);
            this.txtPasta2.TabIndex = 17;
            // 
            // btOk2
            // 
            this.btOk2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk2.Enabled = false;
            this.btOk2.FlatAppearance.BorderSize = 2;
            this.btOk2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btOk2.Image = ((System.Drawing.Image)(resources.GetObject("btOk2.Image")));
            this.btOk2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOk2.Location = new System.Drawing.Point(861, 523);
            this.btOk2.Name = "btOk2";
            this.btOk2.Size = new System.Drawing.Size(168, 54);
            this.btOk2.TabIndex = 15;
            this.btOk2.Text = "PDF";
            this.btOk2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOk2.UseVisualStyleBackColor = true;
            this.btOk2.Click += new System.EventHandler(this.btOk2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvRelacao);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 495);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peças";
            // 
            // dgvRelacao
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvRelacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRelacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRelacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRelacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRelacao.Enabled = false;
            this.dgvRelacao.Location = new System.Drawing.Point(3, 16);
            this.dgvRelacao.Name = "dgvRelacao";
            this.dgvRelacao.ReadOnly = true;
            this.dgvRelacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelacao.Size = new System.Drawing.Size(1017, 476);
            this.dgvRelacao.TabIndex = 0;
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 659);
            this.Controls.Add(this.tabRelacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.MaximumSizeChanged += new System.EventHandler(this.Relatorio_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.gbTipos.ResumeLayout(false);
            this.gbTipos.PerformLayout();
            this.tbGerar.ResumeLayout(false);
            this.tbGerar.PerformLayout();
            this.tabRelacao.ResumeLayout(false);
            this.tbRelacao.ResumeLayout(false);
            this.tbRelacao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.GroupBox gbTipos;
        private System.Windows.Forms.Button btCarregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.RadioButton rbPer;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbHoje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPasta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TabPage tbGerar;
        private System.Windows.Forms.TextBox txtPasta;
        private System.Windows.Forms.TabControl tabRelacao;
        private System.Windows.Forms.TabPage tbRelacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btPasta2;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.TextBox txtPasta2;
        private System.Windows.Forms.Button btOk2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRelacao;
    }
}