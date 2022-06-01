namespace _03_input_control
{
    partial class InputControlesForm
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
            this.components = new System.ComponentModel.Container();
            this.LabelName = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.LabelZipcode = new System.Windows.Forms.Label();
            this.BtnValidate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.MtbDate = new System.Windows.Forms.MaskedTextBox();
            this.MtbZipcode = new System.Windows.Forms.MaskedTextBox();
            this.TbAmount = new System.Windows.Forms.TextBox();
            this.LabelDateExample = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 32);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(34, 15);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Nom";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(107, 29);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(151, 23);
            this.TbName.TabIndex = 1;
            this.TbName.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(12, 61);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(31, 15);
            this.LabelDate.TabIndex = 2;
            this.LabelDate.Text = "Date";
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Location = new System.Drawing.Point(12, 90);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(53, 15);
            this.LabelAmount.TabIndex = 4;
            this.LabelAmount.Text = "Montant";
            // 
            // LabelZipcode
            // 
            this.LabelZipcode.AutoSize = true;
            this.LabelZipcode.Location = new System.Drawing.Point(12, 119);
            this.LabelZipcode.Name = "LabelZipcode";
            this.LabelZipcode.Size = new System.Drawing.Size(70, 15);
            this.LabelZipcode.TabIndex = 6;
            this.LabelZipcode.Text = "Code postal";
            // 
            // BtnValidate
            // 
            this.BtnValidate.Location = new System.Drawing.Point(290, 119);
            this.BtnValidate.Name = "BtnValidate";
            this.BtnValidate.Size = new System.Drawing.Size(75, 23);
            this.BtnValidate.TabIndex = 7;
            this.BtnValidate.Text = "Valider";
            this.BtnValidate.UseVisualStyleBackColor = true;
            this.BtnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(290, 148);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "Effacer";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // MtbDate
            // 
            this.MtbDate.Location = new System.Drawing.Point(107, 58);
            this.MtbDate.Mask = "00/00/0000";
            this.MtbDate.Name = "MtbDate";
            this.MtbDate.Size = new System.Drawing.Size(97, 23);
            this.MtbDate.TabIndex = 9;
            this.MtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // MtbZipcode
            // 
            this.MtbZipcode.Location = new System.Drawing.Point(107, 116);
            this.MtbZipcode.Mask = "00000";
            this.MtbZipcode.Name = "MtbZipcode";
            this.MtbZipcode.Size = new System.Drawing.Size(52, 23);
            this.MtbZipcode.TabIndex = 10;
            // 
            // TbAmount
            // 
            this.TbAmount.Location = new System.Drawing.Point(107, 87);
            this.TbAmount.Name = "TbAmount";
            this.TbAmount.Size = new System.Drawing.Size(97, 23);
            this.TbAmount.TabIndex = 11;
            this.TbAmount.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // LabelDateExample
            // 
            this.LabelDateExample.AutoSize = true;
            this.LabelDateExample.Location = new System.Drawing.Point(225, 61);
            this.LabelDateExample.Name = "LabelDateExample";
            this.LabelDateExample.Size = new System.Drawing.Size(87, 15);
            this.LabelDateExample.TabIndex = 12;
            this.LabelDateExample.Text = "(JJ/MM/AAAA)";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InputControlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 189);
            this.Controls.Add(this.LabelDateExample);
            this.Controls.Add(this.TbAmount);
            this.Controls.Add(this.MtbZipcode);
            this.Controls.Add(this.MtbDate);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnValidate);
            this.Controls.Add(this.LabelZipcode);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.LabelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "InputControlesForm";
            this.Text = "Les contrôles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputControlesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelName;
        private TextBox TbName;
        private Label LabelDate;
        private Label LabelAmount;
        private Label LabelZipcode;
        private Button BtnValidate;
        private Button BtnClear;
        private MaskedTextBox MtbDate;
        private Label LabelDateExample;
        private TextBox TbAmount;
        private MaskedTextBox MtbZipcode;
        private ErrorProvider errorProvider1;
    }
}