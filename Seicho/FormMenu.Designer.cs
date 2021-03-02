namespace Seicho
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUsu = new System.Windows.Forms.ToolStripStatusLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuConsulta,
            this.MenuEntrada,
            this.MenuSaida,
            this.MenuRelatorio,
            this.MenuInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 87);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuConsulta
            // 
            this.MenuConsulta.Image = ((System.Drawing.Image)(resources.GetObject("MenuConsulta.Image")));
            this.MenuConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuConsulta.Name = "MenuConsulta";
            this.MenuConsulta.Size = new System.Drawing.Size(76, 83);
            this.MenuConsulta.Text = "Consulta";
            this.MenuConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuConsulta.Click += new System.EventHandler(this.MenuConsulta_Click);
            // 
            // MenuEntrada
            // 
            this.MenuEntrada.Image = ((System.Drawing.Image)(resources.GetObject("MenuEntrada.Image")));
            this.MenuEntrada.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuEntrada.Name = "MenuEntrada";
            this.MenuEntrada.Size = new System.Drawing.Size(116, 83);
            this.MenuEntrada.Text = "Cadastro de Livros";
            this.MenuEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuEntrada.Click += new System.EventHandler(this.MenuEntrada_Click);
            // 
            // MenuSaida
            // 
            this.MenuSaida.Image = ((System.Drawing.Image)(resources.GetObject("MenuSaida.Image")));
            this.MenuSaida.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuSaida.Name = "MenuSaida";
            this.MenuSaida.Size = new System.Drawing.Size(97, 83);
            this.MenuSaida.Text = "Saida de Livros";
            this.MenuSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuSaida.Click += new System.EventHandler(this.MenuSaida_Click);
            // 
            // MenuRelatorio
            // 
            this.MenuRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("MenuRelatorio.Image")));
            this.MenuRelatorio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuRelatorio.Name = "MenuRelatorio";
            this.MenuRelatorio.Size = new System.Drawing.Size(76, 83);
            this.MenuRelatorio.Text = "Relatorio";
            this.MenuRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuRelatorio.Click += new System.EventHandler(this.MenuRelatorio_Click);
            // 
            // MenuInfo
            // 
            this.MenuInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuInfo.Image = ((System.Drawing.Image)(resources.GetObject("MenuInfo.Image")));
            this.MenuInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInfo.Name = "MenuInfo";
            this.MenuInfo.Size = new System.Drawing.Size(85, 83);
            this.MenuInfo.Text = "Informações";
            this.MenuInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuInfo.Click += new System.EventHandler(this.MenuInfo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtUsu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 668);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1085, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // txtUsu
            // 
            this.txtUsu.Font = new System.Drawing.Font("Segoe UI", 9.3F, System.Drawing.FontStyle.Bold);
            this.txtUsu.ForeColor = System.Drawing.Color.Maroon;
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(85, 17);
            this.txtUsu.Text = "Seicho No Ie";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar1.Location = new System.Drawing.Point(18, 497);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 690);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuConsulta;
        private System.Windows.Forms.ToolStripMenuItem MenuEntrada;
        private System.Windows.Forms.ToolStripMenuItem MenuSaida;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem MenuInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtUsu;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

