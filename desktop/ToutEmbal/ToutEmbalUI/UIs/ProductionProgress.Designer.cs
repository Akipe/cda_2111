namespace ToutEmbalUI
{
    partial class ProductionProgress
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
            this.lProduceTime = new System.Windows.Forms.Label();
            this.pbTimeProduce = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lProduceTime
            // 
            this.lProduceTime.AutoSize = true;
            this.lProduceTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lProduceTime.Location = new System.Drawing.Point(3, 5);
            this.lProduceTime.Name = "lProduceTime";
            this.lProduceTime.Size = new System.Drawing.Size(101, 20);
            this.lProduceTime.TabIndex = 0;
            this.lProduceTime.Text = "Production A";
            // 
            // pbTimeProduce
            // 
            this.pbTimeProduce.Location = new System.Drawing.Point(192, 5);
            this.pbTimeProduce.Name = "pbTimeProduce";
            this.pbTimeProduce.Size = new System.Drawing.Size(264, 23);
            this.pbTimeProduce.TabIndex = 1;
            // 
            // ProducerLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbTimeProduce);
            this.Controls.Add(this.lProduceTime);
            this.Name = "ProducerLoading";
            this.Size = new System.Drawing.Size(459, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lProduceTime;
        private ProgressBar pbTimeProduce;
    }
}
