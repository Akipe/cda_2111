namespace Menu
{
    partial class frmMenu
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
            this.ssStatusInfo = new System.Windows.Forms.StatusStrip();
            this.tsslDateNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMediOption2 = new System.Windows.Forms.ToolStrip();
            this.tslAuth = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbStage3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msMdiOptions = new System.Windows.Forms.MenuStrip();
            this.tsmiConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConnectionLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiConnectionLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStage1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miSumMaker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.synthèseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStage2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lesControlesDeSaisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.synthèseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStage3 = new System.Windows.Forms.ToolStripMenuItem();
            this.casesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.défilementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.sytnhèseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStageWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ssStatusInfo.SuspendLayout();
            this.tsMediOption2.SuspendLayout();
            this.msMdiOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssStatusInfo
            // 
            this.ssStatusInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDateNow,
            this.tsslLastAction});
            this.ssStatusInfo.Location = new System.Drawing.Point(0, 428);
            this.ssStatusInfo.Name = "ssStatusInfo";
            this.ssStatusInfo.Size = new System.Drawing.Size(800, 22);
            this.ssStatusInfo.TabIndex = 6;
            this.ssStatusInfo.Text = "statusStrip1";
            // 
            // tsslDateNow
            // 
            this.tsslDateNow.Name = "tsslDateNow";
            this.tsslDateNow.Size = new System.Drawing.Size(65, 17);
            this.tsslDateNow.Text = "00/00/0000";
            // 
            // tsslLastAction
            // 
            this.tsslLastAction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tsslLastAction.Name = "tsslLastAction";
            this.tsslLastAction.Size = new System.Drawing.Size(63, 17);
            this.tsslLastAction.Text = "S\'identifier";
            // 
            // tsMediOption2
            // 
            this.tsMediOption2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAuth,
            this.toolStripSeparator1,
            this.tsddbStage3,
            this.toolStripSeparator2});
            this.tsMediOption2.Location = new System.Drawing.Point(0, 24);
            this.tsMediOption2.Name = "tsMediOption2";
            this.tsMediOption2.Size = new System.Drawing.Size(800, 25);
            this.tsMediOption2.TabIndex = 5;
            this.tsMediOption2.Text = "toolStrip1";
            // 
            // tslAuth
            // 
            this.tslAuth.Name = "tslAuth";
            this.tslAuth.Size = new System.Drawing.Size(63, 22);
            this.tslAuth.Text = "S\'identifier";
            this.tslAuth.Click += new System.EventHandler(this.tslAuth_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsddbStage3
            // 
            this.tsddbStage3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbStage3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbStage3.Name = "tsddbStage3";
            this.tsddbStage3.Size = new System.Drawing.Size(60, 22);
            this.tsddbStage3.Text = "Phase 3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // msMdiOptions
            // 
            this.msMdiOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConnection,
            this.tsmiStage1,
            this.tsmiStage2,
            this.tsmiStage3,
            this.tsmiStageWindows});
            this.msMdiOptions.Location = new System.Drawing.Point(0, 0);
            this.msMdiOptions.MdiWindowListItem = this.tsmiStageWindows;
            this.msMdiOptions.Name = "msMdiOptions";
            this.msMdiOptions.Size = new System.Drawing.Size(800, 24);
            this.msMdiOptions.TabIndex = 4;
            this.msMdiOptions.Text = "menuStrip1";
            // 
            // tsmiConnection
            // 
            this.tsmiConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConnectionLogin,
            this.toolStripSeparator3,
            this.tsmiConnectionLogout});
            this.tsmiConnection.Name = "tsmiConnection";
            this.tsmiConnection.Size = new System.Drawing.Size(77, 20);
            this.tsmiConnection.Text = "Connexion";
            // 
            // tsmiConnectionLogin
            // 
            this.tsmiConnectionLogin.Name = "tsmiConnectionLogin";
            this.tsmiConnectionLogin.Size = new System.Drawing.Size(130, 22);
            this.tsmiConnectionLogin.Text = "S\'identifier";
            this.tsmiConnectionLogin.Click += new System.EventHandler(this.ConnectionLogin_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(127, 6);
            // 
            // tsmiConnectionLogout
            // 
            this.tsmiConnectionLogout.Name = "tsmiConnectionLogout";
            this.tsmiConnectionLogout.Size = new System.Drawing.Size(130, 22);
            this.tsmiConnectionLogout.Text = "Quitter";
            this.tsmiConnectionLogout.Click += new System.EventHandler(this.ConnectionLogout_Click);
            // 
            // tsmiStage1
            // 
            this.tsmiStage1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSumMaker,
            this.toolStripSeparator4,
            this.synthèseToolStripMenuItem});
            this.tsmiStage1.Name = "tsmiStage1";
            this.tsmiStage1.Size = new System.Drawing.Size(59, 20);
            this.tsmiStage1.Text = "Phase 1";
            // 
            // miSumMaker
            // 
            this.miSumMaker.Name = "miSumMaker";
            this.miSumMaker.Size = new System.Drawing.Size(151, 22);
            this.miSumMaker.Text = "L\'additionneur";
            this.miSumMaker.Click += new System.EventHandler(this.StartChildrenForm_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(148, 6);
            // 
            // synthèseToolStripMenuItem
            // 
            this.synthèseToolStripMenuItem.Name = "synthèseToolStripMenuItem";
            this.synthèseToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.synthèseToolStripMenuItem.Text = "Synthèse";
            // 
            // tsmiStage2
            // 
            this.tsmiStage2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesControlesDeSaisieToolStripMenuItem,
            this.toolStripSeparator7,
            this.synthèseToolStripMenuItem1});
            this.tsmiStage2.Name = "tsmiStage2";
            this.tsmiStage2.Size = new System.Drawing.Size(59, 20);
            this.tsmiStage2.Text = "Phase 2";
            // 
            // lesControlesDeSaisieToolStripMenuItem
            // 
            this.lesControlesDeSaisieToolStripMenuItem.Name = "lesControlesDeSaisieToolStripMenuItem";
            this.lesControlesDeSaisieToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lesControlesDeSaisieToolStripMenuItem.Text = "Les controles de saisie";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(187, 6);
            // 
            // synthèseToolStripMenuItem1
            // 
            this.synthèseToolStripMenuItem1.Name = "synthèseToolStripMenuItem1";
            this.synthèseToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.synthèseToolStripMenuItem1.Text = "Synthèse";
            // 
            // tsmiStage3
            // 
            this.tsmiStage3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casesToolStripMenuItem1,
            this.comboBoxToolStripMenuItem,
            this.défilementToolStripMenuItem1,
            this.toolStripSeparator5,
            this.sytnhèseToolStripMenuItem});
            this.tsmiStage3.Name = "tsmiStage3";
            this.tsmiStage3.Size = new System.Drawing.Size(59, 20);
            this.tsmiStage3.Text = "Phase 3";
            // 
            // casesToolStripMenuItem1
            // 
            this.casesToolStripMenuItem1.Name = "casesToolStripMenuItem1";
            this.casesToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.casesToolStripMenuItem1.Text = "Cases";
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            // 
            // défilementToolStripMenuItem1
            // 
            this.défilementToolStripMenuItem1.Name = "défilementToolStripMenuItem1";
            this.défilementToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.défilementToolStripMenuItem1.Text = "Défilement";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(131, 6);
            // 
            // sytnhèseToolStripMenuItem
            // 
            this.sytnhèseToolStripMenuItem.Name = "sytnhèseToolStripMenuItem";
            this.sytnhèseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.sytnhèseToolStripMenuItem.Text = "Synthèse";
            this.sytnhèseToolStripMenuItem.Click += new System.EventHandler(this.sytnhèseToolStripMenuItem_Click);
            // 
            // tsmiStageWindows
            // 
            this.tsmiStageWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.toolStripSeparator6});
            this.tsmiStageWindows.Name = "tsmiStageWindows";
            this.tsmiStageWindows.Size = new System.Drawing.Size(63, 20);
            this.tsmiStageWindows.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssStatusInfo);
            this.Controls.Add(this.tsMediOption2);
            this.Controls.Add(this.msMdiOptions);
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.Text = "Créer des formulaires";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ssStatusInfo.ResumeLayout(false);
            this.ssStatusInfo.PerformLayout();
            this.tsMediOption2.ResumeLayout(false);
            this.tsMediOption2.PerformLayout();
            this.msMdiOptions.ResumeLayout(false);
            this.msMdiOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip ssStatusInfo;
        private ToolStripStatusLabel tsslDateNow;
        private ToolStripStatusLabel tsslLastAction;
        private ToolStrip tsMediOption2;
        private ToolStripLabel tslAuth;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsddbStage3;
        private ToolStripSeparator toolStripSeparator2;
        private MenuStrip msMdiOptions;
        private ToolStripMenuItem tsmiConnection;
        private ToolStripMenuItem tsmiStage1;
        private ToolStripMenuItem tsmiStage2;
        private ToolStripMenuItem tsmiStage3;
        private ToolStripMenuItem tsmiStageWindows;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem tsmiConnectionLogin;
        private ToolStripMenuItem tsmiConnectionLogout;
        private ToolStripMenuItem miSumMaker;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem synthèseToolStripMenuItem;
        private ToolStripMenuItem casesToolStripMenuItem1;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
        private ToolStripMenuItem défilementToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem sytnhèseToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem lesControlesDeSaisieToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem synthèseToolStripMenuItem1;
    }
}