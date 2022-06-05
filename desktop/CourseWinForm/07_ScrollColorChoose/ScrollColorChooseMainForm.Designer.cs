namespace _07_ScrollColorChoose
{
    partial class ScrollColorChooseMainForm
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
            this.PColorChooseRed = new System.Windows.Forms.Panel();
            this.NudColorLevelRed = new System.Windows.Forms.NumericUpDown();
            this.HsbColorLevelRed = new System.Windows.Forms.HScrollBar();
            this.LColorPreviewRed = new System.Windows.Forms.Label();
            this.LColorRed = new System.Windows.Forms.Label();
            this.PColorChooseGreen = new System.Windows.Forms.Panel();
            this.NudColorLevelGreen = new System.Windows.Forms.NumericUpDown();
            this.HsbColorLevelGreen = new System.Windows.Forms.HScrollBar();
            this.LColorPreviewGreen = new System.Windows.Forms.Label();
            this.LColorGreen = new System.Windows.Forms.Label();
            this.PColorChooseBlue = new System.Windows.Forms.Panel();
            this.NudColorLevelBlue = new System.Windows.Forms.NumericUpDown();
            this.HsbColorLevelBlue = new System.Windows.Forms.HScrollBar();
            this.LColorPreviewBlue = new System.Windows.Forms.Label();
            this.LColorBlue = new System.Windows.Forms.Label();
            this.LColorPreview = new System.Windows.Forms.Label();
            this.PColorChoose = new System.Windows.Forms.Panel();
            this.PColorChooseRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudColorLevelRed)).BeginInit();
            this.PColorChooseGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudColorLevelGreen)).BeginInit();
            this.PColorChooseBlue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudColorLevelBlue)).BeginInit();
            this.PColorChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // PColorChooseRed
            // 
            this.PColorChooseRed.Controls.Add(this.NudColorLevelRed);
            this.PColorChooseRed.Controls.Add(this.HsbColorLevelRed);
            this.PColorChooseRed.Controls.Add(this.LColorPreviewRed);
            this.PColorChooseRed.Controls.Add(this.LColorRed);
            this.PColorChooseRed.Location = new System.Drawing.Point(3, 3);
            this.PColorChooseRed.Name = "PColorChooseRed";
            this.PColorChooseRed.Size = new System.Drawing.Size(343, 28);
            this.PColorChooseRed.TabIndex = 0;
            // 
            // NudColorLevelRed
            // 
            this.NudColorLevelRed.Location = new System.Drawing.Point(215, 2);
            this.NudColorLevelRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NudColorLevelRed.Name = "NudColorLevelRed";
            this.NudColorLevelRed.Size = new System.Drawing.Size(62, 23);
            this.NudColorLevelRed.TabIndex = 1;
            this.NudColorLevelRed.ValueChanged += new System.EventHandler(this.ControlChangePrimaryColorValue);
            // 
            // HsbColorLevelRed
            // 
            this.HsbColorLevelRed.Location = new System.Drawing.Point(47, 5);
            this.HsbColorLevelRed.Maximum = 255;
            this.HsbColorLevelRed.Name = "HsbColorLevelRed";
            this.HsbColorLevelRed.Size = new System.Drawing.Size(165, 17);
            this.HsbColorLevelRed.TabIndex = 0;
            this.HsbColorLevelRed.TabStop = true;
            this.HsbColorLevelRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ControlChangePrimaryColorValue);
            this.HsbColorLevelRed.ValueChanged += new System.EventHandler(this.ControlChangePrimaryColorValue);
            // 
            // LColorPreviewRed
            // 
            this.LColorPreviewRed.Location = new System.Drawing.Point(290, 4);
            this.LColorPreviewRed.Name = "LColorPreviewRed";
            this.LColorPreviewRed.Size = new System.Drawing.Size(50, 18);
            this.LColorPreviewRed.TabIndex = 1;
            // 
            // LColorRed
            // 
            this.LColorRed.AutoSize = true;
            this.LColorRed.Location = new System.Drawing.Point(3, 7);
            this.LColorRed.Name = "LColorRed";
            this.LColorRed.Size = new System.Drawing.Size(41, 15);
            this.LColorRed.TabIndex = 0;
            this.LColorRed.Text = "Rouge";
            // 
            // PColorChooseGreen
            // 
            this.PColorChooseGreen.Controls.Add(this.NudColorLevelGreen);
            this.PColorChooseGreen.Controls.Add(this.HsbColorLevelGreen);
            this.PColorChooseGreen.Controls.Add(this.LColorPreviewGreen);
            this.PColorChooseGreen.Controls.Add(this.LColorGreen);
            this.PColorChooseGreen.Location = new System.Drawing.Point(3, 34);
            this.PColorChooseGreen.Name = "PColorChooseGreen";
            this.PColorChooseGreen.Size = new System.Drawing.Size(343, 28);
            this.PColorChooseGreen.TabIndex = 4;
            // 
            // NudColorLevelGreen
            // 
            this.NudColorLevelGreen.Location = new System.Drawing.Point(215, 2);
            this.NudColorLevelGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NudColorLevelGreen.Name = "NudColorLevelGreen";
            this.NudColorLevelGreen.Size = new System.Drawing.Size(62, 23);
            this.NudColorLevelGreen.TabIndex = 3;
            this.NudColorLevelGreen.ValueChanged += new System.EventHandler(this.ControlChangePrimaryColorValue);
            // 
            // HsbColorLevelGreen
            // 
            this.HsbColorLevelGreen.Location = new System.Drawing.Point(47, 5);
            this.HsbColorLevelGreen.Maximum = 255;
            this.HsbColorLevelGreen.Name = "HsbColorLevelGreen";
            this.HsbColorLevelGreen.Size = new System.Drawing.Size(165, 17);
            this.HsbColorLevelGreen.TabIndex = 2;
            this.HsbColorLevelGreen.TabStop = true;
            this.HsbColorLevelGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ControlChangePrimaryColorValue);
            this.HsbColorLevelGreen.ValueChanged += new System.EventHandler(this.ControlChangePrimaryColorValue);
            // 
            // LColorPreviewGreen
            // 
            this.LColorPreviewGreen.Location = new System.Drawing.Point(290, 4);
            this.LColorPreviewGreen.Name = "LColorPreviewGreen";
            this.LColorPreviewGreen.Size = new System.Drawing.Size(50, 18);
            this.LColorPreviewGreen.TabIndex = 1;
            // 
            // LColorGreen
            // 
            this.LColorGreen.AutoSize = true;
            this.LColorGreen.Location = new System.Drawing.Point(3, 7);
            this.LColorGreen.Name = "LColorGreen";
            this.LColorGreen.Size = new System.Drawing.Size(27, 15);
            this.LColorGreen.TabIndex = 0;
            this.LColorGreen.Text = "Vert";
            // 
            // PColorChooseBlue
            // 
            this.PColorChooseBlue.Controls.Add(this.NudColorLevelBlue);
            this.PColorChooseBlue.Controls.Add(this.HsbColorLevelBlue);
            this.PColorChooseBlue.Controls.Add(this.LColorPreviewBlue);
            this.PColorChooseBlue.Controls.Add(this.LColorBlue);
            this.PColorChooseBlue.Location = new System.Drawing.Point(3, 65);
            this.PColorChooseBlue.Name = "PColorChooseBlue";
            this.PColorChooseBlue.Size = new System.Drawing.Size(343, 28);
            this.PColorChooseBlue.TabIndex = 5;
            // 
            // NudColorLevelBlue
            // 
            this.NudColorLevelBlue.Location = new System.Drawing.Point(215, 2);
            this.NudColorLevelBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NudColorLevelBlue.Name = "NudColorLevelBlue";
            this.NudColorLevelBlue.Size = new System.Drawing.Size(62, 23);
            this.NudColorLevelBlue.TabIndex = 5;
            this.NudColorLevelBlue.ValueChanged += new System.EventHandler(this.ControlChangePrimaryColorValue);
            // 
            // HsbColorLevelBlue
            // 
            this.HsbColorLevelBlue.Location = new System.Drawing.Point(47, 5);
            this.HsbColorLevelBlue.Maximum = 255;
            this.HsbColorLevelBlue.Name = "HsbColorLevelBlue";
            this.HsbColorLevelBlue.Size = new System.Drawing.Size(165, 17);
            this.HsbColorLevelBlue.TabIndex = 4;
            this.HsbColorLevelBlue.TabStop = true;
            this.HsbColorLevelBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ControlChangePrimaryColorValue);
            this.HsbColorLevelBlue.ValueChanged += new System.EventHandler(this.ControlChangePrimaryColorValue);
            // 
            // LColorPreviewBlue
            // 
            this.LColorPreviewBlue.Location = new System.Drawing.Point(290, 5);
            this.LColorPreviewBlue.Name = "LColorPreviewBlue";
            this.LColorPreviewBlue.Size = new System.Drawing.Size(50, 18);
            this.LColorPreviewBlue.TabIndex = 1;
            // 
            // LColorBlue
            // 
            this.LColorBlue.AutoSize = true;
            this.LColorBlue.Location = new System.Drawing.Point(3, 7);
            this.LColorBlue.Name = "LColorBlue";
            this.LColorBlue.Size = new System.Drawing.Size(30, 15);
            this.LColorBlue.TabIndex = 0;
            this.LColorBlue.Text = "Bleu";
            // 
            // LColorPreview
            // 
            this.LColorPreview.Location = new System.Drawing.Point(15, 133);
            this.LColorPreview.Name = "LColorPreview";
            this.LColorPreview.Size = new System.Drawing.Size(340, 76);
            this.LColorPreview.TabIndex = 6;
            // 
            // PColorChoose
            // 
            this.PColorChoose.Controls.Add(this.PColorChooseRed);
            this.PColorChoose.Controls.Add(this.PColorChooseGreen);
            this.PColorChoose.Controls.Add(this.PColorChooseBlue);
            this.PColorChoose.Location = new System.Drawing.Point(12, 30);
            this.PColorChoose.Name = "PColorChoose";
            this.PColorChoose.Size = new System.Drawing.Size(348, 100);
            this.PColorChoose.TabIndex = 7;
            // 
            // ScrollColorChooseMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 228);
            this.Controls.Add(this.PColorChoose);
            this.Controls.Add(this.LColorPreview);
            this.Name = "ScrollColorChooseMainForm";
            this.Text = "Defilement";
            this.PColorChooseRed.ResumeLayout(false);
            this.PColorChooseRed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudColorLevelRed)).EndInit();
            this.PColorChooseGreen.ResumeLayout(false);
            this.PColorChooseGreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudColorLevelGreen)).EndInit();
            this.PColorChooseBlue.ResumeLayout(false);
            this.PColorChooseBlue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudColorLevelBlue)).EndInit();
            this.PColorChoose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PColorChooseRed;
        private NumericUpDown NudColorLevelRed;
        private HScrollBar HsbColorLevelRed;
        private Label LColorPreviewRed;
        private Label LColorRed;
        private Panel PColorChooseGreen;
        private NumericUpDown NudColorLevelGreen;
        private HScrollBar HsbColorLevelGreen;
        private Label LColorPreviewGreen;
        private Label LColorGreen;
        private Panel PColorChooseBlue;
        private NumericUpDown NudColorLevelBlue;
        private HScrollBar HsbColorLevelBlue;
        private Label LColorPreviewBlue;
        private Label LColorBlue;
        private Label LColorPreview;
        private Panel PColorChoose;
    }
}