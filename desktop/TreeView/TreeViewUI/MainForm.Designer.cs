namespace TreeViewUI
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslSearchStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.bOpenBranch = new System.Windows.Forms.Button();
            this.bCloseBranch = new System.Windows.Forms.Button();
            this.bShowDiskRoot = new System.Windows.Forms.Button();
            this.tvNodeTree = new System.Windows.Forms.TreeView();
            this.lDirExplore = new System.Windows.Forms.Label();
            this.tbRootPath = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslSearchStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(497, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslSearchStatus
            // 
            this.tsslSearchStatus.Name = "tsslSearchStatus";
            this.tsslSearchStatus.Size = new System.Drawing.Size(133, 17);
            this.tsslSearchStatus.Text = "En attente d\'exploration";
            // 
            // bOpenBranch
            // 
            this.bOpenBranch.Location = new System.Drawing.Point(92, 375);
            this.bOpenBranch.Name = "bOpenBranch";
            this.bOpenBranch.Size = new System.Drawing.Size(75, 50);
            this.bOpenBranch.TabIndex = 1;
            this.bOpenBranch.Text = "Expansion de l\'arbre";
            this.bOpenBranch.UseVisualStyleBackColor = true;
            // 
            // bCloseBranch
            // 
            this.bCloseBranch.Location = new System.Drawing.Point(325, 375);
            this.bCloseBranch.Name = "bCloseBranch";
            this.bCloseBranch.Size = new System.Drawing.Size(75, 50);
            this.bCloseBranch.TabIndex = 2;
            this.bCloseBranch.Text = "Reduction de l\'arbre";
            this.bCloseBranch.UseVisualStyleBackColor = true;
            // 
            // bShowDiskRoot
            // 
            this.bShowDiskRoot.Location = new System.Drawing.Point(35, 6);
            this.bShowDiskRoot.Name = "bShowDiskRoot";
            this.bShowDiskRoot.Size = new System.Drawing.Size(84, 48);
            this.bShowDiskRoot.TabIndex = 3;
            this.bShowDiskRoot.Text = "Affichage du disque dur";
            this.bShowDiskRoot.UseVisualStyleBackColor = true;
            this.bShowDiskRoot.Click += new System.EventHandler(this.bShowDiskRoot_Click);
            // 
            // tvNodeTree
            // 
            this.tvNodeTree.Location = new System.Drawing.Point(12, 66);
            this.tvNodeTree.Name = "tvNodeTree";
            this.tvNodeTree.Size = new System.Drawing.Size(473, 303);
            this.tvNodeTree.TabIndex = 4;
            // 
            // lDirExplore
            // 
            this.lDirExplore.Location = new System.Drawing.Point(145, 15);
            this.lDirExplore.Name = "lDirExplore";
            this.lDirExplore.Size = new System.Drawing.Size(111, 31);
            this.lDirExplore.TabIndex = 5;
            this.lDirExplore.Text = "Chemin du dossier à examiner";
            this.lDirExplore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbRootPath
            // 
            this.tbRootPath.Location = new System.Drawing.Point(271, 15);
            this.tbRootPath.Name = "tbRootPath";
            this.tbRootPath.Size = new System.Drawing.Size(214, 23);
            this.tbRootPath.TabIndex = 6;
            this.tbRootPath.Leave += new System.EventHandler(this.tbRootPath_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 453);
            this.Controls.Add(this.tbRootPath);
            this.Controls.Add(this.lDirExplore);
            this.Controls.Add(this.tvNodeTree);
            this.Controls.Add(this.bShowDiskRoot);
            this.Controls.Add(this.bCloseBranch);
            this.Controls.Add(this.bOpenBranch);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Définissez un chemin de dossier";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private Button bOpenBranch;
        private Button bCloseBranch;
        private Button bShowDiskRoot;
        private TreeView tvNodeTree;
        private Label lDirExplore;
        private TextBox tbRootPath;
        private ToolStripStatusLabel tsslSearchStatus;
    }
}