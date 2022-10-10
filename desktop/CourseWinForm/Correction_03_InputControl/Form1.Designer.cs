namespace Correction_03_InputControl
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
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbDate = new System.Windows.Forms.TextBox();
            this.TbAmount = new System.Windows.Forms.TextBox();
            this.TbZipcode = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.LAmount = new System.Windows.Forms.Label();
            this.LDate = new System.Windows.Forms.Label();
            this.LZipcode = new System.Windows.Forms.Label();
            this.BValidate = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(99, 25);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(234, 23);
            this.TbName.TabIndex = 0;
            // 
            // TbDate
            // 
            this.TbDate.Location = new System.Drawing.Point(99, 61);
            this.TbDate.Name = "TbDate";
            this.TbDate.Size = new System.Drawing.Size(100, 23);
            this.TbDate.TabIndex = 1;
            // 
            // TbAmount
            // 
            this.TbAmount.Location = new System.Drawing.Point(99, 103);
            this.TbAmount.Name = "TbAmount";
            this.TbAmount.Size = new System.Drawing.Size(100, 23);
            this.TbAmount.TabIndex = 2;
            // 
            // TbZipcode
            // 
            this.TbZipcode.Location = new System.Drawing.Point(99, 138);
            this.TbZipcode.Name = "TbZipcode";
            this.TbZipcode.Size = new System.Drawing.Size(100, 23);
            this.TbZipcode.TabIndex = 3;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(12, 28);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(34, 15);
            this.LName.TabIndex = 4;
            this.LName.Text = "Nom";
            // 
            // LAmount
            // 
            this.LAmount.AutoSize = true;
            this.LAmount.Location = new System.Drawing.Point(12, 107);
            this.LAmount.Name = "LAmount";
            this.LAmount.Size = new System.Drawing.Size(53, 15);
            this.LAmount.TabIndex = 5;
            this.LAmount.Text = "Montant";
            // 
            // LDate
            // 
            this.LDate.AutoSize = true;
            this.LDate.Location = new System.Drawing.Point(12, 64);
            this.LDate.Name = "LDate";
            this.LDate.Size = new System.Drawing.Size(31, 15);
            this.LDate.TabIndex = 6;
            this.LDate.Text = "Date";
            // 
            // LZipcode
            // 
            this.LZipcode.AutoSize = true;
            this.LZipcode.Location = new System.Drawing.Point(12, 141);
            this.LZipcode.Name = "LZipcode";
            this.LZipcode.Size = new System.Drawing.Size(70, 15);
            this.LZipcode.TabIndex = 7;
            this.LZipcode.Text = "Code Postal";
            // 
            // BValidate
            // 
            this.BValidate.Location = new System.Drawing.Point(247, 103);
            this.BValidate.Name = "BValidate";
            this.BValidate.Size = new System.Drawing.Size(75, 23);
            this.BValidate.TabIndex = 8;
            this.BValidate.Text = "Valider";
            this.BValidate.UseVisualStyleBackColor = true;
            this.BValidate.Click += new System.EventHandler(this.BValidate_Click);
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(247, 141);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(75, 23);
            this.BClear.TabIndex = 9;
            this.BClear.Text = "Effacer";
            this.BClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 183);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BValidate);
            this.Controls.Add(this.LZipcode);
            this.Controls.Add(this.LDate);
            this.Controls.Add(this.LAmount);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.TbZipcode);
            this.Controls.Add(this.TbAmount);
            this.Controls.Add(this.TbDate);
            this.Controls.Add(this.TbName);
            this.Name = "Form1";
            this.Text = "Validation Saisie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TbName;
        private TextBox TbDate;
        private TextBox TbAmount;
        private TextBox TbZipcode;
        private Label LName;
        private Label LAmount;
        private Label LDate;
        private Label LZipcode;
        private Button BValidate;
        private Button BClear;
    }
}