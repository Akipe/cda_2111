namespace CommandExempleConcret
{
    partial class UI
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
            this.zoneJeu = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // zoneJeu
            // 
            this.zoneJeu.Location = new System.Drawing.Point(12, 115);
            this.zoneJeu.Name = "zoneJeu";
            this.zoneJeu.Size = new System.Drawing.Size(953, 238);
            this.zoneJeu.TabIndex = 1;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 377);
            this.Controls.Add(this.zoneJeu);
            this.Name = "UI";
            this.Text = "Interface Graphique";
            this.ResumeLayout(false);

        }

        #endregion
        private Panel zoneJeu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}