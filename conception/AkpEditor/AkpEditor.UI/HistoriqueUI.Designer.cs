namespace AkpEditor.UI
{
    partial class HistoriqueUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbHistorique = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbHistorique
            // 
            this.lbHistorique.FormattingEnabled = true;
            this.lbHistorique.ItemHeight = 15;
            this.lbHistorique.Location = new System.Drawing.Point(12, 12);
            this.lbHistorique.Name = "lbHistorique";
            this.lbHistorique.Size = new System.Drawing.Size(289, 259);
            this.lbHistorique.TabIndex = 0;
            // 
            // HistoriqueUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 284);
            this.Controls.Add(this.lbHistorique);
            this.Name = "HistoriqueUI";
            this.Text = "Historique";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbHistorique;
    }
}