namespace CommandExempleConcret
{
    partial class UICommandes
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
            this.bLeft = new System.Windows.Forms.Button();
            this.bRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLeft
            // 
            this.bLeft.Location = new System.Drawing.Point(13, 37);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(75, 23);
            this.bLeft.TabIndex = 0;
            this.bLeft.Text = "Gauche";
            this.bLeft.UseVisualStyleBackColor = true;
            // 
            // bRight
            // 
            this.bRight.Location = new System.Drawing.Point(113, 37);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(75, 23);
            this.bRight.TabIndex = 1;
            this.bRight.Text = "Droite";
            this.bRight.UseVisualStyleBackColor = true;
            // 
            // UICommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bRight);
            this.Controls.Add(this.bLeft);
            this.Name = "UICommandes";
            this.Size = new System.Drawing.Size(224, 97);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bLeft;
        private Button bRight;
    }
}
