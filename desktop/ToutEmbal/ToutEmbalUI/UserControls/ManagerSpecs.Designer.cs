namespace ToutEmbalUI
{
    partial class ManagerSpecs
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
            this.lNbProducts = new System.Windows.Forms.Label();
            this.lDefectRateLastHour = new System.Windows.Forms.Label();
            this.lDefectRateAllTime = new System.Windows.Forms.Label();
            this.tbNbProducts = new System.Windows.Forms.TextBox();
            this.tbDefectRateLastHour = new System.Windows.Forms.TextBox();
            this.tbDefectRateAllTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lNbProducts
            // 
            this.lNbProducts.AutoSize = true;
            this.lNbProducts.Location = new System.Drawing.Point(3, 17);
            this.lNbProducts.Name = "lNbProducts";
            this.lNbProducts.Size = new System.Drawing.Size(216, 15);
            this.lNbProducts.TabIndex = 0;
            this.lNbProducts.Text = "Nombre de caisses depuis le démarrage";
            // 
            // lDefectRateLastHour
            // 
            this.lDefectRateLastHour.AutoSize = true;
            this.lDefectRateLastHour.Location = new System.Drawing.Point(3, 56);
            this.lDefectRateLastHour.Name = "lDefectRateLastHour";
            this.lDefectRateLastHour.Size = new System.Drawing.Size(101, 15);
            this.lDefectRateLastHour.TabIndex = 1;
            this.lDefectRateLastHour.Text = "Taux défaut heure";
            // 
            // lDefectRateAllTime
            // 
            this.lDefectRateAllTime.AutoSize = true;
            this.lDefectRateAllTime.Location = new System.Drawing.Point(3, 93);
            this.lDefectRateAllTime.Name = "lDefectRateAllTime";
            this.lDefectRateAllTime.Size = new System.Drawing.Size(166, 15);
            this.lDefectRateAllTime.TabIndex = 2;
            this.lDefectRateAllTime.Text = "Taux défaut depuis démarrage";
            // 
            // tbNbProducts
            // 
            this.tbNbProducts.Location = new System.Drawing.Point(245, 14);
            this.tbNbProducts.Name = "tbNbProducts";
            this.tbNbProducts.Size = new System.Drawing.Size(100, 23);
            this.tbNbProducts.TabIndex = 3;
            // 
            // tbDefectRateLastHour
            // 
            this.tbDefectRateLastHour.Location = new System.Drawing.Point(245, 53);
            this.tbDefectRateLastHour.Name = "tbDefectRateLastHour";
            this.tbDefectRateLastHour.Size = new System.Drawing.Size(100, 23);
            this.tbDefectRateLastHour.TabIndex = 4;
            // 
            // tbDefectRateAllTime
            // 
            this.tbDefectRateAllTime.Location = new System.Drawing.Point(245, 93);
            this.tbDefectRateAllTime.Name = "tbDefectRateAllTime";
            this.tbDefectRateAllTime.Size = new System.Drawing.Size(100, 23);
            this.tbDefectRateAllTime.TabIndex = 5;
            // 
            // ProducerSpecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbDefectRateAllTime);
            this.Controls.Add(this.tbDefectRateLastHour);
            this.Controls.Add(this.tbNbProducts);
            this.Controls.Add(this.lDefectRateAllTime);
            this.Controls.Add(this.lDefectRateLastHour);
            this.Controls.Add(this.lNbProducts);
            this.Name = "ProducerSpecs";
            this.Size = new System.Drawing.Size(365, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lNbProducts;
        private Label lDefectRateLastHour;
        private Label lDefectRateAllTime;
        private TextBox tbNbProducts;
        private TextBox tbDefectRateLastHour;
        private TextBox tbDefectRateAllTime;
    }
}
