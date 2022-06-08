namespace _08_BorrowCalc
{
    partial class BorrowCalcForm
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
            this.PDefineOptionsBorrow = new System.Windows.Forms.Panel();
            this.HsbDurationMonthsRepayment = new System.Windows.Forms.HScrollBar();
            this.LHowManyMonthsRepayment = new System.Windows.Forms.Label();
            this.LDurationMonthsRepayment = new System.Windows.Forms.Label();
            this.TbBorrowedCapital = new System.Windows.Forms.TextBox();
            this.LBorrowedCapital = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbRepaymentFrequency = new System.Windows.Forms.ListBox();
            this.LRepaymentFrequency = new System.Windows.Forms.Label();
            this.GbInterestRate = new System.Windows.Forms.GroupBox();
            this.RbInterestRate9Percent = new System.Windows.Forms.RadioButton();
            this.RbInterestRate8Percent = new System.Windows.Forms.RadioButton();
            this.RbInterestRate7Percent = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LRefundTotal = new System.Windows.Forms.Label();
            this.LPresentRefund = new System.Windows.Forms.Label();
            this.errorProviderOptions1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PDefineOptionsBorrow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GbInterestRate.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOptions1)).BeginInit();
            this.SuspendLayout();
            // 
            // PDefineOptionsBorrow
            // 
            this.PDefineOptionsBorrow.Controls.Add(this.HsbDurationMonthsRepayment);
            this.PDefineOptionsBorrow.Controls.Add(this.LHowManyMonthsRepayment);
            this.PDefineOptionsBorrow.Controls.Add(this.LDurationMonthsRepayment);
            this.PDefineOptionsBorrow.Controls.Add(this.TbBorrowedCapital);
            this.PDefineOptionsBorrow.Controls.Add(this.LBorrowedCapital);
            this.PDefineOptionsBorrow.Controls.Add(this.TbName);
            this.PDefineOptionsBorrow.Controls.Add(this.LName);
            this.PDefineOptionsBorrow.Location = new System.Drawing.Point(12, 12);
            this.PDefineOptionsBorrow.Name = "PDefineOptionsBorrow";
            this.PDefineOptionsBorrow.Size = new System.Drawing.Size(285, 100);
            this.PDefineOptionsBorrow.TabIndex = 0;
            // 
            // HsbDurationMonthsRepayment
            // 
            this.HsbDurationMonthsRepayment.Location = new System.Drawing.Point(147, 62);
            this.HsbDurationMonthsRepayment.Name = "HsbDurationMonthsRepayment";
            this.HsbDurationMonthsRepayment.Size = new System.Drawing.Size(127, 17);
            this.HsbDurationMonthsRepayment.TabIndex = 2;
            this.HsbDurationMonthsRepayment.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarControls_DataChanged);
            // 
            // LHowManyMonthsRepayment
            // 
            this.LHowManyMonthsRepayment.AutoSize = true;
            this.LHowManyMonthsRepayment.Location = new System.Drawing.Point(119, 62);
            this.LHowManyMonthsRepayment.Name = "LHowManyMonthsRepayment";
            this.LHowManyMonthsRepayment.Size = new System.Drawing.Size(25, 15);
            this.LHowManyMonthsRepayment.TabIndex = 5;
            this.LHowManyMonthsRepayment.Text = "120";
            // 
            // LDurationMonthsRepayment
            // 
            this.LDurationMonthsRepayment.Location = new System.Drawing.Point(3, 62);
            this.LDurationMonthsRepayment.Name = "LDurationMonthsRepayment";
            this.LDurationMonthsRepayment.Size = new System.Drawing.Size(110, 35);
            this.LDurationMonthsRepayment.TabIndex = 4;
            this.LDurationMonthsRepayment.Text = "Durée en mois du remboursement";
            // 
            // TbBorrowedCapital
            // 
            this.TbBorrowedCapital.Location = new System.Drawing.Point(119, 32);
            this.TbBorrowedCapital.Name = "TbBorrowedCapital";
            this.TbBorrowedCapital.Size = new System.Drawing.Size(155, 23);
            this.TbBorrowedCapital.TabIndex = 1;
            this.TbBorrowedCapital.TextChanged += new System.EventHandler(this.GeneralControls_DataChanged);
            // 
            // LBorrowedCapital
            // 
            this.LBorrowedCapital.AutoSize = true;
            this.LBorrowedCapital.Location = new System.Drawing.Point(3, 35);
            this.LBorrowedCapital.Name = "LBorrowedCapital";
            this.LBorrowedCapital.Size = new System.Drawing.Size(99, 15);
            this.LBorrowedCapital.TabIndex = 2;
            this.LBorrowedCapital.Text = "Capital Emprunté";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(119, 3);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(155, 23);
            this.TbName.TabIndex = 0;
            this.TbName.TextChanged += new System.EventHandler(this.GeneralControls_DataChanged);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(3, 6);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(34, 15);
            this.LName.TabIndex = 0;
            this.LName.Text = "Nom";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LbRepaymentFrequency);
            this.panel1.Controls.Add(this.LRepaymentFrequency);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 100);
            this.panel1.TabIndex = 1;
            // 
            // LbRepaymentFrequency
            // 
            this.LbRepaymentFrequency.FormattingEnabled = true;
            this.LbRepaymentFrequency.ItemHeight = 15;
            this.LbRepaymentFrequency.Location = new System.Drawing.Point(0, 18);
            this.LbRepaymentFrequency.Name = "LbRepaymentFrequency";
            this.LbRepaymentFrequency.Size = new System.Drawing.Size(217, 64);
            this.LbRepaymentFrequency.TabIndex = 3;
            this.LbRepaymentFrequency.SelectedIndexChanged += new System.EventHandler(this.GeneralControls_DataChanged);
            // 
            // LRepaymentFrequency
            // 
            this.LRepaymentFrequency.AutoSize = true;
            this.LRepaymentFrequency.Location = new System.Drawing.Point(3, 0);
            this.LRepaymentFrequency.Name = "LRepaymentFrequency";
            this.LRepaymentFrequency.Size = new System.Drawing.Size(167, 15);
            this.LRepaymentFrequency.TabIndex = 0;
            this.LRepaymentFrequency.Text = "Périodicité de remboursement";
            // 
            // GbInterestRate
            // 
            this.GbInterestRate.Controls.Add(this.RbInterestRate9Percent);
            this.GbInterestRate.Controls.Add(this.RbInterestRate8Percent);
            this.GbInterestRate.Controls.Add(this.RbInterestRate7Percent);
            this.GbInterestRate.Location = new System.Drawing.Point(303, 12);
            this.GbInterestRate.Name = "GbInterestRate";
            this.GbInterestRate.Size = new System.Drawing.Size(93, 100);
            this.GbInterestRate.TabIndex = 2;
            this.GbInterestRate.TabStop = false;
            this.GbInterestRate.Text = "Taux d\'intérêt";
            // 
            // RbInterestRate9Percent
            // 
            this.RbInterestRate9Percent.AutoSize = true;
            this.RbInterestRate9Percent.Location = new System.Drawing.Point(23, 72);
            this.RbInterestRate9Percent.Name = "RbInterestRate9Percent";
            this.RbInterestRate9Percent.Size = new System.Drawing.Size(44, 19);
            this.RbInterestRate9Percent.TabIndex = 6;
            this.RbInterestRate9Percent.TabStop = true;
            this.RbInterestRate9Percent.Tag = "9";
            this.RbInterestRate9Percent.Text = "9 %";
            this.RbInterestRate9Percent.UseVisualStyleBackColor = true;
            this.RbInterestRate9Percent.CheckedChanged += new System.EventHandler(this.GeneralControls_DataChanged);
            // 
            // RbInterestRate8Percent
            // 
            this.RbInterestRate8Percent.AutoSize = true;
            this.RbInterestRate8Percent.Location = new System.Drawing.Point(23, 47);
            this.RbInterestRate8Percent.Name = "RbInterestRate8Percent";
            this.RbInterestRate8Percent.Size = new System.Drawing.Size(44, 19);
            this.RbInterestRate8Percent.TabIndex = 5;
            this.RbInterestRate8Percent.TabStop = true;
            this.RbInterestRate8Percent.Tag = "8";
            this.RbInterestRate8Percent.Text = "8 %";
            this.RbInterestRate8Percent.UseVisualStyleBackColor = true;
            this.RbInterestRate8Percent.CheckedChanged += new System.EventHandler(this.GeneralControls_DataChanged);
            // 
            // RbInterestRate7Percent
            // 
            this.RbInterestRate7Percent.AutoSize = true;
            this.RbInterestRate7Percent.Location = new System.Drawing.Point(23, 22);
            this.RbInterestRate7Percent.Name = "RbInterestRate7Percent";
            this.RbInterestRate7Percent.Size = new System.Drawing.Size(44, 19);
            this.RbInterestRate7Percent.TabIndex = 4;
            this.RbInterestRate7Percent.TabStop = true;
            this.RbInterestRate7Percent.Tag = "7";
            this.RbInterestRate7Percent.Text = "7 %";
            this.RbInterestRate7Percent.UseVisualStyleBackColor = true;
            this.RbInterestRate7Percent.CheckedChanged += new System.EventHandler(this.GeneralControls_DataChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BReset);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LRefundTotal);
            this.panel2.Controls.Add(this.LPresentRefund);
            this.panel2.Location = new System.Drawing.Point(250, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 100);
            this.panel2.TabIndex = 3;
            // 
            // BReset
            // 
            this.BReset.Location = new System.Drawing.Point(35, 59);
            this.BReset.Name = "BReset";
            this.BReset.Size = new System.Drawing.Size(75, 23);
            this.BReset.TabIndex = 9;
            this.BReset.Text = "Annuler";
            this.BReset.UseVisualStyleBackColor = true;
            this.BReset.Click += new System.EventHandler(this.BReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "0";
            // 
            // LRefundTotal
            // 
            this.LRefundTotal.AutoSize = true;
            this.LRefundTotal.ForeColor = System.Drawing.Color.Red;
            this.LRefundTotal.Location = new System.Drawing.Point(72, 34);
            this.LRefundTotal.Name = "LRefundTotal";
            this.LRefundTotal.Size = new System.Drawing.Size(37, 15);
            this.LRefundTotal.TabIndex = 7;
            this.LRefundTotal.Text = "0,00 €";
            // 
            // LPresentRefund
            // 
            this.LPresentRefund.AutoSize = true;
            this.LPresentRefund.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LPresentRefund.Location = new System.Drawing.Point(29, 9);
            this.LPresentRefund.Name = "LPresentRefund";
            this.LPresentRefund.Size = new System.Drawing.Size(109, 17);
            this.LPresentRefund.TabIndex = 6;
            this.LPresentRefund.Text = "Remboursement";
            // 
            // errorProviderOptions1
            // 
            this.errorProviderOptions1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderOptions1.ContainerControl = this;
            // 
            // BorrowCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 226);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GbInterestRate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PDefineOptionsBorrow);
            this.Name = "BorrowCalcForm";
            this.Text = "Emprunts";
            this.PDefineOptionsBorrow.ResumeLayout(false);
            this.PDefineOptionsBorrow.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbInterestRate.ResumeLayout(false);
            this.GbInterestRate.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOptions1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PDefineOptionsBorrow;
        private Label LDurationMonthsRepayment;
        private TextBox TbBorrowedCapital;
        private Label LBorrowedCapital;
        private TextBox TbName;
        private Label LName;
        private Label LHowManyMonthsRepayment;
        private HScrollBar HsbDurationMonthsRepayment;
        private Panel panel1;
        private ListBox LbRepaymentFrequency;
        private Label LRepaymentFrequency;
        private GroupBox GbInterestRate;
        private RadioButton RbInterestRate9Percent;
        private RadioButton RbInterestRate8Percent;
        private RadioButton RbInterestRate7Percent;
        private Panel panel2;
        private Label label1;
        private Label LRefundTotal;
        private Label LPresentRefund;
        private ErrorProvider errorProviderOptions1;
        private Button BReset;
    }
}