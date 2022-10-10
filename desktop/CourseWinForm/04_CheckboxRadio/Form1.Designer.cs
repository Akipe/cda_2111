namespace _04_CheckboxRadio
{
    partial class CRMainForm
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
            this.PText = new System.Windows.Forms.Panel();
            this.LTextShow = new System.Windows.Forms.Label();
            this.LTextUserInfo = new System.Windows.Forms.Label();
            this.TbText = new System.Windows.Forms.TextBox();
            this.GbOptions = new System.Windows.Forms.GroupBox();
            this.CbOptionCase = new System.Windows.Forms.CheckBox();
            this.CbOptionColorText = new System.Windows.Forms.CheckBox();
            this.CbOptionColorBackground = new System.Windows.Forms.CheckBox();
            this.GbColorBackground = new System.Windows.Forms.GroupBox();
            this.RbColorBackgroundBlue = new System.Windows.Forms.RadioButton();
            this.RbColorBackgroundGreen = new System.Windows.Forms.RadioButton();
            this.RbColorBackgroundRed = new System.Windows.Forms.RadioButton();
            this.GbColorText = new System.Windows.Forms.GroupBox();
            this.RbColorTextBlack = new System.Windows.Forms.RadioButton();
            this.RbColorTextWhite = new System.Windows.Forms.RadioButton();
            this.RbColorTextRed = new System.Windows.Forms.RadioButton();
            this.GbCase = new System.Windows.Forms.GroupBox();
            this.RbCaseUpper = new System.Windows.Forms.RadioButton();
            this.RbCaseLower = new System.Windows.Forms.RadioButton();
            this.PText.SuspendLayout();
            this.GbOptions.SuspendLayout();
            this.GbColorBackground.SuspendLayout();
            this.GbColorText.SuspendLayout();
            this.GbCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // PText
            // 
            this.PText.Controls.Add(this.LTextShow);
            this.PText.Controls.Add(this.LTextUserInfo);
            this.PText.Controls.Add(this.TbText);
            this.PText.Location = new System.Drawing.Point(12, 12);
            this.PText.Name = "PText";
            this.PText.Size = new System.Drawing.Size(263, 100);
            this.PText.TabIndex = 0;
            // 
            // LTextShow
            // 
            this.LTextShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LTextShow.Location = new System.Drawing.Point(3, 61);
            this.LTextShow.Name = "LTextShow";
            this.LTextShow.Size = new System.Drawing.Size(257, 23);
            this.LTextShow.TabIndex = 2;
            // 
            // LTextUserInfo
            // 
            this.LTextUserInfo.AutoSize = true;
            this.LTextUserInfo.Location = new System.Drawing.Point(3, 0);
            this.LTextUserInfo.Name = "LTextUserInfo";
            this.LTextUserInfo.Size = new System.Drawing.Size(95, 15);
            this.LTextUserInfo.TabIndex = 1;
            this.LTextUserInfo.Text = "Tapez votre texte";
            // 
            // TbText
            // 
            this.TbText.Location = new System.Drawing.Point(3, 18);
            this.TbText.Name = "TbText";
            this.TbText.Size = new System.Drawing.Size(257, 23);
            this.TbText.TabIndex = 0;
            this.TbText.TextChanged += new System.EventHandler(this.TbText_TextChanged);
            // 
            // GbOptions
            // 
            this.GbOptions.Controls.Add(this.CbOptionCase);
            this.GbOptions.Controls.Add(this.CbOptionColorText);
            this.GbOptions.Controls.Add(this.CbOptionColorBackground);
            this.GbOptions.Enabled = false;
            this.GbOptions.Location = new System.Drawing.Point(295, 12);
            this.GbOptions.Name = "GbOptions";
            this.GbOptions.Size = new System.Drawing.Size(157, 94);
            this.GbOptions.TabIndex = 1;
            this.GbOptions.TabStop = false;
            this.GbOptions.Text = "Choix";
            // 
            // CbOptionCase
            // 
            this.CbOptionCase.AutoSize = true;
            this.CbOptionCase.Location = new System.Drawing.Point(6, 68);
            this.CbOptionCase.Name = "CbOptionCase";
            this.CbOptionCase.Size = new System.Drawing.Size(56, 19);
            this.CbOptionCase.TabIndex = 3;
            this.CbOptionCase.Text = "Casse";
            this.CbOptionCase.UseVisualStyleBackColor = true;
            this.CbOptionCase.CheckedChanged += new System.EventHandler(this.CbOption_CheckedChanged);
            // 
            // CbOptionColorText
            // 
            this.CbOptionColorText.AutoSize = true;
            this.CbOptionColorText.Location = new System.Drawing.Point(6, 43);
            this.CbOptionColorText.Name = "CbOptionColorText";
            this.CbOptionColorText.Size = new System.Drawing.Size(145, 19);
            this.CbOptionColorText.TabIndex = 2;
            this.CbOptionColorText.Text = "Couleur des caractères";
            this.CbOptionColorText.UseVisualStyleBackColor = true;
            this.CbOptionColorText.CheckedChanged += new System.EventHandler(this.CbOption_CheckedChanged);
            // 
            // CbOptionColorBackground
            // 
            this.CbOptionColorBackground.AutoSize = true;
            this.CbOptionColorBackground.Location = new System.Drawing.Point(6, 18);
            this.CbOptionColorBackground.Name = "CbOptionColorBackground";
            this.CbOptionColorBackground.Size = new System.Drawing.Size(113, 19);
            this.CbOptionColorBackground.TabIndex = 1;
            this.CbOptionColorBackground.Text = "Couleur du fond";
            this.CbOptionColorBackground.UseVisualStyleBackColor = true;
            this.CbOptionColorBackground.CheckedChanged += new System.EventHandler(this.CbOption_CheckedChanged);
            // 
            // GbColorBackground
            // 
            this.GbColorBackground.Controls.Add(this.RbColorBackgroundBlue);
            this.GbColorBackground.Controls.Add(this.RbColorBackgroundGreen);
            this.GbColorBackground.Controls.Add(this.RbColorBackgroundRed);
            this.GbColorBackground.Enabled = false;
            this.GbColorBackground.Location = new System.Drawing.Point(12, 126);
            this.GbColorBackground.Name = "GbColorBackground";
            this.GbColorBackground.Size = new System.Drawing.Size(80, 100);
            this.GbColorBackground.TabIndex = 2;
            this.GbColorBackground.TabStop = false;
            this.GbColorBackground.Text = "Fond";
            // 
            // RbColorBackgroundBlue
            // 
            this.RbColorBackgroundBlue.AutoSize = true;
            this.RbColorBackgroundBlue.Location = new System.Drawing.Point(6, 72);
            this.RbColorBackgroundBlue.Name = "RbColorBackgroundBlue";
            this.RbColorBackgroundBlue.Size = new System.Drawing.Size(48, 19);
            this.RbColorBackgroundBlue.TabIndex = 2;
            this.RbColorBackgroundBlue.TabStop = true;
            this.RbColorBackgroundBlue.Text = "Bleu";
            this.RbColorBackgroundBlue.UseVisualStyleBackColor = true;
            this.RbColorBackgroundBlue.CheckedChanged += new System.EventHandler(this.OptionsUpdates);
            // 
            // RbColorBackgroundGreen
            // 
            this.RbColorBackgroundGreen.AutoSize = true;
            this.RbColorBackgroundGreen.Location = new System.Drawing.Point(6, 47);
            this.RbColorBackgroundGreen.Name = "RbColorBackgroundGreen";
            this.RbColorBackgroundGreen.Size = new System.Drawing.Size(45, 19);
            this.RbColorBackgroundGreen.TabIndex = 1;
            this.RbColorBackgroundGreen.TabStop = true;
            this.RbColorBackgroundGreen.Text = "Vert";
            this.RbColorBackgroundGreen.UseVisualStyleBackColor = true;
            this.RbColorBackgroundGreen.CheckedChanged += new System.EventHandler(this.OptionsUpdates);
            // 
            // RbColorBackgroundRed
            // 
            this.RbColorBackgroundRed.AutoSize = true;
            this.RbColorBackgroundRed.Location = new System.Drawing.Point(6, 22);
            this.RbColorBackgroundRed.Name = "RbColorBackgroundRed";
            this.RbColorBackgroundRed.Size = new System.Drawing.Size(59, 19);
            this.RbColorBackgroundRed.TabIndex = 0;
            this.RbColorBackgroundRed.TabStop = true;
            this.RbColorBackgroundRed.Text = "Rouge";
            this.RbColorBackgroundRed.UseVisualStyleBackColor = true;
            this.RbColorBackgroundRed.CheckedChanged += new System.EventHandler(this.OptionsUpdates);
            // 
            // GbColorText
            // 
            this.GbColorText.Controls.Add(this.RbColorTextBlack);
            this.GbColorText.Controls.Add(this.RbColorTextWhite);
            this.GbColorText.Controls.Add(this.RbColorTextRed);
            this.GbColorText.Enabled = false;
            this.GbColorText.Location = new System.Drawing.Point(99, 126);
            this.GbColorText.Name = "GbColorText";
            this.GbColorText.Size = new System.Drawing.Size(80, 100);
            this.GbColorText.TabIndex = 3;
            this.GbColorText.TabStop = false;
            this.GbColorText.Text = "Caractères";
            // 
            // RbColorTextBlack
            // 
            this.RbColorTextBlack.AutoSize = true;
            this.RbColorTextBlack.Location = new System.Drawing.Point(7, 72);
            this.RbColorTextBlack.Name = "RbColorTextBlack";
            this.RbColorTextBlack.Size = new System.Drawing.Size(48, 19);
            this.RbColorTextBlack.TabIndex = 5;
            this.RbColorTextBlack.TabStop = true;
            this.RbColorTextBlack.Text = "Noir";
            this.RbColorTextBlack.UseVisualStyleBackColor = true;
            this.RbColorTextBlack.CheckedChanged += new System.EventHandler(this.OptionsUpdates);
            // 
            // RbColorTextWhite
            // 
            this.RbColorTextWhite.AutoSize = true;
            this.RbColorTextWhite.Location = new System.Drawing.Point(7, 47);
            this.RbColorTextWhite.Name = "RbColorTextWhite";
            this.RbColorTextWhite.Size = new System.Drawing.Size(54, 19);
            this.RbColorTextWhite.TabIndex = 4;
            this.RbColorTextWhite.TabStop = true;
            this.RbColorTextWhite.Text = "Blanc";
            this.RbColorTextWhite.UseVisualStyleBackColor = true;
            this.RbColorTextWhite.CheckedChanged += new System.EventHandler(this.OptionsUpdates);
            // 
            // RbColorTextRed
            // 
            this.RbColorTextRed.AutoSize = true;
            this.RbColorTextRed.Location = new System.Drawing.Point(7, 22);
            this.RbColorTextRed.Name = "RbColorTextRed";
            this.RbColorTextRed.Size = new System.Drawing.Size(59, 19);
            this.RbColorTextRed.TabIndex = 3;
            this.RbColorTextRed.TabStop = true;
            this.RbColorTextRed.Text = "Rouge";
            this.RbColorTextRed.UseVisualStyleBackColor = true;
            this.RbColorTextRed.CheckedChanged += new System.EventHandler(this.OptionsUpdates);
            // 
            // GbCase
            // 
            this.GbCase.Controls.Add(this.RbCaseUpper);
            this.GbCase.Controls.Add(this.RbCaseLower);
            this.GbCase.Enabled = false;
            this.GbCase.Location = new System.Drawing.Point(185, 155);
            this.GbCase.Name = "GbCase";
            this.GbCase.Size = new System.Drawing.Size(105, 71);
            this.GbCase.TabIndex = 4;
            this.GbCase.TabStop = false;
            this.GbCase.Text = "Casse";
            // 
            // RbCaseUpper
            // 
            this.RbCaseUpper.AutoSize = true;
            this.RbCaseUpper.Location = new System.Drawing.Point(6, 46);
            this.RbCaseUpper.Name = "RbCaseUpper";
            this.RbCaseUpper.Size = new System.Drawing.Size(84, 19);
            this.RbCaseUpper.TabIndex = 7;
            this.RbCaseUpper.TabStop = true;
            this.RbCaseUpper.Text = "Majuscules";
            this.RbCaseUpper.UseVisualStyleBackColor = true;
            this.RbCaseUpper.CheckedChanged += new System.EventHandler(this.OptionsUpdates);
            // 
            // RbCaseLower
            // 
            this.RbCaseLower.AutoSize = true;
            this.RbCaseLower.Location = new System.Drawing.Point(6, 22);
            this.RbCaseLower.Name = "RbCaseLower";
            this.RbCaseLower.Size = new System.Drawing.Size(85, 19);
            this.RbCaseLower.TabIndex = 6;
            this.RbCaseLower.TabStop = true;
            this.RbCaseLower.Text = "Minuscules";
            this.RbCaseLower.UseVisualStyleBackColor = true;
            this.RbCaseLower.CheckedChanged += new System.EventHandler(this.OptionsUpdates);
            // 
            // CRMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 238);
            this.Controls.Add(this.GbCase);
            this.Controls.Add(this.GbColorText);
            this.Controls.Add(this.GbColorBackground);
            this.Controls.Add(this.GbOptions);
            this.Controls.Add(this.PText);
            this.Name = "CRMainForm";
            this.Text = "CheckBox et RadioButton";
            this.PText.ResumeLayout(false);
            this.PText.PerformLayout();
            this.GbOptions.ResumeLayout(false);
            this.GbOptions.PerformLayout();
            this.GbColorBackground.ResumeLayout(false);
            this.GbColorBackground.PerformLayout();
            this.GbColorText.ResumeLayout(false);
            this.GbColorText.PerformLayout();
            this.GbCase.ResumeLayout(false);
            this.GbCase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PText;
        private GroupBox GbOptions;
        private GroupBox GbColorBackground;
        private GroupBox GbColorText;
        private GroupBox GbCase;
        private Label LTextUserInfo;
        private TextBox TbText;
        private Label LTextShow;
        private CheckBox CbOptionCase;
        private CheckBox CbOptionColorText;
        private CheckBox CbOptionColorBackground;
        private RadioButton RbColorBackgroundBlue;
        private RadioButton RbColorBackgroundGreen;
        private RadioButton RbColorBackgroundRed;
        private RadioButton RbColorTextBlack;
        private RadioButton RbColorTextWhite;
        private RadioButton RbColorTextRed;
        private RadioButton RbCaseUpper;
        private RadioButton RbCaseLower;
    }
}