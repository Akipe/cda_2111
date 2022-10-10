namespace Training02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSubPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripHelp = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxAllNames = new System.Windows.Forms.ListBox();
            this.buttonNameEmptying = new System.Windows.Forms.Button();
            this.buttonNameOk = new System.Windows.Forms.Button();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.menuStripPrincipal.SuspendLayout();
            this.toolStripSubPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.razToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // razToolStripMenuItem
            // 
            this.razToolStripMenuItem.Name = "razToolStripMenuItem";
            this.razToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.razToolStripMenuItem.Text = "RAZ";
            this.razToolStripMenuItem.Click += new System.EventHandler(this.razToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aProposDeToolStripMenuItem.Text = "A propos de";
            this.aProposDeToolStripMenuItem.Click += new System.EventHandler(this.aProposDeToolStripMenuItem_Click);
            // 
            // toolStripSubPrincipal
            // 
            this.toolStripSubPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCancel,
            this.toolStripHelp});
            this.toolStripSubPrincipal.Location = new System.Drawing.Point(0, 24);
            this.toolStripSubPrincipal.Name = "toolStripSubPrincipal";
            this.toolStripSubPrincipal.Size = new System.Drawing.Size(800, 25);
            this.toolStripSubPrincipal.TabIndex = 1;
            this.toolStripSubPrincipal.Text = "toolStrip1";
            // 
            // toolStripCancel
            // 
            this.toolStripCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancel.Image")));
            this.toolStripCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancel.Name = "toolStripCancel";
            this.toolStripCancel.Size = new System.Drawing.Size(23, 22);
            this.toolStripCancel.Text = "toolStripButton1";
            this.toolStripCancel.Click += new System.EventHandler(this.razToolStripMenuItem_Click);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHelp.Image")));
            this.toolStripHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(23, 22);
            this.toolStripHelp.Text = "toolStripButton2";
            this.toolStripHelp.Click += new System.EventHandler(this.aProposDeToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxAllNames);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonNameEmptying);
            this.splitContainer1.Panel2.Controls.Add(this.buttonNameOk);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxFirstname);
            this.splitContainer1.Panel2.Controls.Add(this.labelFirstname);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLastname);
            this.splitContainer1.Panel2.Controls.Add(this.labelLastname);
            this.splitContainer1.Size = new System.Drawing.Size(800, 401);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 2;
            // 
            // listBoxAllNames
            // 
            this.listBoxAllNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAllNames.FormattingEnabled = true;
            this.listBoxAllNames.ItemHeight = 15;
            this.listBoxAllNames.Location = new System.Drawing.Point(0, 0);
            this.listBoxAllNames.Name = "listBoxAllNames";
            this.listBoxAllNames.Size = new System.Drawing.Size(266, 401);
            this.listBoxAllNames.TabIndex = 0;
            // 
            // buttonNameEmptying
            // 
            this.buttonNameEmptying.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNameEmptying.Location = new System.Drawing.Point(362, 91);
            this.buttonNameEmptying.Name = "buttonNameEmptying";
            this.buttonNameEmptying.Size = new System.Drawing.Size(75, 23);
            this.buttonNameEmptying.TabIndex = 5;
            this.buttonNameEmptying.Text = "Vider";
            this.buttonNameEmptying.UseVisualStyleBackColor = true;
            this.buttonNameEmptying.Click += new System.EventHandler(this.buttonNameEmptying_Click);
            // 
            // buttonNameOk
            // 
            this.buttonNameOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNameOk.Location = new System.Drawing.Point(443, 91);
            this.buttonNameOk.Name = "buttonNameOk";
            this.buttonNameOk.Size = new System.Drawing.Size(75, 23);
            this.buttonNameOk.TabIndex = 4;
            this.buttonNameOk.Text = "OK";
            this.buttonNameOk.UseVisualStyleBackColor = true;
            this.buttonNameOk.Click += new System.EventHandler(this.buttonNameOk_Click);
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstname.Location = new System.Drawing.Point(4, 62);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(514, 23);
            this.textBoxFirstname.TabIndex = 3;
            this.textBoxFirstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Location = new System.Drawing.Point(3, 44);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(49, 15);
            this.labelFirstname.TabIndex = 2;
            this.labelFirstname.Text = "Prénom";
            this.labelFirstname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLastname.Location = new System.Drawing.Point(3, 18);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(515, 23);
            this.textBoxLastname.TabIndex = 1;
            this.textBoxLastname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(2, 0);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(34, 15);
            this.labelLastname.TabIndex = 0;
            this.labelLastname.Text = "Nom";
            this.labelLastname.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripSubPrincipal);
            this.Controls.Add(this.menuStripPrincipal);
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.toolStripSubPrincipal.ResumeLayout(false);
            this.toolStripSubPrincipal.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripPrincipal;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStrip toolStripSubPrincipal;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripButton toolStripCancel;
        private ToolStripButton toolStripHelp;
        private SplitContainer splitContainer1;
        private ListBox listBoxAllNames;
        private ToolStripMenuItem razToolStripMenuItem;
        private Label labelLastname;
        private TextBox textBoxLastname;
        private TextBox textBoxFirstname;
        private Label labelFirstname;
        private Button buttonNameOk;
        private Button buttonNameEmptying;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem aProposDeToolStripMenuItem;
    }
}