namespace LoanCourse
{
    partial class PeriodUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNbMonth = new System.Windows.Forms.Label();
            this.scrollbarNbMonth = new System.Windows.Forms.HScrollBar();
            this.lbPeriodicity = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelNbMonth
            // 
            this.labelNbMonth.AutoSize = true;
            this.labelNbMonth.Location = new System.Drawing.Point(3, 21);
            this.labelNbMonth.Name = "labelNbMonth";
            this.labelNbMonth.Size = new System.Drawing.Size(13, 15);
            this.labelNbMonth.TabIndex = 0;
            this.labelNbMonth.Text = "1";
            // 
            // scrollbarNbMonth
            // 
            this.scrollbarNbMonth.Location = new System.Drawing.Point(60, 19);
            this.scrollbarNbMonth.Name = "scrollbarNbMonth";
            this.scrollbarNbMonth.Size = new System.Drawing.Size(142, 17);
            this.scrollbarNbMonth.TabIndex = 1;
            this.scrollbarNbMonth.ValueChanged += new System.EventHandler(this.scrollbarNbMonth_ValueChanged);
            // 
            // lbPeriodicity
            // 
            this.lbPeriodicity.FormattingEnabled = true;
            this.lbPeriodicity.ItemHeight = 15;
            this.lbPeriodicity.Location = new System.Drawing.Point(3, 52);
            this.lbPeriodicity.Name = "lbPeriodicity";
            this.lbPeriodicity.Size = new System.Drawing.Size(120, 94);
            this.lbPeriodicity.TabIndex = 2;
            this.lbPeriodicity.SelectedIndexChanged += new System.EventHandler(this.lbPeriodicity_SelectedIndexChanged);
            // 
            // PeriodUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbPeriodicity);
            this.Controls.Add(this.scrollbarNbMonth);
            this.Controls.Add(this.labelNbMonth);
            this.Name = "PeriodUserControl";
            this.Size = new System.Drawing.Size(243, 173);
            this.Load += new System.EventHandler(this.PeriodUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNbMonth;
        private HScrollBar scrollbarNbMonth;
        private ListBox lbPeriodicity;
    }
}
