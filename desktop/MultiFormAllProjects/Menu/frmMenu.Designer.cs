﻿namespace Menu
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
            this.tsslLoginStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMediOption2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msMdiOptions = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatusInfo.SuspendLayout();
            this.tsMediOption2.SuspendLayout();
            this.msMdiOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssStatusInfo
            // 
            this.ssStatusInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDateNow,
            this.tsslLoginStatus});
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
            // tsslLoginStatus
            // 
            this.tsslLoginStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tsslLoginStatus.Name = "tsslLoginStatus";
            this.tsslLoginStatus.Size = new System.Drawing.Size(63, 17);
            this.tsslLoginStatus.Text = "S\'identifier";
            // 
            // tsMediOption2
            // 
            this.tsMediOption2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2});
            this.tsMediOption2.Location = new System.Drawing.Point(0, 24);
            this.tsMediOption2.Name = "tsMediOption2";
            this.tsMediOption2.Size = new System.Drawing.Size(800, 25);
            this.tsMediOption2.TabIndex = 5;
            this.tsMediOption2.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "S\'identifier";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 22);
            this.toolStripSplitButton1.Text = "Phase 3";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripDropDownButton1.Text = "Phase 3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // msMdiOptions
            // 
            this.msMdiOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.phase1ToolStripMenuItem,
            this.phase2ToolStripMenuItem,
            this.phase3ToolStripMenuItem,
            this.fenêtresToolStripMenuItem});
            this.msMdiOptions.Location = new System.Drawing.Point(0, 0);
            this.msMdiOptions.Name = "msMdiOptions";
            this.msMdiOptions.Size = new System.Drawing.Size(800, 24);
            this.msMdiOptions.TabIndex = 4;
            this.msMdiOptions.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // phase1ToolStripMenuItem
            // 
            this.phase1ToolStripMenuItem.Name = "phase1ToolStripMenuItem";
            this.phase1ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase1ToolStripMenuItem.Text = "Phase 1";
            // 
            // phase2ToolStripMenuItem
            // 
            this.phase2ToolStripMenuItem.Name = "phase2ToolStripMenuItem";
            this.phase2ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase2ToolStripMenuItem.Text = "Phase 2";
            // 
            // phase3ToolStripMenuItem
            // 
            this.phase3ToolStripMenuItem.Name = "phase3ToolStripMenuItem";
            this.phase3ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase3ToolStripMenuItem.Text = "Phase 3";
            // 
            // fenêtresToolStripMenuItem
            // 
            this.fenêtresToolStripMenuItem.Name = "fenêtresToolStripMenuItem";
            this.fenêtresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fenêtresToolStripMenuItem.Text = "Fenêtres";
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
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private ToolStripStatusLabel tsslLoginStatus;
        private ToolStrip tsMediOption2;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripSeparator toolStripSeparator2;
        private MenuStrip msMdiOptions;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem phase1ToolStripMenuItem;
        private ToolStripMenuItem phase2ToolStripMenuItem;
        private ToolStripMenuItem phase3ToolStripMenuItem;
        private ToolStripMenuItem fenêtresToolStripMenuItem;
    }
}