namespace _06_ListComboBox
{
    partial class ListComboBoxMainForm
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
            this.CbSource = new System.Windows.Forms.ComboBox();
            this.LSource = new System.Windows.Forms.Label();
            this.BAddOneToTarget = new System.Windows.Forms.Button();
            this.BAddAllToTarget = new System.Windows.Forms.Button();
            this.LbTarget = new System.Windows.Forms.ListBox();
            this.LTarget = new System.Windows.Forms.Label();
            this.BAddAllToSource = new System.Windows.Forms.Button();
            this.BAddOneToSource = new System.Windows.Forms.Button();
            this.BSourceMoveTop = new System.Windows.Forms.Button();
            this.BSourceMoveBottom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbSource
            // 
            this.CbSource.FormattingEnabled = true;
            this.CbSource.Location = new System.Drawing.Point(12, 30);
            this.CbSource.Name = "CbSource";
            this.CbSource.Size = new System.Drawing.Size(154, 23);
            this.CbSource.TabIndex = 0;
            this.CbSource.DropDown += new System.EventHandler(this.CbSource_DropDown);
            // 
            // LSource
            // 
            this.LSource.Location = new System.Drawing.Point(12, 9);
            this.LSource.Name = "LSource";
            this.LSource.Size = new System.Drawing.Size(154, 18);
            this.LSource.TabIndex = 1;
            this.LSource.Text = "Source";
            this.LSource.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BAddOneToTarget
            // 
            this.BAddOneToTarget.Location = new System.Drawing.Point(172, 30);
            this.BAddOneToTarget.Name = "BAddOneToTarget";
            this.BAddOneToTarget.Size = new System.Drawing.Size(46, 23);
            this.BAddOneToTarget.TabIndex = 2;
            this.BAddOneToTarget.Tag = "OneSourceToTarget";
            this.BAddOneToTarget.Text = ">";
            this.BAddOneToTarget.UseVisualStyleBackColor = true;
            this.BAddOneToTarget.Click += new System.EventHandler(this.BMoveToList_Click);
            // 
            // BAddAllToTarget
            // 
            this.BAddAllToTarget.Location = new System.Drawing.Point(172, 59);
            this.BAddAllToTarget.Name = "BAddAllToTarget";
            this.BAddAllToTarget.Size = new System.Drawing.Size(46, 23);
            this.BAddAllToTarget.TabIndex = 3;
            this.BAddAllToTarget.Tag = "AllSourceToTarget";
            this.BAddAllToTarget.Text = ">>";
            this.BAddAllToTarget.UseVisualStyleBackColor = true;
            this.BAddAllToTarget.Click += new System.EventHandler(this.BMoveToList_Click);
            // 
            // LbTarget
            // 
            this.LbTarget.FormattingEnabled = true;
            this.LbTarget.ItemHeight = 15;
            this.LbTarget.Location = new System.Drawing.Point(224, 30);
            this.LbTarget.Name = "LbTarget";
            this.LbTarget.Size = new System.Drawing.Size(154, 154);
            this.LbTarget.TabIndex = 5;
            this.LbTarget.SelectedIndexChanged += new System.EventHandler(this.LbTarget_SelectedIndexChanged);
            // 
            // LTarget
            // 
            this.LTarget.Location = new System.Drawing.Point(224, 9);
            this.LTarget.Name = "LTarget";
            this.LTarget.Size = new System.Drawing.Size(154, 18);
            this.LTarget.TabIndex = 6;
            this.LTarget.Text = "Cible";
            this.LTarget.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BAddAllToSource
            // 
            this.BAddAllToSource.Location = new System.Drawing.Point(172, 161);
            this.BAddAllToSource.Name = "BAddAllToSource";
            this.BAddAllToSource.Size = new System.Drawing.Size(46, 23);
            this.BAddAllToSource.TabIndex = 8;
            this.BAddAllToSource.Tag = "AllTargetToSource";
            this.BAddAllToSource.Text = "<<";
            this.BAddAllToSource.UseVisualStyleBackColor = true;
            this.BAddAllToSource.Click += new System.EventHandler(this.BMoveToList_Click);
            // 
            // BAddOneToSource
            // 
            this.BAddOneToSource.Location = new System.Drawing.Point(172, 132);
            this.BAddOneToSource.Name = "BAddOneToSource";
            this.BAddOneToSource.Size = new System.Drawing.Size(46, 23);
            this.BAddOneToSource.TabIndex = 7;
            this.BAddOneToSource.Tag = "OneTargetToSource";
            this.BAddOneToSource.Text = "<";
            this.BAddOneToSource.UseVisualStyleBackColor = true;
            this.BAddOneToSource.Click += new System.EventHandler(this.BMoveToList_Click);
            // 
            // BSourceMoveTop
            // 
            this.BSourceMoveTop.Enabled = false;
            this.BSourceMoveTop.Font = new System.Drawing.Font("Wingdings", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BSourceMoveTop.Location = new System.Drawing.Point(260, 190);
            this.BSourceMoveTop.Name = "BSourceMoveTop";
            this.BSourceMoveTop.Size = new System.Drawing.Size(30, 36);
            this.BSourceMoveTop.TabIndex = 9;
            this.BSourceMoveTop.Text = "á";
            this.BSourceMoveTop.UseVisualStyleBackColor = true;
            this.BSourceMoveTop.Click += new System.EventHandler(this.BSourceMoveItems_Click);
            // 
            // BSourceMoveBottom
            // 
            this.BSourceMoveBottom.Enabled = false;
            this.BSourceMoveBottom.Font = new System.Drawing.Font("Wingdings", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BSourceMoveBottom.Location = new System.Drawing.Point(296, 190);
            this.BSourceMoveBottom.Name = "BSourceMoveBottom";
            this.BSourceMoveBottom.Size = new System.Drawing.Size(30, 36);
            this.BSourceMoveBottom.TabIndex = 10;
            this.BSourceMoveBottom.Text = "â";
            this.BSourceMoveBottom.UseVisualStyleBackColor = true;
            this.BSourceMoveBottom.Click += new System.EventHandler(this.BSourceMoveItems_Click);
            // 
            // ListComboBoxMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 232);
            this.Controls.Add(this.BSourceMoveBottom);
            this.Controls.Add(this.BSourceMoveTop);
            this.Controls.Add(this.BAddAllToSource);
            this.Controls.Add(this.BAddOneToSource);
            this.Controls.Add(this.LTarget);
            this.Controls.Add(this.LbTarget);
            this.Controls.Add(this.BAddAllToTarget);
            this.Controls.Add(this.BAddOneToTarget);
            this.Controls.Add(this.LSource);
            this.Controls.Add(this.CbSource);
            this.Name = "ListComboBoxMainForm";
            this.Text = "Les listes";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox CbSource;
        private Label LSource;
        private Button BAddOneToTarget;
        private Button BAddAllToTarget;
        private ListBox LbTarget;
        private Label LTarget;
        private Button BAddAllToSource;
        private Button BAddOneToSource;
        private Button BSourceMoveTop;
        private Button BSourceMoveBottom;
    }
}