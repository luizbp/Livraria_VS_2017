namespace Seicho
{
    partial class FormEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrada));
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tmEntrada = new System.Windows.Forms.Timer(this.components);
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.rtbAdicionais = new System.Windows.Forms.RichTextBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvPecas = new System.Windows.Forms.DataGridView();
            this.gbPecas = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQunt2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btAdicionar2 = new System.Windows.Forms.Button();
            this.btPesqPeca = new System.Windows.Forms.Button();
            this.txtDescPeca = new System.Windows.Forms.TextBox();
            this.txtIDPeca = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbInformacoes.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).BeginInit();
            this.gbPecas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(692, 690);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tmEntrada
            // 
            this.tmEntrada.Tick += new System.EventHandler(this.tmEntrada_Tick);
            // 
            // gbInformacoes
            // 
            this.gbInformacoes.Controls.Add(this.rtbAdicionais);
            this.gbInformacoes.Controls.Add(this.btAdicionar);
            this.gbInformacoes.Controls.Add(this.txtQuant);
            this.gbInformacoes.Controls.Add(this.txtCodigo);
            this.gbInformacoes.Controls.Add(this.txtDescricao);
            this.gbInformacoes.Controls.Add(this.label7);
            this.gbInformacoes.Controls.Add(this.label1);
            this.gbInformacoes.Controls.Add(this.label2);
            this.gbInformacoes.Controls.Add(this.label3);
            this.gbInformacoes.Controls.Add(this.label8);
            this.gbInformacoes.Controls.Add(this.label6);
            this.gbInformacoes.Controls.Add(this.label5);
            this.gbInformacoes.Controls.Add(this.label4);
            this.gbInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacoes.Location = new System.Drawing.Point(12, 109);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Size = new System.Drawing.Size(752, 166);
            this.gbInformacoes.TabIndex = 44;
            this.gbInformacoes.TabStop = false;
            this.gbInformacoes.Text = "Adicionar Novo";
            // 
            // rtbAdicionais
            // 
            this.rtbAdicionais.Location = new System.Drawing.Point(19, 76);
            this.rtbAdicionais.Name = "rtbAdicionais";
            this.rtbAdicionais.Size = new System.Drawing.Size(635, 63);
            this.rtbAdicionais.TabIndex = 3;
            this.rtbAdicionais.Text = "";
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAdicionar.BackgroundImage")));
            this.btAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Location = new System.Drawing.Point(708, 105);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(35, 34);
            this.btAdicionar.TabIndex = 4;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(661, 32);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(73, 20);
            this.txtQuant.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(19, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(124, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(149, 33);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(505, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informações adicionais:\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(557, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Campos com * são obrigatorios!!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(647, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(658, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantidade:";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // dgvPecas
            // 
            this.dgvPecas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPecas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecas.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPecas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPecas.Location = new System.Drawing.Point(3, 16);
            this.dgvPecas.Name = "dgvPecas";
            this.dgvPecas.ReadOnly = true;
            this.dgvPecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPecas.Size = new System.Drawing.Size(749, 384);
            this.dgvPecas.TabIndex = 5;
            this.dgvPecas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPecas_MouseDown);
            // 
            // gbPecas
            // 
            this.gbPecas.Controls.Add(this.dgvPecas);
            this.gbPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPecas.Location = new System.Drawing.Point(12, 281);
            this.gbPecas.Name = "gbPecas";
            this.gbPecas.Size = new System.Drawing.Size(755, 403);
            this.gbPecas.TabIndex = 41;
            this.gbPecas.TabStop = false;
            this.gbPecas.Text = "Produtos Adicionadas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQunt2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btAdicionar2);
            this.groupBox1.Controls.Add(this.btPesqPeca);
            this.groupBox1.Controls.Add(this.txtDescPeca);
            this.groupBox1.Controls.Add(this.txtIDPeca);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 91);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Existente";
            // 
            // txtQunt2
            // 
            this.txtQunt2.Location = new System.Drawing.Point(601, 44);
            this.txtQunt2.Name = "txtQunt2";
            this.txtQunt2.Size = new System.Drawing.Size(100, 20);
            this.txtQunt2.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(598, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Quantidade:";
            // 
            // btAdicionar2
            // 
            this.btAdicionar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAdicionar2.BackgroundImage")));
            this.btAdicionar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdicionar2.FlatAppearance.BorderSize = 0;
            this.btAdicionar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar2.Location = new System.Drawing.Point(707, 36);
            this.btAdicionar2.Name = "btAdicionar2";
            this.btAdicionar2.Size = new System.Drawing.Size(35, 34);
            this.btAdicionar2.TabIndex = 56;
            this.btAdicionar2.UseVisualStyleBackColor = true;
            this.btAdicionar2.Click += new System.EventHandler(this.btAdicionar2_Click);
            // 
            // btPesqPeca
            // 
            this.btPesqPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesqPeca.BackgroundImage")));
            this.btPesqPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesqPeca.FlatAppearance.BorderSize = 0;
            this.btPesqPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqPeca.Location = new System.Drawing.Point(560, 36);
            this.btPesqPeca.Name = "btPesqPeca";
            this.btPesqPeca.Size = new System.Drawing.Size(35, 34);
            this.btPesqPeca.TabIndex = 55;
            this.btPesqPeca.UseVisualStyleBackColor = true;
            this.btPesqPeca.Click += new System.EventHandler(this.btPesqPeca_Click);
            // 
            // txtDescPeca
            // 
            this.txtDescPeca.Location = new System.Drawing.Point(87, 44);
            this.txtDescPeca.Name = "txtDescPeca";
            this.txtDescPeca.ReadOnly = true;
            this.txtDescPeca.Size = new System.Drawing.Size(467, 20);
            this.txtDescPeca.TabIndex = 53;
            // 
            // txtIDPeca
            // 
            this.txtIDPeca.Location = new System.Drawing.Point(11, 44);
            this.txtIDPeca.Name = "txtIDPeca";
            this.txtIDPeca.ReadOnly = true;
            this.txtIDPeca.Size = new System.Drawing.Size(70, 20);
            this.txtIDPeca.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Produtos:";
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 717);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.gbInformacoes);
            this.Controls.Add(this.gbPecas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEntrada_FormClosing);
            this.Load += new System.EventHandler(this.FormEntrada_Load);
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).EndInit();
            this.gbPecas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Timer tmEntrada;
        private System.Windows.Forms.GroupBox gbInformacoes;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvPecas;
        private System.Windows.Forms.GroupBox gbPecas;
        private System.Windows.Forms.RichTextBox rtbAdicionais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQunt2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btAdicionar2;
        private System.Windows.Forms.Button btPesqPeca;
        private System.Windows.Forms.TextBox txtDescPeca;
        private System.Windows.Forms.TextBox txtIDPeca;
        private System.Windows.Forms.Label label10;
    }
}