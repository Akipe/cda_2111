namespace _01_MagicButton
{
    partial class MagicForm
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
            this.magicButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // magicButton
            // 
            this.magicButton.Location = new System.Drawing.Point(0, 0);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(50, 50);
            this.magicButton.TabIndex = 0;
            this.magicButton.Text = "Clique";
            this.magicButton.UseVisualStyleBackColor = false;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // MagicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.magicButton);
            this.Name = "MagicForm";
            this.Text = "MagicForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button magicButton;
    }
}