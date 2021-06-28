namespace CNF
{
    partial class CNF
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
            this.lstCb = new System.Windows.Forms.ListBox();
            this.lstEn = new System.Windows.Forms.ListBox();
            this.txtVl = new System.Windows.Forms.TextBox();
            this.lblCb = new System.Windows.Forms.Label();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblVl = new System.Windows.Forms.Label();
            this.cmdSv = new System.Windows.Forms.Button();
            this.cmdEx = new System.Windows.Forms.Button();
            this.cmdAd = new System.Windows.Forms.Button();
            this.mn = new System.Windows.Forms.MenuStrip();
            this.mnA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnE = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEA = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgAb = new System.Windows.Forms.OpenFileDialog();
            this.txtNCb = new System.Windows.Forms.TextBox();
            this.txtNEn = new System.Windows.Forms.TextBox();
            this.txtNVl = new System.Windows.Forms.TextBox();
            this.lblNCb = new System.Windows.Forms.Label();
            this.lblNEn = new System.Windows.Forms.Label();
            this.LblNVl = new System.Windows.Forms.Label();
            this.mn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCb
            // 
            this.lstCb.FormattingEnabled = true;
            this.lstCb.Location = new System.Drawing.Point(15, 162);
            this.lstCb.Name = "lstCb";
            this.lstCb.Size = new System.Drawing.Size(182, 199);
            this.lstCb.TabIndex = 0;
            this.lstCb.SelectedIndexChanged += new System.EventHandler(this.lstCb_SelectedIndexChanged);
            // 
            // lstEn
            // 
            this.lstEn.FormattingEnabled = true;
            this.lstEn.Location = new System.Drawing.Point(203, 162);
            this.lstEn.Name = "lstEn";
            this.lstEn.Size = new System.Drawing.Size(185, 199);
            this.lstEn.TabIndex = 1;
            this.lstEn.SelectedIndexChanged += new System.EventHandler(this.lstEn_SelectedIndexChanged);
            // 
            // txtVl
            // 
            this.txtVl.Location = new System.Drawing.Point(394, 162);
            this.txtVl.Multiline = true;
            this.txtVl.Name = "txtVl";
            this.txtVl.Size = new System.Drawing.Size(141, 75);
            this.txtVl.TabIndex = 2;
            // 
            // lblCb
            // 
            this.lblCb.AutoSize = true;
            this.lblCb.Location = new System.Drawing.Point(12, 146);
            this.lblCb.Margin = new System.Windows.Forms.Padding(3);
            this.lblCb.Name = "lblCb";
            this.lblCb.Size = new System.Drawing.Size(58, 13);
            this.lblCb.TabIndex = 3;
            this.lblCb.Text = "Cabeçalho";
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Location = new System.Drawing.Point(200, 146);
            this.lblEn.Margin = new System.Windows.Forms.Padding(3);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(44, 13);
            this.lblEn.TabIndex = 4;
            this.lblEn.Text = "Entrada";
            // 
            // lblVl
            // 
            this.lblVl.AutoSize = true;
            this.lblVl.Location = new System.Drawing.Point(391, 146);
            this.lblVl.Margin = new System.Windows.Forms.Padding(3);
            this.lblVl.Name = "lblVl";
            this.lblVl.Size = new System.Drawing.Size(31, 13);
            this.lblVl.TabIndex = 5;
            this.lblVl.Text = "Valor";
            // 
            // cmdSv
            // 
            this.cmdSv.Location = new System.Drawing.Point(394, 241);
            this.cmdSv.Name = "cmdSv";
            this.cmdSv.Size = new System.Drawing.Size(141, 23);
            this.cmdSv.TabIndex = 6;
            this.cmdSv.Text = "&Salvar";
            this.cmdSv.UseVisualStyleBackColor = true;
            this.cmdSv.Click += new System.EventHandler(this.cmdSv_Click);
            // 
            // cmdEx
            // 
            this.cmdEx.Location = new System.Drawing.Point(394, 266);
            this.cmdEx.Name = "cmdEx";
            this.cmdEx.Size = new System.Drawing.Size(141, 23);
            this.cmdEx.TabIndex = 7;
            this.cmdEx.Text = "E&xcluir";
            this.cmdEx.UseVisualStyleBackColor = true;
            // 
            // cmdAd
            // 
            this.cmdAd.Location = new System.Drawing.Point(394, 117);
            this.cmdAd.Name = "cmdAd";
            this.cmdAd.Size = new System.Drawing.Size(141, 23);
            this.cmdAd.TabIndex = 8;
            this.cmdAd.Text = "A&dicionar";
            this.cmdAd.UseVisualStyleBackColor = true;
            this.cmdAd.Click += new System.EventHandler(this.cmdAd_Click);
            // 
            // mn
            // 
            this.mn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnA,
            this.mnE});
            this.mn.Location = new System.Drawing.Point(0, 0);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(543, 29);
            this.mn.TabIndex = 9;
            this.mn.Text = "menuStrip1";
            // 
            // mnA
            // 
            this.mnA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAA,
            this.mnAS,
            this.mnAX});
            this.mnA.Margin = new System.Windows.Forms.Padding(3);
            this.mnA.Name = "mnA";
            this.mnA.Size = new System.Drawing.Size(61, 19);
            this.mnA.Text = "&Arquivo";
            // 
            // mnAA
            // 
            this.mnAA.Margin = new System.Windows.Forms.Padding(3);
            this.mnAA.Name = "mnAA";
            this.mnAA.Size = new System.Drawing.Size(118, 22);
            this.mnAA.Text = "&Abrir . . .";
            this.mnAA.Click += new System.EventHandler(this.mnAA_Click);
            // 
            // mnAS
            // 
            this.mnAS.Margin = new System.Windows.Forms.Padding(3);
            this.mnAS.Name = "mnAS";
            this.mnAS.Size = new System.Drawing.Size(118, 22);
            this.mnAS.Text = "&Salvar";
            // 
            // mnAX
            // 
            this.mnAX.Margin = new System.Windows.Forms.Padding(3);
            this.mnAX.Name = "mnAX";
            this.mnAX.Size = new System.Drawing.Size(118, 22);
            this.mnAX.Text = "E&xcluir";
            // 
            // mnE
            // 
            this.mnE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnEA});
            this.mnE.Margin = new System.Windows.Forms.Padding(3);
            this.mnE.Name = "mnE";
            this.mnE.Size = new System.Drawing.Size(49, 19);
            this.mnE.Text = "&Editar";
            // 
            // mnEA
            // 
            this.mnEA.Margin = new System.Windows.Forms.Padding(3);
            this.mnEA.Name = "mnEA";
            this.mnEA.Size = new System.Drawing.Size(125, 22);
            this.mnEA.Text = "&Adicionar";
            // 
            // dlgAb
            // 
            this.dlgAb.DefaultExt = "scfg";
            this.dlgAb.FileName = "settings";
            this.dlgAb.Filter = "Configurações SAK (*.scfg)|*.scfg";
            this.dlgAb.RestoreDirectory = true;
            this.dlgAb.ShowReadOnly = true;
            this.dlgAb.Title = "Abrir arquivo . . .";
            // 
            // txtNCb
            // 
            this.txtNCb.Location = new System.Drawing.Point(101, 39);
            this.txtNCb.Name = "txtNCb";
            this.txtNCb.Size = new System.Drawing.Size(434, 20);
            this.txtNCb.TabIndex = 10;
            // 
            // txtNEn
            // 
            this.txtNEn.Location = new System.Drawing.Point(101, 65);
            this.txtNEn.Name = "txtNEn";
            this.txtNEn.Size = new System.Drawing.Size(434, 20);
            this.txtNEn.TabIndex = 11;
            // 
            // txtNVl
            // 
            this.txtNVl.Location = new System.Drawing.Point(101, 91);
            this.txtNVl.Name = "txtNVl";
            this.txtNVl.Size = new System.Drawing.Size(434, 20);
            this.txtNVl.TabIndex = 12;
            // 
            // lblNCb
            // 
            this.lblNCb.AutoSize = true;
            this.lblNCb.Location = new System.Drawing.Point(12, 42);
            this.lblNCb.Margin = new System.Windows.Forms.Padding(3);
            this.lblNCb.Name = "lblNCb";
            this.lblNCb.Size = new System.Drawing.Size(89, 13);
            this.lblNCb.TabIndex = 13;
            this.lblNCb.Text = "Novo cabeçalho:";
            // 
            // lblNEn
            // 
            this.lblNEn.AutoSize = true;
            this.lblNEn.Location = new System.Drawing.Point(12, 68);
            this.lblNEn.Margin = new System.Windows.Forms.Padding(3);
            this.lblNEn.Name = "lblNEn";
            this.lblNEn.Size = new System.Drawing.Size(75, 13);
            this.lblNEn.TabIndex = 14;
            this.lblNEn.Text = "Nova entrada:";
            // 
            // LblNVl
            // 
            this.LblNVl.AutoSize = true;
            this.LblNVl.Location = new System.Drawing.Point(12, 94);
            this.LblNVl.Margin = new System.Windows.Forms.Padding(3);
            this.LblNVl.Name = "LblNVl";
            this.LblNVl.Size = new System.Drawing.Size(34, 13);
            this.LblNVl.TabIndex = 15;
            this.LblNVl.Text = "Valor:";
            // 
            // CNF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 372);
            this.Controls.Add(this.LblNVl);
            this.Controls.Add(this.lblNEn);
            this.Controls.Add(this.lblNCb);
            this.Controls.Add(this.txtNVl);
            this.Controls.Add(this.txtNEn);
            this.Controls.Add(this.txtNCb);
            this.Controls.Add(this.cmdAd);
            this.Controls.Add(this.cmdEx);
            this.Controls.Add(this.cmdSv);
            this.Controls.Add(this.lblVl);
            this.Controls.Add(this.lblEn);
            this.Controls.Add(this.lblCb);
            this.Controls.Add(this.txtVl);
            this.Controls.Add(this.lstEn);
            this.Controls.Add(this.lstCb);
            this.Controls.Add(this.mn);
            this.MainMenuStrip = this.mn;
            this.Name = "CNF";
            this.Text = "Form1";
            this.mn.ResumeLayout(false);
            this.mn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCb;
        private System.Windows.Forms.ListBox lstEn;
        private System.Windows.Forms.TextBox txtVl;
        private System.Windows.Forms.Label lblCb;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblVl;
        private System.Windows.Forms.Button cmdSv;
        private System.Windows.Forms.Button cmdEx;
        private System.Windows.Forms.Button cmdAd;
        private System.Windows.Forms.MenuStrip mn;
        private System.Windows.Forms.ToolStripMenuItem mnA;
        private System.Windows.Forms.ToolStripMenuItem mnAA;
        private System.Windows.Forms.ToolStripMenuItem mnAS;
        private System.Windows.Forms.ToolStripMenuItem mnAX;
        private System.Windows.Forms.ToolStripMenuItem mnE;
        private System.Windows.Forms.ToolStripMenuItem mnEA;
        private System.Windows.Forms.OpenFileDialog dlgAb;
        private System.Windows.Forms.TextBox txtNCb;
        private System.Windows.Forms.TextBox txtNEn;
        private System.Windows.Forms.TextBox txtNVl;
        private System.Windows.Forms.Label lblNCb;
        private System.Windows.Forms.Label lblNEn;
        private System.Windows.Forms.Label LblNVl;
    }
}

